using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca.Model
{
    public class Connection
    {
        string connectChain
        {
            get;
            set;
        }

        public MySqlConnection dbConnection
        {
            get
            {
                return dbConnection;
            }
        }

        private string InitializeChain()
        {
            string server = "localhost";
            string db = "libros";
            string user = "root";
            string password = "1234";

            string connectionString = "Database=" + db + "; Server=" + server + "; User Id=" + user + "; Password=" + password;
            
            return connectionString;
        }

        public MySqlConnection CreateConnection()
        {
            string connectString = InitializeChain();

            MySqlConnection dbConnection = new MySqlConnection(connectString);

            try
            {
                //dbConnection.Open();
                //MessageBox.Show("Conexión realizada.");
            } catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido conectar con la base de datos. Error: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }

            return dbConnection;

        }

    }
}
