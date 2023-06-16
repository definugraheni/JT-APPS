using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MyTicket_jadi
{
    public partial class MyTicketRembangan : Form
    {
        public MyTicketRembangan()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketForm = new MyTicketMain();
            myTicketForm.Show();
            this.Close();
        }

        private void labelMyTicket_Click(object sender, EventArgs e)
        {
        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketForm = new MyTicketMain();
            myTicketForm.Show();
            this.Hide();
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketMain = new MyTicketMain();
            myTicketMain.Show();
            this.Hide();
        }

        private void MyTicketRembangan_Load(object sender, EventArgs e)
        {
            string conectionString = "Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001";
            NpgsqlConnection connection = new NpgsqlConnection(conectionString);

            string Rembangan = "SELECT * FROM wisata WHERE id_wisata ='A01'";
            //string  = "";

            NpgsqlCommand cmd = new NpgsqlCommand(Rembangan, connection);

            connection.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    string labelData = (string)reader["deskripsi_wisata"];
                    string judul = (string)reader["nama_wisata"];
                    label4.Text = labelData;
                    label1.Text = judul;

                }
            }

            reader.Close();
            connection.Close();
        }
    }
}
