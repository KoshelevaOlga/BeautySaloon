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
    /// Логика взаимодействия для OrderListWindow.xaml
    /// </summary>
    public partial class OrderListWindow : Window
    {
        public OrderListWindow()
        {
            InitializeComponent();
            GetOrderList();
        }

        private void GetOrderList()
        {
            LvOrder.ItemsSource = ClassHelper.EF.Context.vw_OrderList.ToList();
        }
        private void BtnHistory_Clic(object sender, RoutedEventArgs e)
        {
            Operator.ServisListWindow servisListWindow = new Operator.ServisListWindow();
            servisListWindow.Show();
            this.Close();
        }

        private void BtnNew_Clic(object sender, RoutedEventArgs e)
        {
            Operator.NewOrderWindow newOrderWindow = new Operator.NewOrderWindow();
            newOrderWindow.Show();
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
