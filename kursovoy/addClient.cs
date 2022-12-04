using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace kursovoy
{
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dtpDate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"); //Formatted Date for MySql
                String fioUser = fioText.Text;
                String addressUser = addressText.Text;
                String phoneUser = phoneText.Text;
                String passportUser = passportText.Text;

                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("insert into clients values (null,@fio,@birthday,@address,@phone,@passport)", db.getConnection());
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = addressUser;
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = passportUser;
                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fioUser;
                command.Parameters.Add("@phone", MySqlDbType.Int32).Value = phoneUser;
                command.Parameters.Add("@birthday", MySqlDbType.Date).Value = dtpDate;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Пользователь  зарегестрирован");
            }
            catch { MessageBox.Show("Проверьте введены ли все данные и повторите попытку снова");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Авторизация ent = new Авторизация();
            if (UserEnt.Value == "Worker")
            {
                WorkerEntScr worker = new WorkerEntScr();
                worker.Show();
                Hide();
            }
            else 
            { 
                adminScreen adm = new adminScreen();
                adm.Show();
                Hide();
            }
        }

        private void addClient_Load(object sender, EventArgs e)
        {

        }

        private void addClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
