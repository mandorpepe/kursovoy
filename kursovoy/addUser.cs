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

        adminScreen adminScreen = new adminScreen();
        public addUser()
        {
            InitializeComponent();
        }
        DB db = new DB();
        public string posnam;

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = regloginText.Text;
            String passUser = passwordText.Text;
            String fioUser = fioText.Text;
            String ageUser = ageText.Text;
            String phoneUser = phoneText.Text;
            String passportUser = passportText.Text;
            int posUser = Convert.ToInt32(db.getPosId(posnam));



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

                adminScreen.Show();
                Hide();

        }

        private void addUser_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getConnection();
            db.openConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select position_name from position";
            MySqlDataReader DR = command.ExecuteReader();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
            db.closeConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            posnam = comboBox1.SelectedItem.ToString();
        }

        private void addUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
