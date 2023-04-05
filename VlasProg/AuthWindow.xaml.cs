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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private static Random random = new Random();
        public AuthWindow()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Captcha.Text == TBX_Captcha.Text)
            {
                if (String.IsNullOrWhiteSpace(TbLogin.Text))
                {
                    MessageBox.Show("Введите логин");
                }
                else {
                    if (String.IsNullOrWhiteSpace(PbPassword.Password))
                    {
                        MessageBox.Show("Введите пароль");
                    }
                    else
                    {
                        try
                        {
                            var AuthUser = Context.Auth.ToList().Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();
                            if (AuthUser != null)
                            {
                                var User = Context.User.ToList().Where(i => i.IdLogin == AuthUser.IdLogin).FirstOrDefault();
                                SelectWindow selectWindow = new SelectWindow(AuthUser.AccountType.IdType, User.UserName, AuthUser.IdLogin);
                                selectWindow.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Такого аккаунта нет");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.StackTrace);
                            throw;
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Неверная капча");
                GenerateCaptcha();
            }
        }

        private void GenerateCaptcha() {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            TB_Captcha.Text = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
