using MyTicket_jadi.Models;
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
    public partial class MyTicketMain : Form
    {
        Models.MytiketContext mytiketContext;
        public MyTicketMain()
        {
            InitializeComponent();
            mytiketContext = new Models.MytiketContext();

            //mytiketContext.Read();
        }

        private void roundedPicbox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTicketRembangan myTicketRembangan = new MyTicketRembangan();
            myTicketRembangan.Show();
            this.Hide();
        }

        private void MyTicketMain_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTicketRembangan myTicketRembangan = new MyTicketRembangan();
            myTicketRembangan.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void ShowItems()
        {
            mytiketContext.Read();
            List<MyTiket> tiketList;
            tiketList = mytiketContext.TiketList;

            flpMyTicket.Controls.Clear();
            foreach (var tiket in tiketList)
            {

                lbNamaWisata.Text = tiket.NamaWisata;
                labelAlamatWisata.Text = tiket.AlamatWisata;
                labelKuantitas.Text = tiket.Kuantitas.ToString();
                labelHargaTiket.Text = tiket.HargaTiket.ToString();
                roundedPicboxWisata.Image = tiket.Image;

                RoundedPanel ticketItem = new MyTicketItem(tiket).CreateItem();
                flpMyTicket.Controls.Add(ticketItem);
            }

        }
    }
}
