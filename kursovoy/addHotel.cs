using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovoy
{
    public partial class addHotel : Form
    {
        public addHotel()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            String hname = textBox1.Text;
            String country = textBox2.Text;
            String city = textBox3.Text;
            String address = textBox4.Text;
            String stars = textBox5.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                MySqlCommand command = new MySqlCommand("insert into hotel values (null,@hName,@country,@city,@address,@stars)", db.getConnection());
                command.Parameters.Add("@hName", MySqlDbType.VarChar).Value = hname;
                command.Parameters.Add("@country", MySqlDbType.VarChar).Value = country;
                command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@stars", MySqlDbType.Int32).Value = stars;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Отель создан");
            }catch{ MessageBox.Show("Проверьте введены ли все данные и повторите попытку снова"); }
        }

        private void addHotel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

