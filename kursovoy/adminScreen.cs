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
using MySql.Data.MySqlClient;


namespace kursovoy
{
    public partial class adminScreen : Form
    {
        //Подключение файла с подключением к бд
        DB db = new DB();
        public adminScreen()
        {
            InitializeComponent();
        }

        private void adminScreen_Load(object sender, EventArgs e)
        {
            //Подключение к бд и создангие команды
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from worker";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command);
            //Заполнение грида
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
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
            addUser adduser = new addUser();
            adduser.Show();
            Hide();
        }
    }
}
