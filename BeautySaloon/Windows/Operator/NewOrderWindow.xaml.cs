using BeautySaloon.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BeautySaloon.Windows.Operator
{
    /// <summary>
    /// Логика взаимодействия для NewOrderWindow.xaml
    /// </summary>
    public partial class NewOrderWindow : Window
    {
        public NewOrderWindow()
        {
            InitializeComponent();
            Seervice.ItemsSource = ClassHelper.EF.Context.Service.ToList();
            Seervice.DisplayMemberPath = "Title";
            Seervice.SelectedIndex = 0;
            Staff.ItemsSource = ClassHelper.EF.Context.Employer.ToList();
            Staff.DisplayMemberPath = "SureName";
            Staff.SelectedIndex = 1;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            // валидация
            if (string.IsNullOrWhiteSpace(LName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Name.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Phone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Seervice.Text))
            {
                MessageBox.Show("Поле Услуга не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Staff.Text))
            {
                MessageBox.Show("Поле Мастер не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Date.Text))
            {
                MessageBox.Show("Поле Дата не заполнено");
                return;
            }

            //Добавление данных в сервис стаф
            BD.EmployeService employeService = new BD.EmployeService();
            employeService.Service = (Seervice.SelectedItem as BD.Service).ID;
            employeService.Employer = (Staff.SelectedItem as BD.Employer).ID;
            
            ClassHelper.EF.Context.SaveChanges();

            var userId = button.DataContext as BD.Employer;
            ClassHelper.OperatorId.OperatirId.Remove(userId);

            //Добавление данных в ордер
            BD.Order addOrder = new BD.Order();
            addOrder.SureName = LName.Text;
            addOrder.Name = Name.Text;
            addOrder.Phone = Phone.Text;
            //addOrder.DateTime = ;
            addOrder.Operator = userId.ID;

            ClassHelper.EF.Context.SaveChanges();

            //Добавление данных в ордер сервис
            BD.OrderService orderService = new BD.OrderService();
            //orderService.Order = ();
            //orderService.Service = ();
            ClassHelper.EF.Context.SaveChanges();

            MessageBox.Show("Запись Создана");
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
