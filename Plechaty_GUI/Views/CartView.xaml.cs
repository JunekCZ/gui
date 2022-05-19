using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Plechaty_GUI.Views {
    /// <summary>
    /// Interakční logika pro CartView.xaml
    /// </summary>
    public partial class CartView : Window {
        private Facade facade;
        public CartView(Facade facade) {
            InitializeComponent();
            this.facade = facade;
            Build();
            SetColor();
        }

        private void SetColor() {
            buyButton.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
            buyButton.Foreground = Brushes.White;
            clearButton.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Skin));
            clearButton.Foreground = Brushes.White;
        }

        private void Build() {
            BuildProducts();
            BuildPrice();
        }

        private void BuildPrice() {
            totalLabel.Content = "Celkem: " + GetTotalPrice() + " kč,-";
        }

        private int? GetTotalPrice() {
            int? sum = 0;
            foreach (DBClasses.Product p in GetFilteredProducts())
                sum += p.Special != null ? p.Special * p.Count : p.Price * p.Count;

            return sum;
        }

        private void BuildProducts() {
            contentBox.ItemsSource = GetFilteredProducts();
        }

        private List<DBClasses.Product> GetFilteredProducts() {
            List<DBClasses.Product> productListFiltered = new List<DBClasses.Product>();
            foreach (DBClasses.Product product in facade.GetProductList()) {
                bool exists = false;
                foreach(DBClasses.Product p in productListFiltered)
                    if (p.Id_p == product.Id_p) {
                        exists = true;
                        p.Count++;
                    }

                if (!exists) {
                    DBClasses.Product productProfile = new DBClasses.Product {
                        Id_p = product.Id_p,
                        Id_c = product.Id_c,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Special = product.Special,
                        Sex = product.Sex,
                        Image_url = product.Image_url,
                        Count = 1
                    };
                    productListFiltered.Add(productProfile);
                }
            }

            return productListFiltered;
        }

        private void onRemoveOneButtonClick(object sender, RoutedEventArgs e) {
            Button b = (Button) sender;
            int id_p = Int32.Parse(b.Tag.ToString());
            facade.RemoveFromList(id_p);
            Build();
        }

        private void onRemoveOneButtonMouseEnter(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onRemoveOneButtonMouseLeave(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onRemoveAllButtonClick(object sender, RoutedEventArgs e) {
            Button b = (Button)sender;
            int id_p = Int32.Parse(b.Tag.ToString());
            facade.RemoveAllFromList(id_p);
            Build();
        }

        private void onRemoveAllButtonMouseEnter(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onRemoveAllButtonMouseLeave(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Skin));
        }

        private void MenuMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void Close_App(object sender, RoutedEventArgs e) {
            Close();
        }

        private void Minimize_App(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        private void onClearButtonMouseEnter(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onClearButtonMouseLeave(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Skin));
        }

        private void onClearButtonClick(object sender, RoutedEventArgs e) {
            facade.ClearProductList();
            Build();
        }

        private void onBuyButtonMouseEnter(object sender, MouseEventArgs e) {
            Button btn = (Button)sender;
            if (facade.GetProductList().Count < 1) {
                btn.Cursor = Cursors.No;
                return;
            }

            btn.Cursor = Cursors.Hand;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onBuyButtonMouseLeave(object sender, MouseEventArgs e) {
            if (facade.GetProductList().Count < 1)
                return;
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onBuyButtonClick(object sender, RoutedEventArgs e) {
            if (!facade.AccountIsLogged()) {
                MessageBox.Show("Nejprve se, prosím, přihlašte.");
                return;
            }

            if (facade.GetProductList().Count < 1)
                return;

            if (facade.BuyProducts(GetFilteredProducts())) {
                facade.ClearProductList();
                Build();
            } else
                MessageBox.Show("Nedostatek zústatku na účtu!");
        }
    }
}