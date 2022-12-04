using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using DataTable = System.Data.DataTable;

namespace kursovoy
{
    public partial class adminScreen : Form
    {
        public MySqlCommand command = new MySqlCommand();
        DataTable dtRecord = new DataTable();
        MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter();
        MySqlCommandBuilder builder = new MySqlCommandBuilder();

        String seltab;
        public string sos;

        DB db = new DB();

        public adminScreen()
        {
            InitializeComponent();
        }

        private void adminScreen_Load(object sender, EventArgs e)
        {
            Авторизация ent = new Авторизация();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Отрктыь эксель
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sos = "Адм";

            addUser adduser = new addUser();
            createOrd ord = new createOrd();
            addPos pos = new addPos();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;

            switch (seltab)
            {
                case "Клиенты":
                    addClient addClient= new addClient();
                    addClient.Show();
                    break;
                case "Отель":
                    addHotel hotel = new addHotel();
                    hotel.Show();
                    break;
                case "Должность":
                    
                    pos.Show();
                    break;
                case "Путёвка":
                    ord.Show();
                    break;
                case "Работник":
                    adduser.Show();
                    break;       
            }
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Авторизация auth = new Авторизация();
            auth.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from clients";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            
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
            
            dtRecord.Columns.Clear();
            dtRecord.Rows.Clear();
            dtRecord.Clear();

            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            seltab = "Отель";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from position";
            sqlDataAdap.SelectCommand = command;

            dtRecord.Rows.Clear();
            dtRecord.Columns.Clear();
            dtRecord.Clear();

            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

            seltab = "Должность";
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from worker";
            sqlDataAdap.SelectCommand = command;

            dtRecord.Columns.Clear();
            dtRecord.Rows.Clear();
            dtRecord.Clear();

            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
            seltab = "Работник";
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
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
                    case "Должность":
                        command.CommandText = "delete from position where id_position = @id";
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
                    case "Работник":
                        command.CommandText = "delete from worker where id_worker = @id";
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        MessageBox.Show("Удалено успешно");
                        break;
                }
            }
            catch  {MessageBox.Show("Что-то пошло не так, выберите поле id и повторите снова"); 
            }
        }

        private void adminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
