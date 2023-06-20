using MyTicket_jadi.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTicket_jadi.Models
{
    public class MyTicketItem
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTicketMain));
        RoundedPanel roundedPanel = new();
        Panel panelGarisTiket = new();
        Label labelHargaTiket = new();
        Label labelKuantitas = new();
        Button buttonLihatWisata = new();
        PictureBox pbMasaBerlakuTiket = new();
        Label labelAlamatWisata = new();
        PictureBox pbLocation = new();
        PictureBox pbRating = new();
        Label lbNamaWisata = new();
        Label labelETiket = new();
        RoundedPicbox roundedPicboxWisata = new();
        Label labelMasaBerlakuTiket = new();
        MyTiket MyTiket;
        


        public MyTicketItem(MyTiket myTiket)
        {
            MyTiket = myTiket;

            roundedPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel.CornerRadius = 30;
            roundedPanel.Margin = new Padding(3, 4, 3, 4);
            roundedPanel.Name = "roundedPanel";
            roundedPanel.Size = new Size(846, 165);
            roundedPanel.TabIndex = 0;
            roundedPanel.Anchor = AnchorStyles.None;
            roundedPanel.BackColor = Color.FromArgb(209, 232, 232);
            roundedPanel.Controls.Add(panelGarisTiket);
            roundedPanel.Controls.Add(labelHargaTiket);
            roundedPanel.Controls.Add(labelKuantitas);
            roundedPanel.Controls.Add(buttonLihatWisata);
            roundedPanel.Controls.Add(pbMasaBerlakuTiket);
            roundedPanel.Controls.Add(labelAlamatWisata);
            roundedPanel.Controls.Add(pbLocation);
            roundedPanel.Controls.Add(lbNamaWisata);
            roundedPanel.Controls.Add(labelETiket);
            roundedPanel.Controls.Add(roundedPicboxWisata);
            roundedPanel.Controls.Add(labelMasaBerlakuTiket);
            roundedPanel.Controls.Add(pbRating);

            labelAlamatWisata.AutoSize = true;
            labelAlamatWisata.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamatWisata.Location = new Point(142, 91);
            labelAlamatWisata.Name = "labelAlamatWisata";

            panelGarisTiket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelGarisTiket.BackgroundImage = (Image)resources.GetObject("panelGarisTiket.BackgroundImage");
            panelGarisTiket.BackgroundImageLayout = ImageLayout.Stretch;
            panelGarisTiket.Location = new Point(16, 121);
            panelGarisTiket.Margin = new Padding(3, 4, 3, 4);
            panelGarisTiket.Size = new Size(756, 4);
            panelGarisTiket.Name = "panelGarisTiket";

            buttonLihatWisata.Text = "Lihat";
            buttonLihatWisata.Click += ButtonLihatWisata_Click;
            buttonLihatWisata.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLihatWisata.BackColor = Color.Transparent;
            buttonLihatWisata.FlatAppearance.BorderSize = 0;
            buttonLihatWisata.FlatStyle = FlatStyle.Flat;
            buttonLihatWisata.Font = new Font("Poppins Medium", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLihatWisata.ForeColor = Color.FromArgb(34, 87, 121);
            buttonLihatWisata.Location = new Point(716, 128);
            buttonLihatWisata.Margin = new Padding(3, 4, 3, 4);
            buttonLihatWisata.Name = "buttonLihatWisata";
            buttonLihatWisata.Size = new Size(89, 31);

            labelHargaTiket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHargaTiket.AutoSize = true;
            labelHargaTiket.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHargaTiket.Location = new Point(709, 60);
            labelHargaTiket.Name = "labelHargaTiket";

            labelKuantitas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelKuantitas.AutoSize = true;
            labelKuantitas.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKuantitas.Location = new Point(648, 60);
            labelKuantitas.Name = "labelKuantitas";

            pbMasaBerlakuTiket.BackgroundImage = (Image)resources.GetObject("pbMasaBerlakuTiket.BackgroundImage");
            pbMasaBerlakuTiket.BackgroundImageLayout = ImageLayout.Stretch;
            pbMasaBerlakuTiket.Location = new Point(31, 133);
            pbMasaBerlakuTiket.Margin = new Padding(3, 4, 3, 4);
            pbMasaBerlakuTiket.Name = "pbMasaBerlakuTiket";
            pbMasaBerlakuTiket.Size = new Size(14, 16);

            pbLocation.Image = (Image)resources.GetObject("pbLocation.Image");
            pbLocation.Location = new Point(125, 89);
            pbLocation.Margin = new Padding(3, 4, 3, 4);
            pbLocation.Name = "pbLocation";
            pbLocation.Size = new Size(16, 20);

            pbRating.Image = (Image)resources.GetObject("pbRating.Image");
            pbRating.Location = new Point(123, 68);
            pbRating.Margin = new Padding(3, 4, 3, 4);
            pbRating.Name = "pbRating";
            pbRating.Size = new Size(87, 19);

            lbNamaWisata.AutoSize = true;
            lbNamaWisata.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNamaWisata.Location = new Point(118, 36);
            lbNamaWisata.Name = "lbNamaWisata";
            lbNamaWisata.Size = new Size(143, 36);

            labelETiket.AutoSize = true;
            labelETiket.Font = new Font("Poppins Medium", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelETiket.ForeColor = Color.FromArgb(159, 159, 159);
            labelETiket.Location = new Point(121, 21);
            labelETiket.Name = "labelETiket";
            labelETiket.Size = new Size(74, 22);
            labelETiket.Text = "E - Tiket";

            roundedPicboxWisata.CornerRadius = 10;
            roundedPicboxWisata.Image = (Image)resources.GetObject("roundedPicboxWisata.Image");
            roundedPicboxWisata.Location = new Point(23, 16);
            roundedPicboxWisata.Margin = new Padding(3, 4, 3, 4);
            roundedPicboxWisata.Name = "roundedPicboxWisata";
            roundedPicboxWisata.Size = new Size(91, 96);

            roundedPicboxWisata.CornerRadius = 10;
            roundedPicboxWisata.Image = (Image)resources.GetObject("roundedPicboxWisata.Image");
            roundedPicboxWisata.Location = new Point(23, 16);
            roundedPicboxWisata.Margin = new Padding(3, 4, 3, 4);
            roundedPicboxWisata.Name = "roundedPicboxWisata";
            roundedPicboxWisata.Size = new Size(91, 96);

            labelMasaBerlakuTiket.AutoSize = true;
            labelMasaBerlakuTiket.Font = new Font("Poppins Medium", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelMasaBerlakuTiket.Location = new Point(45, 132);
            labelMasaBerlakuTiket.Name = "labelMasaBerlakuTiket";
            labelMasaBerlakuTiket.Size = new Size(118, 22);
            labelMasaBerlakuTiket.Text = "Berlaku 24 Jam";

            labelHargaTiket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHargaTiket.AutoSize = true;
            labelHargaTiket.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHargaTiket.Location = new Point(709, 60);
            labelHargaTiket.Name = "labelHargaTiket";
            labelHargaTiket.Size = new Size(93, 26);
   
            labelKuantitas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelKuantitas.AutoSize = true;
            labelKuantitas.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKuantitas.Location = new Point(648, 60);
            labelKuantitas.Name = "labelKuantitas";
            labelKuantitas.Size = new Size(29, 26);


            lbNamaWisata.Text = myTiket.nama_wisata;
            labelAlamatWisata.Text = myTiket.alamat_wisata;
            labelKuantitas.Text = myTiket.kuantitas;
            labelHargaTiket.Text = myTiket.harga_tiket;
        }


        private void ButtonLihatWisata_Click(object sender, EventArgs e)
        {

            using (MyTicketRembangan updateForm = new MyTicketRembangan())
            {
                MytiketContext mytiketContext = new MytiketContext();
                updateForm.SetMyticket(MyTiket);
                DialogResult dr = updateForm.ShowDialog();
            }
        }

        public RoundedPanel CreateItem()
        {
            return roundedPanel;
        }
    }
}
