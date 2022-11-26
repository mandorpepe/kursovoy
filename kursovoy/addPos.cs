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
    public partial class addPos : Form
    {
        public addPos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminScreen adm = new adminScreen();
            adm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String posUser = posText.Text;
            String payUser = payText.Text;
            String requirUser = requirText.Text;
            String dutyUser = dutyText.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("insert into position values (null,@posname,@pay,@duty,@requir)", db.getConnection());
            command.Parameters.Add("@posname", MySqlDbType.VarChar).Value = posUser;
            command.Parameters.Add("@duty", MySqlDbType.VarChar).Value = dutyUser;
            command.Parameters.Add("@pay", MySqlDbType.Float).Value = payUser;
            command.Parameters.Add("@requir", MySqlDbType.VarChar).Value = requirUser;


            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Должность создана");

        }
    }
}
