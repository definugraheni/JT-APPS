using Npgsql;
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
    public partial class MyTicketPatemon : Form
    {
        public MyTicketPatemon()
        {
            InitializeComponent();
        }

        private void MyTicketPatemon_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001");

            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM wisata WHERE id_wisata = 'A03'";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                labelnamaWisata.Text = (string)reader["nama_wisata"];
                labeldeskripsi.Text = (string)reader["deskripsi_wisata"];

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customRoundedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

