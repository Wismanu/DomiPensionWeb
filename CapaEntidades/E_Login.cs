using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Login
    {
        public int Log_Code { get; set; }
        public string Log_Name { get; set; }
        public string Log_Password { get; set; }
        public int Usr_Code { get; set; } // Llave foránea a User
    }
}
