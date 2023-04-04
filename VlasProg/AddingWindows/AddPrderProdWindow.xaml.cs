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
    /// Логика взаимодействия для AddPrderProdWindow.xaml
    /// </summary>
    public partial class AddPrderProdWindow : Window
    {
        public AddPrderProdWindow()
        {
            InitializeComponent();
            CBResource.ItemsSource = Context.Product.ToList();
            CBResource.SelectedIndex = 0;
            CBResource.DisplayMemberPath = "Name";
        }
        private void BTN_SAVE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Quantity.Text) > 0)
                {
                    OrderProd orderRes = new OrderProd();
                    orderRes.Date = DateTime.Today.Date;
                    orderRes.IDProduct = (CBResource.SelectedItem as Product).ID;
                    orderRes.Quantity = Convert.ToInt32(Quantity.Text);
                    Context.OrderProd.Add(orderRes);
                    Context.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Кол-во должно быть больше нуля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
