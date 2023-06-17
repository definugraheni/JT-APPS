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
            this.Close();
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyTicketRembangan_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001");

            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM wisata WHERE id_wisata = 'A01'";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                labelnamaWisata.Text = (string)reader["nama_wisata"];
                labeldeskripsi.Text = (string)reader["deskripsi_wisata"];

            }
            conn.Close();
        }

    }
}

