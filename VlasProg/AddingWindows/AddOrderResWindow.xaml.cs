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

using static VlasProg.ClassHelper.DBHelper.DBHelperClass;

namespace VlasProg.AddingWindows
{
    /// <summary>
    /// Логика взаимодействия для AddOrderResWindow.xaml
    /// </summary>
    public partial class AddOrderResWindow : Window
    {
        public AddOrderResWindow()
        {
            InitializeComponent();
            CBSupplier.ItemsSource = Context.Supplier.ToList();
            CBSupplier.SelectedIndex = 0;
            CBSupplier.DisplayMemberPath = "Name";
        }
        private void BTN_SAVE_Click(object sender, RoutedEventArgs e)
        {
            OrderRes orderRes = new OrderRes();
            orderRes.IDSupplier = (CBSupplier.SelectedItem as Supplier).ID;
            orderRes.Date = DateTime.Today.Date;
            orderRes.IDResource = (CBResource.SelectedItem as Resource).ID;
            orderRes.Quantity = Convert.ToInt32(Quantity.Text);
            Context.OrderRes.Add(orderRes);
            Context.SaveChanges();
            this.Close();
        }

        private void CBSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CBResource.ItemsSource = Context.Resource.ToList().Where(i => i.IDSupplier == (CBSupplier.SelectedItem as Supplier).ID);
            CBResource.SelectedIndex = 0;
            CBResource.DisplayMemberPath = "Name";
        }
    }
}
