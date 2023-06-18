using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTicket_jadi.Models;
using Npgsql;

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
            using NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001");

            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM wisata WHERE id_wisata = 'A04'";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                labelnamaWisata.Text = (string)reader ["nama_wisata"];
                labeldeskripsi.Text = (string)reader["deskripsi_wisata"];

            }
            conn.Close();
        }
       
        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Close();
        }

        //public void SetMyticket(MyTiket myTiket)
        //{
        //    labelnamaWisata.Text = myTiket.nama_wisata;
        //    labeldeskripsi.Text = myTiket.harga_tiket;
        //    labeldeskripsi.Text = myTiket.nama_wisata;
        //    labelHarga.Text = myTiket.nama_wisata;
        //}
    }
}
