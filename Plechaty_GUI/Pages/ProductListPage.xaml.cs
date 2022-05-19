using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Plechaty_GUI.Category;
using Plechaty_GUI.Commands;
using Plechaty_GUI.Interfaces;

namespace Plechaty_GUI.Pages {
    /// <summary>
    /// Interakční logika pro ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : IContentBuilder {
        private Facade facade;
        private Animation animation;
        private List<DBClasses.Product> productList;

        public List<DBClasses.Product> ProductList {
            get => productList;
            set {
                productList = value;
                ChangeProperty();
            }
        }

        public ProductListPage(Facade facade) {
            this.facade = facade;
            animation = new Animation();
            InitializeComponent();
            Build();
        }
        private void ChangeProperty() {
            itemsControl.ItemsSource = productList;
        }

        public void Build() {
            productList = facade.GetProdusByCategory(SelectedCategory.Selected);
            itemsControl.ItemsSource = productList;
        }

        private void onProductMouseDown(object sender, MouseButtonEventArgs e) {
            Grid g = (Grid)sender;
            int id_p = Int32.Parse(g.Tag.ToString());
            ProductDetailPage pd = new ProductDetailPage(facade, id_p);
            facade.ChangePage(pd);
        }

        private void onProductMouseEnter(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border)g.Children[0];
            Label l = (Label)g.Children[1];
            byte[] from = { 0, 0, 0 };
            byte[] to = { ColorProvider.Lipstick.R, ColorProvider.Lipstick.G, ColorProvider.Lipstick.B };
            animation.AnimateText(l, from, to, false);
            animation.AnimateBorder(b, 250, 16, 32, false);
        }

        private void onProductMouseLeave(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border)g.Children[0];
            Label l = (Label)g.Children[1];
            byte[] from = { ColorProvider.Lipstick.R, ColorProvider.Lipstick.G, ColorProvider.Lipstick.B };
            byte[] to = { 0, 0, 0 };
            animation.AnimateText(l, from, to, true);
            animation.AnimateBorder(b, 250, 32, 16, true);
        }
    }
}