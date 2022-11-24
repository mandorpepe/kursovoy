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
    public partial class userAdding : Form
    {
        public userAdding()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void button1_Click(object sender, EventArgs e)
        {
            string dolj  = comboBox1.Text;

        }

        private void userAdding_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getConnection();
            db.openConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select fio from clients";
            MySqlDataReader DR = command.ExecuteReader();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
        }
    }
}
