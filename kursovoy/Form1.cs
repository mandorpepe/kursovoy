using Microsoft.OData.Edm.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoy
{
    public partial class Авторизация : Form
    {
        public string ads;
        public string userEnt;
        public Авторизация()
        {
            InitializeComponent();

            
        }


        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String loginUser = loginText.Text;
            String passUser = passText.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `login` = @uL and `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                UserEntId.Value = (int)table.Rows[0][0];

                if (loginUser == "admin")
                {
                    UserEnt.Value = "adm";
                    adminScreen adm = new adminScreen();
                    adm.Show();
                    Hide();

                }
                else
                {
                    UserEnt.Value = "Worker";
                    WorkerEntScr worker = new WorkerEntScr();
                    worker.Show();
                    Hide();
                    
                }
            }
            else {
                MessageBox.Show("Неверно введены логин или пароль, попробуйте снова");
            }
        }
    }
}
