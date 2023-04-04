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
    /// Логика взаимодействия для OrderRes.xaml
    /// </summary>
    public partial class OrderResWindow : Window
    {
        public OrderResWindow()
        {
            InitializeComponent();
            GetData();
            CBSupplier.ItemsSource = Context.Supplier.ToList();
            CBSupplier.SelectedIndex = 0;
            CBSupplier.DisplayMemberPath = "Name";
        }
        public void GetData() => DG.ItemsSource = Context.OrderRes.ToList();

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
            AddOrderResWindow addOrderResWindow = new AddOrderResWindow();
            addOrderResWindow.Show();
        }

        private void BTN_DELETE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderRes orderRes = DG.SelectedItem as OrderRes;
                Context.OrderRes.Remove(orderRes);
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
                    DG.ItemsSource = Context.OrderRes.ToList().Where(i => i.Resource.Name.Contains(TBSearch.Text) && i.IsDone == true);
                }
                else
                {
                    DG.ItemsSource = Context.OrderRes.ToList().Where(i => i.Resource.Name.Contains(TBSearch.Text) && i.IsDone == false);
                }
            }
            catch (Exception)
            {

            }
        }

        private void CBIsDone_Checked(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.OrderRes.ToList().Where(i => i.IsDone == true);
        }

        private void CBIsDone_Unchecked(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.OrderRes.ToList().Where(i => i.IsDone == false);
        }

        private void CBSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DG.ItemsSource = Context.OrderRes.ToList().Where(i => i.Supplier == CBSupplier.SelectedItem as Supplier);
        }
    }
}
