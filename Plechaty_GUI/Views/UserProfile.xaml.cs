using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Plechaty_GUI.Views {
    /// <summary>
    /// Interakční logika pro UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window {
        private Facade facade;
        public UserProfile(Facade facade) {
            InitializeComponent();
            this.facade = facade;
            logoutButton.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
            Build();
        }

        private void Build() {
            BuildName();
            BuildBalance();
            BuildProducts();
        }

        private void BuildName() {
            nameLabel.Content = facade.GetAccountFullName();
        }

        private void BuildBalance() {
            balanceLabel.Content = facade.GetAccountBalance() + " kč";
        }

        private void BuildProducts() {
            contentBox.ItemsSource = GetFilteredProducts();
        }

        private List<DBClasses.Product> GetFilteredProducts() {
            List<DBClasses.Product> productListFiltered = new List<DBClasses.Product>();
            foreach (DBClasses.Product product in facade.GetUsersProductsList(facade.GetUserID())) {
                bool exists = false;
                foreach (DBClasses.Product p in productListFiltered)
                    if (p.Id_p == product.Id_p) {
                        exists = true;
                        p.Count++;
                    }

                if (!exists) {
                    DBClasses.Product productProfile = new DBClasses.Product() {
                        Id_p = product.Id_p,
                        Id_c = product.Id_c,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Special = product.Special,
                        Sex = product.Sex,
                        Image_url = product.Image_url,
                        Count = 0
                    };
                    productListFiltered.Add(productProfile);
                }
            }

            return productListFiltered;
        }

        private void CloseLogin(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void onLogoutMouseEnter(object sender, MouseEventArgs e) {
            Button btn = (Button) sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onLogoutMouseLeave(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onLogoutClick(object sender, RoutedEventArgs e) {
            facade.LogUserOut();
            this.Close();
        }
    }
}