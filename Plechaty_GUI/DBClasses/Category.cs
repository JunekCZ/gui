using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Plechaty_GUI.Annotations;

namespace Plechaty_GUI.DBClasses {
    public class Category : INotifyPropertyChanged {
        public Category() {
            Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Grey));
            ForegroundName = Brushes.Black;
            ForegroundItems = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
        }
        public int Id_c { get; set; }
        public string Name { get; set; }
        public string Image_url { get; set; }
        public int ItemsCount { get; set; }
        public string ItemsCountString => "Počet produktů: " + ItemsCount;
        public Category GetCategory => this;
        public Brush Background {
            get => background;
            set {
                background = value;
                OnPropertyChanged();
            }
        }
        private Brush background { get; set; }
        public Brush ForegroundName {
            get => foregroundName;
            set {
                foregroundName = value;
                OnPropertyChanged();
            }
        }
        private Brush foregroundName { get; set; }
        public Brush ForegroundItems {
            get => foregroundItems;
            set {
                foregroundItems = value;
                OnPropertyChanged();
            }
        }
        private Brush foregroundItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}