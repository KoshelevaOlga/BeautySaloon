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
    /// Логика взаимодействия для EditServiceWindow.xaml
    /// </summary>
    public partial class EditServiceWindow : Window
    {
        BD.Service editService = null;
        private bool isEdit = false;
        public EditServiceWindow()
        {
            InitializeComponent();
            isEdit = false;
        }
        public EditServiceWindow(BD.Service service)
        {
            InitializeComponent();
            isEdit = true;
            editService = service;

            TbTitle.Text = service.Title;

            CbCategoru.ItemsSource = ClassHelper.EF.Context.Category.ToList();
            CbCategoru.DisplayMemberPath = "Title";

            TbDuration.Text = Convert.ToString( service.DurationInSecond);
            TbCost.Text = Convert.ToString(service.Title);

            CbCategoru.ItemsSource = ClassHelper.EF.Context.Category.Where(i=> i.ID == service.CategoryId).ToList();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            editService.Title = TbTitle.Text;
            editService.CategoryId = (CbCategoru.SelectedItem as BD.Category).ID;
            editService.DurationInSecond = Convert.ToInt32(TbDuration.Text);
            editService.Cost = Convert.ToInt32(TbCost.Text);

            ClassHelper.EF.Context.SaveChanges();
            MessageBox.Show("Данные успешно сохранны");

        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
