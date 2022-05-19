using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Controls;
using Plechaty_GUI.Account;
using Plechaty_GUI.DBClasses;
using Plechaty_GUI.Interfaces;
using Plechaty_GUI.Views;

namespace Plechaty_GUI {
    public class Facade {
        private Cart.Cart cart;
        private Database db;
        private AccountManager accountManager;
        private Frame productFrame;

        public Facade(Database db, Cart.Cart cart, Frame productFrame) {
            this.cart = cart;
            this.db = db;
            this.productFrame = productFrame;
        }

        internal int GetAccountBalance() {
            return this.db.SelectAccountBalance(accountManager.user.Id_u);
        }

        public int SelectProductCount(int Id_c) {
            return db.SelectProductCount(Id_c);
        }

        internal DBClasses.Product GetCurrentProduct(int id_p) {
            return db.SelectProductById(id_p);
        }

        internal DBClasses.Category GetCategoryByProductId(int id_p) {
            return db.SelectCategoryByProductID(id_p);
        }

        internal void AddToCart(DBClasses.Product currentProduct) {
            cart.AddToCart(currentProduct);
        }

        internal List<DBClasses.Product> GetProductList() {
            List<DBClasses.Product> productList = db.RefreshProducts(cart.productsList);
            return productList;
        }

        internal IEnumerable GetCategories() {
            return db.SelectAllCategories();
        }

        internal void ClearProductList() {
            cart.productsList.Clear();
            cart.RefreshCount();
        }

        internal int GetUserID() {
            return accountManager.user.Id_u;
        }

        internal void RemoveFromList(int id_p) {
            cart.RemoveFromCart(id_p);
        }

        internal void RemoveAllFromList(int id_p) {
            cart.productsList = cart.productsList.Where(x => x.Id_p != id_p).ToList();
            cart.RefreshCount();
        }

        internal bool LogUserIn(string email, string password) {
            Users user = db.SelectUserByCreditials(email, CreateSHAHash(password));
            if (user == null)
                return false;

            accountManager = new AccountManager(this);
            accountManager.user = user;

            /*string md5email = CreateMD5Hash(email);
            Console.WriteLine(md5email);
            using (WebClient wc = new WebClient()) {
                string json = wc.DownloadString("https://cs.gravatar.com/" + md5email + ".json");
                JObject jo = JObject.Parse(json);
                Console.WriteLine(json);
            }*/
            return true;
        }

        private string CreateSHAHash(string password) {
            SHA512Managed sha512 = new SHA512Managed();
            Byte[] EncryptedSHA512 = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
            sha512.Clear();
            return Convert.ToBase64String(EncryptedSHA512);
        }

        private string CreateMD5Hash(string email) {
            var hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(email ?? ""));
            return string.Join("", Enumerable.Range(0, hash.Length).Select(i => hash[i].ToString("x2")));
        }

        internal void onAccountBorderMouseDown() {
            if (accountManager != null && accountManager.IsLogged()) {
                UserProfile up = new UserProfile(this);
                up.ShowDialog();
            } else {
                UserLogin ul = new UserLogin(this);
                ul.ShowDialog();
            }
        }

        public bool Register(string firstname, string lastname, string email, string password) {
            return db.InsertUser(firstname, lastname, email, CreateSHAHash(password));
        }

        public string GetAccountFullName() {
            return accountManager.GetFullName();
        }

        public List<DBClasses.Product> GetUsersProductsList(int id_u) {
            return db.SelectUsersProductsList(id_u);
        }

        public bool BuyProducts(List<DBClasses.Product> p) {
            return db.BuyProducts(p, GetUserID());
        }

        public bool AccountIsLogged() {
            return accountManager != null && accountManager.IsLogged();
        }

        public IEnumerable<DBClasses.Product> GetProductsByName(string text) {
            return db.SelectProductsByName(text);
        }

        public List<DBClasses.Product> GetProdusByCategory(int tag) {
            return db.SelectProductsByCategory(tag);
        }

        public void LogUserOut() {
            accountManager.user.Id_u = 0;
        }

        public void ChangePage(IContentBuilder frame) {
            productFrame.Navigate(frame);
        }
    }
}