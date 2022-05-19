using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Plechaty_GUI.Cart {
    public class Cart {
        private Border productsCountBorder;
        public List<DBClasses.Product> productsList = new List<DBClasses.Product>();
        public Cart(Border productsCountBorder) {
            this.productsCountBorder = productsCountBorder;
            productsCountBorder.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        public void AddToCart(DBClasses.Product product) {
            productsList.Add(product);
            Panel.SetZIndex(productsCountBorder, 0);
            RefreshCount();
        }

        public void RemoveFromCart(int id_p) {
            if (productsList.Count < 1)
                return;

            foreach (DBClasses.Product p in productsList) {
                if (p.Id_p == id_p) {
                    productsList.Remove(p);
                    RefreshCount();
                    return;
                }
            }
        }

        public void RefreshCount() {
            Label productsCountLabel = (Label) productsCountBorder.Child;
            productsCountLabel.Content = productsList.Count;
            Panel.SetZIndex(productsCountBorder, productsList.Count < 1 ? -1 : 0);
        }
    }
}