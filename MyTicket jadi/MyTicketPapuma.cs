using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTicket_jadi
{
    public partial class MyTicketPapuma : Form
    {
        public MyTicketPapuma()
        {
            InitializeComponent();
        }

        private void MyTicketPapuma_Load(object sender, EventArgs e)
        {

        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketForm = new MyTicketMain();
            myTicketForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketForm = new MyTicketMain();
            myTicketForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void customRoundedButton1_Click_1(object sender, EventArgs e)
        {
            MyTicketMain myTicketMain = new MyTicketMain();
            myTicketMain.Show();
            this.Close();
        }
    }
}
