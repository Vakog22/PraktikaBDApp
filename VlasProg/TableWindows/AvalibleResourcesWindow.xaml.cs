using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace VlasProg.TableWindows
{
    /// <summary>
    /// Логика взаимодействия для AvalibleResourcesWindow.xaml
    /// </summary>
    public partial class AvalibleResourcesWindow : Window
    {
        public AvalibleResourcesWindow()
        {
            InitializeComponent();
            GetData();
            CBSupplier.ItemsSource = Context.Supplier.ToList();
            CBSupplier.SelectedIndex = 0;
            CBSupplier.DisplayMemberPath = "Name";
        }
        public void GetData() { DG.ItemsSource = Context.AvalibleResources.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                DG.ItemsSource = Context.AvalibleResources.ToList().Where(i => i.Resource.Name.Contains(TBSearch.Text));
            }
            catch (Exception)
            {

            }
        }

        private void CBSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DG.ItemsSource = Context.AvalibleResources.ToList().Where(i => i.Resource.Supplier == CBSupplier.SelectedItem as Supplier);
        }

        private void DG_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (Context.AvalibleResources.ToList().ElementAtOrDefault(e.Row.GetIndex()).Quantity > 0) {
                e.Row.Background = Brushes.Green;
            }
        }

    }
}
