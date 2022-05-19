namespace Plechaty_GUI.Category {
    static class SelectedCategory {
        public static int Selected { get; set; }

        public static bool IsSelected(int id_c) {
            return id_c == Selected;
        }
    }
}