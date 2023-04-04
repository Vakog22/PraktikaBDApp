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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData() => DG.ItemsSource = Context.User.ToList();

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = (DG.SelectedItem as User);
                Auth auth = Context.Auth.ToList().Where(i => i.IdLogin == user.IdLogin).FirstOrDefault() as Auth;
                Context.User.Remove(user);
                Context.SaveChanges();
                Context.Auth.Remove(auth);
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
