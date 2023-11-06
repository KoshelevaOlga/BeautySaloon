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

namespace BeautySaloon.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для NewEmployerWindow.xaml
    /// </summary>
    public partial class NewEmployerWindow : Window
    {
        public NewEmployerWindow()
        {
            InitializeComponent();
            Job.ItemsSource = ClassHelper.EF.Context.JobTitle.ToList();
            Job.DisplayMemberPath = "Title";
            Job.SelectedIndex = 0;
            Gender.ItemsSource = ClassHelper.EF.Context.Gender.ToList();
            Gender.DisplayMemberPath = "Title";
            Gender.SelectedIndex = 0;
        }

        private void BtnAddJob_Click(object sender, RoutedEventArgs e)
        {
            Admin.NewJobWindow newJobWindow = new Admin.NewJobWindow();
            newJobWindow.Show();
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
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
            if (string.IsNullOrWhiteSpace(Job.Text))
            {
                MessageBox.Show("Поле Должность не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Gender.Text))
            {
                MessageBox.Show("Поле Пол не заполнено");
                return;
            }

            BD.Employer employer = new BD.Employer();
            employer.SureName = LName.Text;
            employer.Name = Name.Text;
            employer.Phone = Phone.Text;
            employer.StaffID = (Job.SelectedItem as BD.JobTitle).ID;
            employer.Login = Login.Text;
            employer.Password = Password.Text;
            employer.Gender = (Gender.SelectedItem as BD.Gender).ID;

            ClassHelper.EF.Context.SaveChanges();


            MessageBox.Show("Пользователь добавлен");
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
