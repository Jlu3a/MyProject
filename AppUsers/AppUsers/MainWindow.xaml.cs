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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox_1.Password.Trim();
            string pass2 = passbox_2.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();
            if (TextBoxLogin.Text != "" || TextBoxEmail.Text != "" || passbox_1.Password != "" || passbox_2.Password != "")
            {
                Cleaner();
                if (login.Length < 5 || login.Length > 10)
                {
                    TextBoxLogin.ToolTip = "Логин должен состоять из 5-10 символов!";
                    TextBoxLogin.Background = Brushes.DarkRed;
                    TextBoxLogin.Foreground = Brushes.White;
                }
                if (pass1.Length < 5 || pass1.Length > 20)
                { 
                    passbox_1.ToolTip = "Пароль должен состоять из 5-20 символов!";
                    passbox_1.Background = Brushes.DarkRed;
                    passbox_1.Foreground = Brushes.White;
                }
                if (pass1 != pass2 || pass2.Length < 5)
                { 
                    passbox_2.ToolTip = "Поля не сходятся!";
                    passbox_2.Background = Brushes.DarkRed;
                    passbox_2.Foreground = Brushes.White;
                }
                if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
                {
                    TextBoxEmail.ToolTip = "Введите корректный email!";
                    TextBoxEmail.Background = Brushes.DarkRed;
                    TextBoxEmail.Foreground = Brushes.White;
                }
            }
            else
            {
                Cleaner();
                TextBoxLogin.ToolTip = "Поля не заполнены";
                TextBoxEmail.ToolTip = "Поля не заполнены";
                passbox_1.ToolTip = "Поля не заполнены";
                passbox_2.ToolTip = "Поля не заполнены";

                TextBoxEmail.Background = Brushes.DarkRed;
                TextBoxLogin.Background = Brushes.DarkRed;
                passbox_1.Background = Brushes.DarkRed;
                passbox_2.Background = Brushes.DarkRed;

                TextBoxEmail.Foreground = Brushes.White;
                TextBoxLogin.Foreground = Brushes.White;
                passbox_1.Foreground = Brushes.White;
                passbox_2.Foreground = Brushes.White;
            }
        }
        public void Cleaner()
        {
            TextBoxLogin.ToolTip = "";
            passbox_1.ToolTip = "";
            passbox_2.ToolTip = "";
            TextBoxEmail.ToolTip = "";

            TextBoxLogin.Background = Brushes.Transparent;
            passbox_1.Background = Brushes.Transparent;
            passbox_2.Background = Brushes.Transparent;
            TextBoxEmail.Background = Brushes.Transparent;

            TextBoxLogin.Foreground = Brushes.Black;
            passbox_1.Foreground = Brushes.Black;
            passbox_2.Foreground = Brushes.Black;
            TextBoxEmail.Foreground = Brushes.Black;

            return;
        }
    }
}
