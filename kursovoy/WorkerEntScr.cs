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
using MySql.Data.MySqlClient;

namespace kursovoy
{
    public partial class WorkerEntScr : Form
    {
        public MySqlCommand command = new MySqlCommand();
        String seltab;
        public string sos;
        DataTable dtRecord = new DataTable();

        MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter();
        MySqlCommandBuilder builder = new MySqlCommandBuilder();

        Авторизация ent = new Авторизация();
        DB db = new DB();
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

        }

        private void WorkerEntScr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from clients";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            //Заполнение грида
            dtRecord.Columns.Clear();
            dtRecord.Rows.Clear();
            dtRecord.Clear();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            seltab = "Клиенты";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from hotel";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            //Заполнение грида
            dtRecord.Columns.Clear();
            dtRecord.Rows.Clear();
            dtRecord.Clear();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            seltab = "Отель";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            int need = (int)dataGridView1.Rows[rowindex].Cells[0].Value;

            command.Parameters.Clear();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = need;
            try
            {
                switch (seltab)
                {
                    case "Клиенты":
                        command.CommandText = "delete from clients where id_clients = @id";
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        MessageBox.Show("Удалено успешно");
                        break;
                    case "Отель":
                        command.CommandText = "delete from hotel where id_hotel = @id";
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        MessageBox.Show("Удалено успешно");
                        break;
                    case "Путёвка":
                        command.CommandText = "delete from trip where id_book = @id";
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        MessageBox.Show("Удалено успешно");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, выберите поле id и повторите снова");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            db.openConnection();
            var conn = db.getConnection();
            sqlDataAdap.SelectCommand = command;
            sqlDataAdap.SelectCommand.Connection = conn;
            builder.Dispose();
            builder.DataAdapter = sqlDataAdap;
            builder.GetUpdateCommand();
            sqlDataAdap.Update(dtRecord);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from trip";
            sqlDataAdap.SelectCommand = command;

            dtRecord.Columns.Clear();
            dtRecord.Rows.Clear();
            dtRecord.Clear();

            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            seltab = "Путёвка";
        }
    }
}
