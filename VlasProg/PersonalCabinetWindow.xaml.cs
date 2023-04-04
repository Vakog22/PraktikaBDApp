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

namespace VlasProg
{
    /// <summary>
    /// Логика взаимодействия для PersonalCabinetWindow.xaml
    /// </summary>
    public partial class PersonalCabinetWindow : Window
    {
        int IDACC;
        public PersonalCabinetWindow(int a)
        {
            IDACC = a;
            var AuthUser = Context.Auth.ToList().Where(i => i.IdLogin == IDACC).FirstOrDefault();
            var User = Context.User.ToList().Where(i => i.IdLogin == AuthUser.IdLogin).FirstOrDefault();
            InitializeComponent();

            TBLogin.Text = AuthUser.Login.ToString();
            TBPassword.Text = AuthUser.Password.ToString();
            TBUserName.Text = User.UserName.ToString();
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
                    var AuthUser = Context.Auth.ToList().Where(i => i.IdLogin == IDACC).FirstOrDefault();
                    var User = Context.User.ToList().Where(i => i.IdLogin == AuthUser.IdLogin).FirstOrDefault();
                    AuthUser.Login = TBLogin.Text;
                    AuthUser.Password = TBPassword.Text;
                    User.UserName = TBUserName.Text;
                    Context.SaveChanges();
                    SelectWindow selectWindow = new SelectWindow(AuthUser.AccountType.IdType, User.UserName, AuthUser.IdLogin);
                    selectWindow.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            
        }

        private void BTN_BACK_Click(object sender, RoutedEventArgs e)
        {
            var AuthUser = Context.Auth.ToList().Where(i => i.IdLogin == IDACC).FirstOrDefault();
            var User = Context.User.ToList().Where(i => i.IdLogin == AuthUser.IdLogin).FirstOrDefault();
            SelectWindow selectWindow = new SelectWindow(AuthUser.AccountType.IdType, User.UserName, AuthUser.IdLogin);
            selectWindow.Show();
            this.Close();
        }
    }
}
