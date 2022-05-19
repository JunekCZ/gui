using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interakční logika pro Register.xaml
    /// </summary>
    public partial class Register : Window {
        private Facade facade;
        public Register(Facade facade) {
            InitializeComponent();
            this.facade = facade;
            SetColors();
        }

        private void SetColors() {
            registerButton.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
            for (int i = 0; i < contentGrid.Children.Count; i++) {
                if (contentGrid.Children[i].GetType() == typeof(Border)) {
                    Border b = (Border) contentGrid.Children[i];
                    b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
                    if (b.Child.GetType() == typeof(TextBox)) {
                        TextBox l = (TextBox) b.Child;
                        l.Background = Brushes.Transparent;
                        l.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
                        l.BorderThickness = new Thickness(0);
                    }
                }
            }
            passwordBox.Background = Brushes.Transparent;
            passwordBox.Foreground = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
            passwordBox.BorderThickness = new Thickness(0);
        }

        private void onTextBoxGotLostFocus(object sender, RoutedEventArgs e) {
            TextBox tb = (TextBox) sender;
            if (tb.Text == string.Empty)
                tb.Text = tb.Tag.ToString();
        }

        private void onTextBoxGotFocus(object sender, RoutedEventArgs e) {
            TextBox tb = (TextBox)sender;
            if (tb.Text == tb.Tag.ToString())
                tb.Text = "";
        }

        private void onPasswordBoxGotLostFocus(object sender, RoutedEventArgs e) {
            PasswordBox tb = (PasswordBox)sender;
            if (tb.Password == string.Empty)
                tb.Password = tb.Tag.ToString();
        }

        private void onPasswordBoxGotFocus(object sender, RoutedEventArgs e) {
            PasswordBox tb = (PasswordBox) sender;
            if (tb.Password == tb.Tag.ToString())
                tb.Password = "";
        }

        private void onRegisterButtonMouseLeave(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onRegisterButtonMouseEnter(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onRegisterButtonClick(object sender, RoutedEventArgs e) {
            string firstname = firstnameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordBox.Password;
            if (!ValidateFirstname(firstname))
                return;
            if (!ValidateLastname(lastname))
                return;
            if (!ValidateEmail(email))
                return;
            if (!ValidatePassword(password))
                return;

            if (facade.Register(firstname, lastname, email, password)) {
                MessageBox.Show("Úspěšně zaregistrováno! Nyní se můžete přihlásit.");
                this.Close();
            } else
                MessageBox.Show("Nepodařilo se zaregistrovat uživatele. Kontaktujte prosím administrátora.");
        }

        private bool ValidateFirstname(string firstname) {
            if (firstname.Length < 4) {
                MessageBox.Show("Jméno je ve špatném formátu.");
                return false;
            }
            return true;
        }

        private bool ValidateLastname(string lastname) {
            if (lastname.Length < 4) {
                MessageBox.Show("Příjmení je ve špatném formátu.");
                return false;
            }

            return true;
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

        private void CloseForm(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}