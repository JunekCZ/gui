using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Plechaty_GUI.Category;
using Plechaty_GUI.Interfaces;

namespace Plechaty_GUI.Pages {
    /// <summary>
    /// Interakční logika pro CategoryListPage.xaml
    /// </summary>
    public partial class CategoryListPage : Page, IContentBuilder {
        private List<DBClasses.Category> categoriesList = new List<DBClasses.Category>();
        private Facade facade;
        public Action<int> AddProductsAction;
        public CategoryListPage(Facade facade, Grid newestGrid) {
            this.facade = facade;
            InitializeComponent();
            newestGrid.MouseDown += onNewestCategoryMouseDown;
            newestGrid.MouseEnter += onNewestCategoryMouseEnter;
            newestGrid.MouseLeave += onNewestCategoryMouseLeave;
            newestGrid.Cursor = Cursors.Hand;
            SelectedCategory.Selected = 0;
            Build();
            Recolor();
        }

        private void onNewestCategoryMouseDown(object sender, MouseButtonEventArgs e) {
            SelectedCategory.Selected = 0;
            AddProductsAction?.Invoke(0);
            Recolor();
        }

        private void onNewestCategoryMouseEnter(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border)g.Children[0];
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
        }

        private void onNewestCategoryMouseLeave(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border)g.Children[0];
            b.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Green));
        }

        public void Build() {
            categoryList.ItemsSource = facade.GetCategories();
        }
        private void onCategoryMouseEnter(object sender, MouseEventArgs e) {
            Grid g = (Grid) sender;
            Border b = (Border) g.Children[0];
            DBClasses.Category cat = (DBClasses.Category)b.Tag;
            cat.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
            cat.ForegroundName = Brushes.White;
            cat.ForegroundItems = Brushes.AliceBlue;
            g.Cursor = Cursors.Hand;
        }
        private void onCategoryMouseLeave(object sender, MouseEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border) g.Children[0];
            DBClasses.Category cat = (DBClasses.Category) b.Tag;
            if (!SelectedCategory.IsSelected(cat.Id_c)) {
                cat.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Grey));
                cat.ForegroundName = Brushes.Black;
                cat.ForegroundItems = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
            }
        }
        private void onCategoryMouseDown(object sender, MouseButtonEventArgs e) {
            Grid g = (Grid)sender;
            Border b = (Border)g.Children[0];
            DBClasses.Category cat = (DBClasses.Category) b.Tag;
            AddProductsAction?.Invoke(cat.Id_c);

            SelectedCategory.Selected = cat.Id_c;
            if (!categoriesList.Contains(cat))
                categoriesList.Add(cat);
            Recolor();
        }

        public void Recolor() {
            foreach (DBClasses.Category cat in categoriesList) {
                if (!SelectedCategory.IsSelected(cat.Id_c)) {
                    cat.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Grey));
                    cat.ForegroundName = Brushes.Black;
                    cat.ForegroundItems = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.TextLight));
                } else {
                    cat.Background = new SolidColorBrush(ColorProvider.ReturnAsRGBColor(ColorProvider.Lipstick));
                    cat.ForegroundName = Brushes.White;
                    cat.ForegroundItems = Brushes.AliceBlue;
                }
            }
        }
    }
}