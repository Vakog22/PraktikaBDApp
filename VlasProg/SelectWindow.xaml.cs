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
using VlasProg.TableWindows;

namespace VlasProg
{
    /// <summary>
    /// Логика взаимодействия для SelectWindow.xaml
    /// </summary>
    public partial class SelectWindow : Window
    {
        int AccountType;
        string UserName;
        int IDACC;
        public SelectWindow(int a, string b, int c)
        {
            AccountType = a;
            UserName = b;
            IDACC = c;
            InitializeComponent();
            TB_Welcome.Text = "Добро пожаловать, \n" + UserName;
            if (AccountType == 2) {
                BTN_Auth.Visibility = Visibility.Collapsed;
                BTN_OrderProd.Visibility = Visibility.Collapsed;
            }
            if (AccountType == 4)
            {
                BTN_AvaliableResources.Visibility = Visibility.Collapsed;
                BTN_Auth.Visibility = Visibility.Collapsed;
                BTN_Resource.Visibility = Visibility.Collapsed;
                BTN_Supplier.Visibility = Visibility.Collapsed;
            }
        }

        private void BTN_AvaliableResources_Click(object sender, RoutedEventArgs e)
        {
            AvalibleResourcesWindow avalibleResources = new AvalibleResourcesWindow();
            avalibleResources.Show();
        }

        private void BTN_Resource_Click(object sender, RoutedEventArgs e)
        {
            ResourceWindow avalibleResources = new ResourceWindow();
            avalibleResources.Show();
        }

        private void BTN_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow avalibleResources = new AuthorizationWindow();
            avalibleResources.Show();
        }

        private void BTN_Supplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow avalibleResources = new SupplierWindow();
            avalibleResources.Show();
        }

        private void BTN_Supplier_Click_1(object sender, RoutedEventArgs e)
        {
            TableWindows.OrderResWindow avalibleResources = new TableWindows.OrderResWindow();
            avalibleResources.Show();
        }

        private void BTN_OrderProd_Click(object sender, RoutedEventArgs e)
        {
            TableWindows.OrderProdWindow avalibleResources = new TableWindows.OrderProdWindow();
            avalibleResources.Show();
        }

        private void BTN_Product_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow avalibleResources = new ProductWindow();
            avalibleResources.Show();
        }

        private void BTN_Cabinet_Click(object sender, RoutedEventArgs e)
        {
            PersonalCabinetWindow PCW = new PersonalCabinetWindow(IDACC);
            PCW.Show();
            this.Close();
        }

        private void BTN_EXIT_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}
