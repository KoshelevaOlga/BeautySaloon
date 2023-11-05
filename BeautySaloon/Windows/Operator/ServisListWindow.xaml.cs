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

        private void BtnHistory_Clic(object sender, RoutedEventArgs e)
        {
            Operator.OrderListWindow orderList = new Operator.OrderListWindow();
            orderList.Show();
            this.Close();
        }

        private void BtnNew_Clic(object sender, RoutedEventArgs e)
        {
            Operator.NewOrderWindow newOrder = new Operator.NewOrderWindow();
            newOrder.Show();
        }

        private void BtnExit_Clic(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}
