using MySqlX.XDevAPI.Relational;
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
    public partial class WorkerEntScr : Form
    {
        //public string userEntId;
        Авторизация ent = new Авторизация();
        
        public WorkerEntScr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserEnt.Value = "Worker";
            createOrd ord = new createOrd();
            ord.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserEnt.Value = "Worker"; 
            addClient client= new addClient();
            client.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Авторизация login = new Авторизация();
            login.Show();
            Hide(); 
        }

        private void WorkerEntScr_Load(object sender, EventArgs e)
        {
            //MySqlCommand commandId = new MySqlCommand("SELECT id_worker from worker", db.getConnection());
            //adapter.SelectCommand = command;
            //adapter.Fill(table);
            //userEntId = table.Rows[0][0].ToString();
            Авторизация ent = new Авторизация();
            
            label1.Text = UserEntId.Value.ToString();
        }

        private void WorkerEntScr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
