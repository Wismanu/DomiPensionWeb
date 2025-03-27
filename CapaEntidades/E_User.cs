using System;


namespace CapaEntidades
{
    public class E_User
    {
        public int Usr_Code { get; set; }
        public int Usr_Idrol { get; set; } // Llave foránea a Rol
        public string Usr_Name { get; set; }
        public string Usr_Dni { get; set; }
        public string Usr_Phone { get; set; }
    }
}
