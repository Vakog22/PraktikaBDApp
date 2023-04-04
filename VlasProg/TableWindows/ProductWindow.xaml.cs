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

namespace VlasProg.TableWindows
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData() => DG.ItemsSource = Context.Product.ToList();

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
    }
}
