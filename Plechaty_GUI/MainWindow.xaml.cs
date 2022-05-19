using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Plechaty_GUI.Category;
using Plechaty_GUI.Pages;
using Plechaty_GUI.Views;

namespace Plechaty_GUI {
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Database db;
        private CategoryListPage categoryListPage;
        private ProductListPage productListPage;
        private Cart.Cart cart;
        private Facade facade;
        public MainWindow() {
            InitializeComponent();
            db = new Database();
            cart = new Cart.Cart(productsCountBorder);
            facade = new Facade(db, cart, productFrame);
            categoryListPage = new CategoryListPage(facade, SpecialGrid);
            productListPage = new ProductListPage(facade);
            facade.ChangePage(productListPage);
            SetColors();

            categoryListPage.AddProductsAction += onAddProductsActionRequested;
            categoryFrame.Navigate(categoryListPage);
        }

        private void onAddProductsActionRequested(int id_c) {
            List<DBClasses.Product> productsList = db.SelectProductsByCategory(id_c);
            if (id_c == 0) {
                Random rngRandom = new Random();
                productListPage.ProductList = productsList.OrderBy(x => rngRandom.Next()).ToList();
            } else
                productListPage.ProductList = productsList;

            facade.ChangePage(productListPage);
        }

        private void SetColors() {
            TopGrid.Background = Brushes.Transparent;
            SearchRect.Fill = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Grey));
            Border b = (Border) SpecialGrid.Children[0];
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Green));
            Circle.BorderBrush = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
        }

        private void MenuMouseDown(object sender, MouseButtonEventArgs e) {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        /**
         * Vypne aplikaci, diky Jurasku
         */
        private void Close_App(object sender, RoutedEventArgs e) {
            App.Current.Shutdown();
        }

        private void Minimize_App(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void FilterGridMouseEnter(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border) g.Children[0];
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
            g.Cursor = Cursors.Hand;
        }
        private void FilterGridMouseLeave(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border) g.Children[0];
            b.Background = Brushes.White;
        }

        private void SearchBoxFocused(object sender, RoutedEventArgs e) {
            SearchBox.Text = SearchBox.Text == "Hledat..." ? "" : SearchBox.Text;
        }

        private void SearchBoxLostFocus(object sender, RoutedEventArgs e) {
            SearchBox.Text = SearchBox.Text == string.Empty ? "Hledat..." : SearchBox.Text;
            if (SearchBox.Text == string.Empty)
                productListPage.ProductList = db.SelectProductsByCategory(SelectedCategory.Selected);
        }

        private void ImageEntered(object sender, MouseEventArgs e) {
            Border b = (Border) sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Grey));
            b.Cursor = Cursors.Hand;
        }

        private void ImageLeave(object sender, MouseEventArgs e) {
            Border b = (Border)sender;
            b.Background = Brushes.White;
        }

        private void CartMouseDown(object sender, MouseButtonEventArgs e) {
            CartView cart = new CartView(facade);
            cart.ShowDialog();
        }

        private void Circle_OnMouseEnter(object sender, MouseEventArgs e) {
            Circle.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Green));
            Circle.BorderBrush = Brushes.Transparent;
            Image img = (Image) Circle.Child;
            ImageSource imgs = (ImageSource)new ImageSourceConverter().ConvertFrom("../../Icons/refresh-white.png");
            img.Source = imgs;
            Circle.Cursor = Cursors.Hand;
        }

        private void Circle_OnMouseLeave(object sender, MouseEventArgs e) {
            Circle.Background = Brushes.Transparent;
            Circle.BorderBrush = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Silver));
            Image img = (Image)Circle.Child;
            ImageSource imgs = (ImageSource)new ImageSourceConverter().ConvertFrom("../../Icons/refresh.png");
            img.Source = imgs;
        }

        private void Circle_OnMouseDown(object sender, MouseButtonEventArgs e) {
            Random rngRandom = new Random();
            List<DBClasses.Product> productsList = db.SelectProductsByCategory(SelectedCategory.Selected);
            productListPage.ProductList = productsList.OrderBy(x => rngRandom.Next()).ToList();
            facade.ChangePage(productListPage);
        }

        private void onAccountBorderMouseDown(object sender, MouseButtonEventArgs e) {
            facade.onAccountBorderMouseDown();
        }

        private void onSearchBoxKeyDown(object sender, KeyEventArgs e) {
            TextBox tb = (TextBox) sender;
            string text = tb.Text;
            if (text.Length < 4)
                return;

            List<DBClasses.Product> productList = facade.GetProductsByName(text).ToList();
            productListPage.ProductList = productList;
            facade.ChangePage(productListPage);
        }

        private void onFilterGridMouseDown(object sender, MouseButtonEventArgs e) {
            Grid g = (Grid)sender;
            if (g.Tag == null) {
                productListPage.ProductList = db.SelectProductsByCategory(SelectedCategory.Selected).ToList();
                facade.ChangePage(productListPage);
                return;
            }

            int? tag = Int32.Parse(g.Tag.ToString());
            productListPage.ProductList = db.SelectProductsBySex(tag).ToList();
            facade.ChangePage(productListPage);
        }

        private void onSearchBoxKeyUp(object sender, KeyEventArgs e) {
            TextBox textBox = (TextBox) sender;
            string text = textBox.Text;
            if (text == string.Empty)
                productListPage.ProductList = db.SelectProductsByCategory(SelectedCategory.Selected);
        }
    }
}