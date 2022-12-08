using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovoy
{
    public partial class createOrd : Form
    {
        public string hotelname;
        public string clientname;


        public createOrd()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void button1_Click(object sender, EventArgs e)
        {
            var dtpDate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            var dtpDate2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            String pay = textBox1.Text;
            
            int hotel = Convert.ToInt32(db.getHotelId(hotelname));
            int client = Convert.ToInt32(db.getClientId(clientname));

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `trip` (`id_book`, `date_start`, `date_end`, `payment`, `id_hotel`, `id_worker`, `id_clients`)values (null,@dstart,@dend,@pay,@hotel,@worker,@client)", db.getConnection());

                command.Parameters.Add("@pay", MySqlDbType.Float).Value = pay;
                command.Parameters.Add("@worker", MySqlDbType.Int32).Value = UserEntId.Value;
                command.Parameters.Add("@client", MySqlDbType.VarChar).Value = client;
                command.Parameters.Add("@hotel", MySqlDbType.Int32).Value = hotel;
                command.Parameters.Add("@dstart", MySqlDbType.Date).Value = dtpDate;
                command.Parameters.Add("@dend", MySqlDbType.Date).Value = dtpDate;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Путёвка успешно создана");
            }
            catch { MessageBox.Show("Проверьте введены ли все данные и повторите попытку снова"); }
                
            
        }

        private void createOrd_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getConnection();
            db.openConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select FIO from clients";
            MySqlDataReader DR = command.ExecuteReader();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
            db.closeConnection();
            db.openConnection();
            command.CommandText = "Select fio from worker";
            DR = command.ExecuteReader();
            //while (DR.Read())
            //{
            //    comboBox2.Items.Add(DR[0]);

            //}
            db.closeConnection();
            db.openConnection();
            command.CommandText = "Select hotel_name from hotel";
            DR = command.ExecuteReader();
            while (DR.Read())
            {
                comboBox3.Items.Add(DR[0]);

            }
            db.closeConnection();
            //Подключение к бд и создангие команды
            command.CommandText = "Select * from hotel";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            //Заполнение грида
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelname = comboBox3.SelectedItem.ToString();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientname = comboBox1.SelectedItem.ToString();
            
        }

        private void createOrd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
