using System.Configuration;
using System.Data.SqlClient;


namespace CapaAccesoDatos
{
    public class Conexion
    {
        private string connectionString;

        public Conexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BancoPruebaWPOSSConnectionString"].ConnectionString; // Asegúrate de que el nombre de la cadena de conexión sea correcto
        }

        public SqlConnection GetConnection() // Cambiar NpgsqlConnection a SqlConnection
        {
            return new SqlConnection(connectionString); // Usar SqlConnection
        }
    }
}
