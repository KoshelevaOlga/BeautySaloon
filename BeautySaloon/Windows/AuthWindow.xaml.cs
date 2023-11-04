using BeautySaloon.ClassHelper;
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

namespace BeautySaloon.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void BtnSingIn_Clic(object sender, RoutedEventArgs e)
        {
            var userAuth = ClassHelper.EF.Context.Employer.ToList().Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();
            if (userAuth != null)
            {
                switch (userAuth.StaffID)
                {
                    case 1:
                        Admin.ServisListWindow AServiceListWindow = new Admin.ServisListWindow();
                        AServiceListWindow.Show();
                        this.Close();
                        break;
                    case 2:
                        Operator.ServisListWindow OServiceListWindow = new Operator.ServisListWindow();
                        OServiceListWindow.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
