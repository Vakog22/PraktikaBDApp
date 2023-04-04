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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();

            CBAccountType.ItemsSource = Context.AccountType.ToList();
            CBAccountType.SelectedIndex = 0;
            CBAccountType.DisplayMemberPath = "TypeName";
        }

        private void BTN_SAVE_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TBLogin.Text) || String.IsNullOrWhiteSpace(TBPassword.Text) || String.IsNullOrWhiteSpace(TBUserName.Text))
            {
                MessageBox.Show("Пустые поля не должны существовать");
            }
            else
            {
                try
                {
                    Auth auth = new Auth();
                    auth.Login = TBLogin.Text;
                    auth.Password = TBPassword.Text;
                    auth.IdType = (CBAccountType.SelectedItem as AccountType).IdType;
                    Context.Auth.Add(auth);
                    Context.SaveChanges();
                    User user = new User();
                    user.IdLogin = Context.Auth.ToList().Where(i => i.Login == auth.Login && i.Password == auth.Password).FirstOrDefault().IdLogin;
                    user.UserName = TBUserName.Text;
                    Context.User.Add(user);
                    Context.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
