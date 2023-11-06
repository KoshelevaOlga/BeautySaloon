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

namespace BeautySaloon.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для NewServisWindow.xaml
    /// </summary>
    public partial class NewServisWindow : Window
    {
        public NewServisWindow()
        {
            InitializeComponent();
            Categoru.ItemsSource = ClassHelper.EF.Context.Category.ToList();
            Categoru.DisplayMemberPath = "Title";
            Categoru.SelectedIndex = 0;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Title.Text))
            {
                MessageBox.Show("Поле Название не заполнено");
                return;
            }
            if(string.IsNullOrWhiteSpace(Categoru.Text))
            {
                MessageBox.Show("Поле Категория не заполнено");
                return;
            }
            if(string.IsNullOrWhiteSpace(Duration.Text))
            {
                MessageBox.Show("Поле Длительность не заполнено");
                return;
            }
            if(string.IsNullOrWhiteSpace(Cost.Text))
            {
                MessageBox.Show("Поле Стоимость не заполнено");
                return;
            }

            BD.Service service = new BD.Service();
            service.Title = Title.Text;
            service.CategoryId = (Categoru.SelectedItem as BD.Category).ID;
            service.DurationInSecond = Convert.ToInt16( Duration.Text);
            service.Cost = Convert.ToInt16( Cost.Text);
            ClassHelper.EF.Context.SaveChanges();
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
