using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class D_Login
    {
        private Conexion connectionString = new Conexion();

        public bool D_VerifyLogin(E_Login usuario, ref Exception ex)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;

            try
            {
                sqlConnection = connectionString.GetConnection();
                string query = "select COUNT(1) from [Login] WHERE Log_Name = @LogName AND Log_Password = @LogPass";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@LogName", usuario.Log_Name);
                sqlCommand.Parameters.AddWithValue("@LogPass", usuario.Log_Password);

                sqlConnection.Open();
                int result = Convert.ToInt32(sqlCommand.ExecuteScalar());

                return result > 0;
            }
            catch (Exception e)
            {
                ex = e;
                return false;
            }
            finally
            {
                if (sqlDataReader != null && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
