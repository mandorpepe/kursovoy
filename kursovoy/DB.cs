using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace kursovoy
{
class DB
    {
        //MySqlConnection connection = new MySqlConnection("server=web.edu;port=3306;username=19056;password=jynixo;database=19056_kursovoy");
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=19056_kursovoy");
    
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
        public string getHotelId(string selind)
        {
            MySqlCommand command = new MySqlCommand();
            DataTable dtRecord = new DataTable();
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            string hId = "";
            command.Connection = getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from hotel where `hotel_name` = @name";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selind;
            
         
            sqlDataAdap.SelectCommand = command;
            sqlDataAdap.Fill(dtRecord);
            hId = dtRecord.Rows[0][0].ToString();
            return hId;
        }
        public string getClientId(string selind)
        {
            MySqlCommand command = new MySqlCommand();
            DataTable dtRecord = new DataTable();
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            string hId = "";
            command.Connection = getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from clients where `fio` = @name";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selind;


            sqlDataAdap.SelectCommand = command;
            sqlDataAdap.Fill(dtRecord);
            hId = dtRecord.Rows[0][0].ToString();
            return hId;
        }
        public string getPosId(string selind)
        {
            MySqlCommand command = new MySqlCommand();
            DataTable dtRecord = new DataTable();
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            string hId = "";
            command.Connection = getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from position where `position_name` = @name";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = selind;


            sqlDataAdap.SelectCommand = command;
            sqlDataAdap.Fill(dtRecord);
            hId = dtRecord.Rows[0][0].ToString();
            return hId;
        }
    }
}
