using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace Plechaty_GUI.Views {
    /// <summary>
    /// Interakční logika pro UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window {
        private Facade facade;
        public UserLogin(Facade facade) {
            InitializeComponent();
            this.facade = facade;
            SetColors();
        }

        private void SetColors() {
            emailBorder.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
            emailTextBox.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
            emailTextBox.Background = Brushes.Transparent;
            emailTextBox.BorderThickness = new Thickness(0);
            passwordBorder.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
            passwordTextBox.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
            passwordTextBox.Background = Brushes.Transparent;
            passwordTextBox.BorderThickness = new Thickness(0);
            loginButton.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
            loginButton.Foreground = Brushes.White;
            createAccountLabel.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onEmailTextBoxGotFocus(object sender, RoutedEventArgs e) {
            if (emailTextBox.Text == "Email")
                emailTextBox.Text = "";
        }

        private void onEmailTextBoxLostFocus(object sender, RoutedEventArgs e) {
            if (emailTextBox.Text == "")
                emailTextBox.Text = "Email";
        }

        private void onPasswordTextBoxGotFocus(object sender, RoutedEventArgs e) {
            if (passwordTextBox.Password == "Heslo")
                passwordTextBox.Password = "";
        }

        private void onPasswordTextBoxGotLostFocus(object sender, RoutedEventArgs e) {
            if (passwordTextBox.Password == "")
                passwordTextBox.Password = "Heslo";
        }

        private void CloseLogin(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void onLoginButtonClick(object sender, RoutedEventArgs e) {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Password;
            if (!ValidateEmail(email))
                return;

            if (!ValidatePassword(password))
                return;

            if (facade.LogUserIn(email, password)) {
                this.Close();
                return;
            }

            MessageBox.Show("Chybné údaje.");
        }

        private bool ValidateEmail(string email) {
            string[] atSignPart = email.Split('@');
            if (atSignPart.Length == 2 && email.Length > 6) {
                string[] dotSignPart = email.Split('.');
                if (dotSignPart.Length > 1)
                    return true;
            }
            MessageBox.Show("Email je ve špatném formátu.");
            return false;
        }

        private bool ValidatePassword(string password) {
            if (password.Length < 7) {
                MessageBox.Show("Heslo je ve špatném formátu");
                return false;
            }

            return true;
        }

        private void onCreateAccountLabelMouseDown(object sender, MouseButtonEventArgs e) {
            Register register = new Register(facade);
            register.ShowDialog();
        }

        private void onLoginButtonMouseEnter(object sender, MouseEventArgs e) {
            Button b = (Button) sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onLoginButtonMouseLeave(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onCreateAccountLabelMouseEnter(object sender, MouseEventArgs e) {
            Label l = (Label) sender;
            l.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));

        }

        private void onCreateAccountLabelMouseLeave(object sender, MouseEventArgs e) {
            Label l = (Label) sender;
            l.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }
    }
}