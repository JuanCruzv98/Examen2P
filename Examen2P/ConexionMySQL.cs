using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen2P
{
    public class ConexionMySQL
    {
        string Server = "localhost";
        string Port = "3306";
        string Database = "farmacia";
        string User = "root";
        string Password = "Myroot";
        public MySqlConnection conn;
       public ConexionMySQL()
        {
          conn = new MySqlConnection($"Server={Server};Port={Port};Database={Database};User={User};Password={Password}");
        }

        public void OpenConnection()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                conn.Dispose();
            }
        }

        public void CloseConnection() {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
