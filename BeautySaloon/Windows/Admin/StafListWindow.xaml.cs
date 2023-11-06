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
    /// Логика взаимодействия для StafListWindow.xaml
    /// </summary>
    public partial class StafListWindow : Window
    {
        public StafListWindow()
        {
            InitializeComponent();
            GetEmpList();
        }
        private void GetEmpList()
        {
            LvEmp.ItemsSource = ClassHelper.EF.Context.vw_EmployerList.ToList();
        }
        private void BtnDelit_Clic(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNewEmp_Clic(object sender, RoutedEventArgs e)
        {
            Admin.NewEmployerWindow newEmployerWindow = new Admin.NewEmployerWindow();
            newEmployerWindow.Show();
        }

        private void BtnService_Clic(object sender, RoutedEventArgs e)
        {
            Admin.ServisListWindow servisListWindow = new Admin.ServisListWindow();
            servisListWindow.Show();
            this.Close();
        }

        private void BtnOrder_Clic(object sender, RoutedEventArgs e)
        {
            Admin.OrderListWindow orderListWindow = new Admin.OrderListWindow();
            orderListWindow.Show();
            this.Close();
        }

        private void BtnExit_Clic(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}
