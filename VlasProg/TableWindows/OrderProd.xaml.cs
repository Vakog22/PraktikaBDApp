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
using VlasProg.AddingWindows;

namespace VlasProg.TableWindows
{
    /// <summary>
    /// Логика взаимодействия для OrderProd.xaml
    /// </summary>
    public partial class OrderProdWindow : Window
    {
        public OrderProdWindow()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData() => DG.ItemsSource = Context.OrderProd.ToList();

        private void BTN_UPDATE_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void BTN_SAVE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Context.SaveChanges();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            AddPrderProdWindow addPrderProdWindow = new AddPrderProdWindow();
            addPrderProdWindow.Show();
        }

        private void BTN_DELETE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderProd orderRes = (DG.SelectedItem as OrderProd);
                Context.OrderProd.Remove(orderRes);
                Context.SaveChanges();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (CBIsDone.IsChecked == true)
                {
                    DG.ItemsSource = Context.OrderProd.ToList().Where(i => i.Product.Name.Contains(TBSearch.Text) && i.IsDone == true);
                }
                else
                {
                    DG.ItemsSource = Context.OrderProd.ToList().Where(i => i.Product.Name.Contains(TBSearch.Text) && i.IsDone == false);
                }
            }
            catch (Exception)
            {

            }
        }

        private void CBIsDone_Checked(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.OrderProd.ToList().Where(i => i.IsDone == true);
        }

        private void CBIsDone_Unchecked(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.OrderProd.ToList().Where(i => i.IsDone == false);
        }
    }
}
