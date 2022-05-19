using System.Windows.Media;

namespace Plechaty_GUI {
    static class ColorProvider {
        public static Color Skin => ReturnAsColor(242, 204, 195);
        public static Color Lipstick => ReturnAsColor(231, 143, 142);

        public static Color Light => ReturnAsColor(255, 230, 232);

        public static Color Green => ReturnAsColor(172, 216, 170);
        public static Color Pink => ReturnAsColor(244, 132, 152);
        public static Color Silver => ReturnAsColor(230, 230, 230);
        public static Color Grey => ReturnAsColor(240, 240, 240);
        public static Color TextLight => ReturnAsColor(188, 188, 188);
        public static Color TextNormal => ReturnAsColor(160, 160, 160);
        public static Color TextDark => ReturnAsColor(48, 48, 48);

        private static Color ReturnAsColor(byte r, byte g, byte b) {
            return new Color { R = r, G = g, B = b };
        }
        public static Color ReturnAsRGBColor(Color color) {
            return Color.FromRgb(color.R, color.G, color.B);
        }
    }
}