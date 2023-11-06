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
    /// Логика взаимодействия для ServisListWindow.xaml
    /// </summary>
    public partial class ServisListWindow : Window
    {
        public ServisListWindow()
        {
            InitializeComponent();
            GetServiceList();
        }
        private void GetServiceList()
        {
            LvService.ItemsSource = ClassHelper.EF.Context.vw_ServicList.ToList();
        }
        private void BtnExit_Clic(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }

        private void BtnOrder_Clic(object sender, RoutedEventArgs e)
        {
            Admin.OrderListWindow orderListWindow = new Admin.OrderListWindow();
            orderListWindow.Show();
            this.Close();
        }

        private void BtnEmployer_Clic(object sender, RoutedEventArgs e)
        {
            Admin.StafListWindow stafListWindow = new Admin.StafListWindow();
            stafListWindow.Show();
            this.Close();
        }

        private void BtnNewService_Clic(object sender, RoutedEventArgs e)
        {
            Admin.NewServisWindow newServisWindow = new Admin.NewServisWindow();
            newServisWindow.Show();
        }

        private void BtnDelit_Clic(object sender, RoutedEventArgs e)
        {

        }

        private void BtnApdate_Clic(object sender, RoutedEventArgs e)
        {
            if (LvService.SelectedItem == null)
            {
                return;
            }
            var service = LvService.SelectedItem as BD.Service;
            ClassHelper.Services.ServiceCard.Add(service);
            Admin.EditServiceWindow editServiceWindow = new Admin.EditServiceWindow(service);
            editServiceWindow.Show();
        }
    }
}
