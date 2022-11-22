using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovoy
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = regloginText.Text;
            String passUser = passwordText.Text;
            String fioUser = fioText.Text;
            String ageUser = ageText.Text;
            String phoneUser = phoneText.Text;
            String passportUser = passportText.Text;
            int posUser = comboBox1.SelectedIndex + 1;
            
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("insert into worker values (null,@l,@p,@fio,@age,@phone,@passport,@pos)", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@age", MySqlDbType.Int16).Value = ageUser;
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = passportUser;
            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fioUser;
            command.Parameters.Add("@phone", MySqlDbType.Int32).Value = phoneUser;
            command.Parameters.Add("@pos", MySqlDbType.Int32).Value = posUser;

            try { 
            adapter.SelectCommand = command;
            adapter.Fill(table);
                MessageBox.Show("Пользователь  зарегестрирован");
            }
            catch
            {
                MessageBox.Show("Такой логин уже существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminScreen adm = new adminScreen();
            adm.Show();
            Hide();
        }
    }
}
