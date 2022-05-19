using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Plechaty_GUI.DBClasses;

namespace Plechaty_GUI.Account {
    public class AccountManager {
        private Facade facade;
        public Users user;
        public string gravatar = null;
        public AccountManager(Facade facade) {
            this.facade = facade;
        }

        public int GetAccountBalance() {
            return IsLogged() ? facade.GetAccountBalance() : -1;
        }

        public bool IsLogged() {
            return user.Id_u > 0;
        }

        internal string GetFullName() {
            return user.Firstname + " " + user.Lastname;
        }
    }
}
