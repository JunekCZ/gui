using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plechaty_GUI.DBClasses {
    public class Users {
        public int Id_u { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string email { get; set; }
        public int balance { get; set; }
    }
}