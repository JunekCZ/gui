using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using Dapper;
using Plechaty_GUI.Category;
using Plechaty_GUI.DBClasses;

namespace Plechaty_GUI {
    public class Database {
        private string connectionString = "Server=ftp.occamy.cz;Database=GUI;Uid=guiuser;Pwd=GuiPwd.;";
        private IDbConnection connection;

        public Database() {
            connection = GetConnection();
        }

        private IDbConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }

        internal int SelectAccountBalance(int id_u) {
            if (!IsConnected())
                connection.Open();

            return connection.QueryFirst<int>("SELECT balance FROM users WHERE id_u=@Id_u;", new {
                Id_u = id_u
            });
        }

        internal Users SelectUserByCreditials(string email, string password) {
            if (!IsConnected())
                connection.Open();

            return connection.QuerySingleOrDefault<Users>("SELECT * FROM users WHERE email=@Email AND password=@Password;", new {
                Email = email,
                Password = password
            });
        }

        private bool IsConnected() {
            return connection.State == ConnectionState.Open || connection.State == ConnectionState.Fetching || connection.State == ConnectionState.Executing;
        }

        /**
         * Vrací produkty z databáze
         * @param string sql        -> SQL příkaz pro výběr produktů z databáze
         * @param int[] parameters  -> Nepovinný parametr. Specifikuje podrobněji SQL
         * @return List<Products>
         */
        public List<DBClasses.Product> SelectProducts(string sql, object parameters = null) {
            if (!IsConnected())
                connection.Open();

            List<DBClasses.Product> productsList = connection.Query<DBClasses.Product>(sql, parameters).ToList();
            connection.Close();
            return productsList;
        }

        /**
         * Vrátí všechny produkty z databáze
         * @return List<Products>
         */
        public List<DBClasses.Product> SelectAllProducts() {
            if (!IsConnected())
                connection.Open();

            List<DBClasses.Product> productsList = connection.Query<DBClasses.Product>("SELECT * FROM products;").ToList();
            connection.Close();
            return productsList;
        }

        /**
         * Vrací kategorie z databáze
         * @param string sql        -> SQL příkaz pro výběr kategorie z databáze
         * @param int[] parameters  -> Nepovinný parametr. Specifikuje podrobněji SQL
         * @return List<Categories>
         */
        public List<DBClasses.Category> SelectCategories(string sql, int[] parameters = null) {
            if (!IsConnected())
                connection.Open();

            List<DBClasses.Category> categoriesList = connection.Query<DBClasses.Category>(sql, new {
                parameters
            }).ToList();
            connection.Close();
            return categoriesList;
        }

        /**
         * Vrátí všechny kategorie z databáze
         * @return List<Products>
         */
        public IEnumerable<DBClasses.Category> SelectAllCategories() {
            if (!IsConnected())
                connection.Open();

            IEnumerable<DBClasses.Category> categoriesList = connection.Query<DBClasses.Category>("SELECT c.id_c AS Id_c, c.name AS Name, c.image_url AS Image_url, COUNT(p.id_p) AS ItemsCount FROM categories AS c LEFT JOIN products AS p ON p.id_c=c.id_c GROUP BY c.id_c;");
            connection.Close();
            return categoriesList;
        }

        /**
         * Vrací počet produktů v databázi pro danou kategorii
         * @param int id_c  -> ID kategorie v databázi
         * @return int
         */
        public int SelectProductCount(int id_c) {
            if (!IsConnected())
                connection.Open();

            int productCount = connection.Query<int>("SELECT COUNT(id_p) AS count FROM products WHERE id_c=@Id_c;", new {
                Id_c = id_c
            }).Sum();
            connection.Close();
            return productCount;
        }

        public List<DBClasses.Product> SelectProductsByCategory(int id_c) {
            if (!IsConnected())
                connection.Open();

            if (id_c == 0)
                return SelectAllProducts();

            List<DBClasses.Product> productsList = connection.Query<DBClasses.Product>("SELECT * FROM products WHERE id_c=@Id_c", new 
                { Id_c = id_c }
            ).ToList();
            connection.Close();
            return productsList;
        }

        /**
         * Vrací objekt kategorie dle id produktu
         * @param int id_p -> Id produktu
         * @return Categories
         */
        public DBClasses.Category SelectCategoryByProductID(int id_p) {
            if (!IsConnected())
                connection.Open();

            DBClasses.Category category = connection.QueryFirst<DBClasses.Category>("SELECT c.name FROM products AS p JOIN categories AS c ON p.id_c=c.id_c WHERE p.id_p=@Id_p;", new {
                    Id_p = id_p
                }
            );
            connection.Close();
            return category;
        }

        /**
         * Vrací objekt produktu dle id produktu
         * @param int id_p -> Id produktu
         * @return Products
         */
        public DBClasses.Product SelectProductById(int id_p) {
            if (!IsConnected())
                connection.Open();

            DBClasses.Product product = connection.QuerySingleOrDefault<DBClasses.Product>("SELECT * FROM products WHERE id_p=@Id_p;", new {
                    Id_p = id_p
                }
            );
            connection.Close();
            return product;
        }

        /**
         * Vrací objekt produktu dle id produktu
         * @param int id_p -> Id produktu
         * @return Products
         */
        public IEnumerable<DBClasses.Product> SelectProductsBySex(int? sex) {
            return SelectProductsByCategory(SelectedCategory.Selected).Where(x => x.Sex == sex);
        }

        public bool InsertUser(string firstname, string lastname, string email, string password) {
            if (IsConnected())
                connection.Open();

            int command = connection.Execute(
                "INSERT INTO users (id_u, firstname, lastname, email, password, balance) VALUES (NULL, @Firstname, @Lastname, @Email, @Password, 0);",
                new {
                    Firstname = firstname,
                    Lastname = lastname,
                    Email = email,
                    Password = password
                });
            connection.Close();
            return command == 1;
        }

        public List<DBClasses.Product> SelectUsersProductsList(int id_u) {
            if(!IsConnected())
                connection.Open();

            List<DBClasses.Product> productList = connection.Query<DBClasses.Product>(
                "SELECT p.id_p AS id_p, p.id_c AS id_c, p.name AS name, p.description AS description, p.price AS price, p.special AS special, p.image_url AS image_url FROM products AS p JOIN users_products AS up ON up.id_p = p.id_p JOIN users AS u ON u.id_u=up.id_u WHERE u.id_u=@Id_u;", new {
                    Id_u=id_u
                }).ToList();
            connection.Close();
            return productList;
        }

        public bool BuyProducts(List<DBClasses.Product> productProfileList, int id_u) {
            if (!IsConnected())
                connection.Open();

            int balance = SelectAccountBalance(id_u);

            using (var transaction = connection.BeginTransaction()) {
                string sql = "INSERT INTO users_products (id_u, id_p) VALUES (@Id_u, @Id_p);";
                int? sum = 0;
                foreach (DBClasses.Product pp in productProfileList) {
                    for (int i = 0; i < pp.Count; i++) {
                        connection.Execute(sql, new {
                            Id_u = id_u,
                            Id_p = pp.Id_p
                        });
                        sum += pp.Special != null ? pp.Special : pp.Price;
                    }
                }

                if (balance < sum) {
                    transaction.Rollback();
                    return false;
                }
                connection.Execute("UPDATE users SET balance=balance-@Sum WHERE id_u=@Id_u;", new {
                    Sum = sum,
                    Id_u = id_u
                });

                transaction.Commit();
                productProfileList.Clear();
            }

            MessageBox.Show("Úspěšně nakoupeno!");
            connection.Close();
            return true;
        }

        public List<DBClasses.Product> RefreshProducts(List<DBClasses.Product> cartProductsList) {
            if (!IsConnected())
                connection.Open();

            List<DBClasses.Product> productList = new List<DBClasses.Product>();
            foreach(DBClasses.Product product in cartProductsList)
                productList.Add(connection.QuerySingleOrDefault<DBClasses.Product>("SELECT * FROM products WHERE id_p=@Id_p;", new {
                    Id_p = product.Id_p
                }));
            connection.Close();
            return productList;
        }

        public IEnumerable<DBClasses.Product> SelectProductsByName(string text) {
            if (!IsConnected())
                connection.Open();

            IEnumerable<DBClasses.Product> productList = connection.Query<DBClasses.Product>("SELECT * FROM products WHERE name LIKE @Text OR description LIKE @Text;", new {
                Text = "%" + text + "%"
            }).ToList();
            connection.Close();
            return productList;
        }
    }
}