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
        public WorkerEntScr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
    }
}
