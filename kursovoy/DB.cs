using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace kursovoy
{
class DB
    {
        MySqlConnection connection = new MySqlConnection("server=web.edu;port=3306;username=19056;password=jynixo;database=19056_kursovoy");
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=19056_kursovoy");
    
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
