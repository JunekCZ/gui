using System;
using System.Windows.Media;

namespace Plechaty_GUI.DBClasses {
    public class Product {
        public int Id_p { get; set; }
        public int Id_c { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionShort => Description != null && Description.Length > 300 ? Description.Substring(0, 300) + "..." : Description;
        public string PriceString => Price + " kč";
        public string SpecialString => Special == null ? null : Special + " kč";
        public int Sex { get; set; }
        public string Image_url { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int? Special { get; set; }
        public String Category { get; set; }
        public int ZIndex => Count > 1 ? 1 : -1;
        public System.Windows.Visibility Visibility => Special == null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
        public System.Windows.Visibility VisibilityNegated => Special != null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
        public Brush Lipstick {
            get => new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        public Brush Pink {
            get => new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Pink));
        }

        public Brush Skin {
            get => new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Skin));
        }

        public Brush TextLight {
            get => new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
        }
    }
}
