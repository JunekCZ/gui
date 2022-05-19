using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Plechaty_GUI.Commands {
    class Animation {
        private bool isAnimating = false;

        /**
         * @param Label l       -> Label, na kterem se ma zmenit barva
         * @param byte[] from   -> pocatecni barva
         * @param byte[] to     -> koncova barva
         * @param bool reverse  -> z vyssi barvy do nizsi?
         */
        public async void AnimateText(Label l, byte[] from, byte[] to, bool reverse) {
            int steps = Math.Abs(from[0] - to[0]);
            if (Math.Abs(from[1] - to[1]) > steps)
                steps = Math.Abs(from[1] - to[1]);

            if (Math.Abs(from[2] - to[2]) > steps)
                steps = Math.Abs(from[2] - to[2]);
            byte r = from[0];
            byte g = from[1];
            byte b = from[2];

            for (int i = 0; i < steps / 10; i++) {
                if (!reverse) {
                    if (r < to[0])
                        r += 10;
                    if (g < to[1])
                        g += 10;
                    if (b < to[2])
                        b += 10;
                } else {
                    // Musim ve vsech podminkach odecitat stejne cislo, jelikoz pri odecteni do minusu se byte nastavi na kladnou vysokou hodnotu
                    if (r - 10 > to[0])
                        r -= 10;
                    if (g - 10 > to[1])
                        g -= 10;
                    if (b - 10 > to[2])
                        b -= 10;
                }
                if (r != 0 && g != 0 && b != 0 || to[0] == 0 && to[1] == 0 && to[2] == 0)
                    l.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));

                await Task.Delay(TimeSpan.FromMilliseconds(1));
            }
            l.Foreground = new SolidColorBrush(Color.FromRgb(to[0], to[1], to[2]));
        }

        /**
         * @param Border b          -> Border, na kterem se zmeni bordery
         * @param int milliseconds  -> Milisekundy do zmeny
         * @param int from          -> pocatecni hodnota
         * @param int to            -> koncova hodnota
         * @param bool reverse      -> Zmensit, ci zvetsit zaobleni? true -> zmensit, false -> zvetsit
         */
        public async void AnimateBorder(Border b, int miliseconds, int from, int to, bool reverse) {
            int steps = Math.Abs(to - from);
            for (int i = 0; i < steps; i++) {
                Border visualBorder = new Border();
                if (!reverse)
                    visualBorder.CornerRadius = new CornerRadius(from + i);
                else
                    visualBorder.CornerRadius = new CornerRadius(from - i);
                visualBorder.Width = b.Width;
                visualBorder.Height = b.Height;
                visualBorder.Background = b.Background;

                VisualBrush vb = new VisualBrush();
                vb.Visual = visualBorder;

                b.OpacityMask = vb;
                await Task.Delay(TimeSpan.FromMilliseconds(miliseconds / steps));
            }
        }
    }
}