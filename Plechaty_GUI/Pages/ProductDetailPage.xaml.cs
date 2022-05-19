using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Plechaty_GUI.Interfaces;

namespace Plechaty_GUI.Pages {
    /// <summary>
    /// Interakční logika pro ProductDetailPage.xaml
    /// </summary>
    public partial class ProductDetailPage : IContentBuilder {
        private Facade facade;
        private int id_p;
        public ProductDetailPage(Facade facade, int id_p) {
            this.facade = facade;
            this.id_p = id_p;
            InitializeComponent();
            Build();
        }

        public void Build() {
            DBClasses.Product product = facade.GetCurrentProduct(id_p);
            DBClasses.Product p = new DBClasses.Product {
                Name = product.Name,
                Category = facade.GetCategoryByProductId(id_p).Name,
                Price = product.Price,
                Special = product.Special,
                Description = product.Description,
                Image_url = product.Image_url
            };
            DataContext = p;
        }

        private void onBuyButtonMouseEnter(object sender, MouseEventArgs e) {
            Button b = (Button) sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        private void onBuyButtonMouseLeave(object sender, MouseEventArgs e) {
            Button b = (Button) sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onBuyButtonClick(object sender, RoutedEventArgs e) {
            Button b = (Button) sender;
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextDark));
            facade.AddToCart(facade.GetCurrentProduct(id_p));
        }
    }
}