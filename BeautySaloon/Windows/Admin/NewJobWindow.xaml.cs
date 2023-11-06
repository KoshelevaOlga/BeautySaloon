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
using System.Xml.Linq;

namespace BeautySaloon.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для NewJobWindow.xaml
    /// </summary>
    public partial class NewJobWindow : Window
    {
        public NewJobWindow()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title.Text))
            {
                MessageBox.Show("Поле Название не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Salary.Text))
            {
                MessageBox.Show("Поле Зарплата не заполнено");
                return;
            }

            BD.JobTitle jobTitle = new BD.JobTitle();
            jobTitle.Title = Title.Text;
            jobTitle.Salary = Convert.ToInt16(Salary.Text);

            ClassHelper.EF.Context.SaveChanges();


            MessageBox.Show("Должность добавлен");
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
