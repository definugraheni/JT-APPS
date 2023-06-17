namespace MyTicket_jadi
{
    partial class MyTicketPapuma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTicketPapuma));
            panelSidebar = new Panel();
            btnWishlist = new Button();
            btnHistory = new Button();
            btnVoucher = new Button();
            btnPaket = new Button();
            Homepage = new Button();
            pictureBoxLogo = new PictureBox();
            panelMain = new Panel();
            panel1 = new Panel();
            labeldeskripsi = new Label();
            customRoundedButton1 = new CustomRoundedButton();
            label5 = new Label();
            labelHarga = new Label();
            panel2 = new Panel();
            roundedPanel2 = new RoundedPanel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            labelnamaWisata = new Label();
            panelNavbar = new Panel();
            button1 = new Button();
            labelMyTicket = new Label();
            label2 = new Label();
            label4 = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(btnWishlist);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnVoucher);
            panelSidebar.Controls.Add(btnPaket);
            panelSidebar.Controls.Add(Homepage);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(193, 731);
            panelSidebar.TabIndex = 5;
            // 
            // btnWishlist
            // 
            btnWishlist.Cursor = Cursors.Hand;
            btnWishlist.FlatAppearance.BorderSize = 0;
            btnWishlist.FlatStyle = FlatStyle.Flat;
            btnWishlist.Location = new Point(3, 296);
            btnWishlist.Margin = new Padding(3, 4, 3, 4);
            btnWishlist.Name = "btnWishlist";
            btnWishlist.Size = new Size(162, 33);
            btnWishlist.TabIndex = 19;
            btnWishlist.Text = "Wishlist";
            btnWishlist.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Location = new Point(3, 252);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(162, 36);
            btnHistory.TabIndex = 18;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnVoucher
            // 
            btnVoucher.Cursor = Cursors.Hand;
            btnVoucher.FlatAppearance.BorderSize = 0;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoucher.Location = new Point(3, 208);
            btnVoucher.Margin = new Padding(3, 4, 3, 4);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(162, 31);
            btnVoucher.TabIndex = 17;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            // 
            // btnPaket
            // 
            btnPaket.Cursor = Cursors.Hand;
            btnPaket.FlatAppearance.BorderSize = 0;
            btnPaket.FlatStyle = FlatStyle.Flat;
            btnPaket.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaket.Location = new Point(3, 164);
            btnPaket.Margin = new Padding(3, 4, 3, 4);
            btnPaket.Name = "btnPaket";
            btnPaket.Size = new Size(162, 31);
            btnPaket.TabIndex = 16;
            btnPaket.Text = "Paket";
            btnPaket.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            Homepage.Cursor = Cursors.Hand;
            Homepage.FlatAppearance.BorderSize = 0;
            Homepage.FlatStyle = FlatStyle.Flat;
            Homepage.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Homepage.Location = new Point(3, 119);
            Homepage.Margin = new Padding(3, 4, 3, 4);
            Homepage.Name = "Homepage";
            Homepage.Size = new Size(162, 33);
            Homepage.TabIndex = 15;
            Homepage.Text = "Homepage";
            Homepage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(62, 27);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(43, 28);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panel1);
            panelMain.Location = new Point(198, 77);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(899, 653);
            panelMain.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labeldeskripsi);
            panel1.Controls.Add(customRoundedButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(labelHarga);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(32, 41);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 552);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // labeldeskripsi
            // 
            labeldeskripsi.AutoSize = true;
            labeldeskripsi.BackColor = Color.Transparent;
            labeldeskripsi.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labeldeskripsi.Location = new Point(61, 220);
            labeldeskripsi.Name = "labeldeskripsi";
            labeldeskripsi.Size = new Size(88, 26);
            labeldeskripsi.TabIndex = 13;
            labeldeskripsi.Text = "DESKRIPSI ";
            // 
            // customRoundedButton1
            // 
            customRoundedButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customRoundedButton1.BackColor = Color.FromArgb(55, 163, 165);
            customRoundedButton1.CornerRadius = 10;
            customRoundedButton1.FlatAppearance.BorderSize = 0;
            customRoundedButton1.FlatStyle = FlatStyle.Flat;
            customRoundedButton1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customRoundedButton1.ForeColor = Color.White;
            customRoundedButton1.HoverColor = Color.FromArgb(55, 163, 165);
            customRoundedButton1.Location = new Point(685, 448);
            customRoundedButton1.Margin = new Padding(3, 4, 3, 4);
            customRoundedButton1.Name = "customRoundedButton1";
            customRoundedButton1.PressColor = Color.Transparent;
            customRoundedButton1.Size = new Size(101, 45);
            customRoundedButton1.TabIndex = 9;
            customRoundedButton1.Text = "Tutup";
            customRoundedButton1.UseVisualStyleBackColor = false;
            customRoundedButton1.Click += customRoundedButton1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(61, 167);
            label5.Name = "label5";
            label5.Size = new Size(165, 26);
            label5.TabIndex = 8;
            label5.Text = "DESKRIPSI PAPUMA";
            // 
            // labelHarga
            // 
            labelHarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHarga.AutoSize = true;
            labelHarga.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHarga.Location = new Point(701, 49);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(115, 36);
            labelHarga.TabIndex = 4;
            labelHarga.Text = "Rp 25.000";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(roundedPanel2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(labelnamaWisata);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 119);
            panel2.TabIndex = 6;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(34, 87, 121);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.CornerRadius = 5;
            roundedPanel2.Location = new Point(34, 75);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(57, 20);
            roundedPanel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 22);
            label6.TabIndex = 9;
            label6.Text = "E - Ticket";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(98, 75);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 20);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // labelnamaWisata
            // 
            labelnamaWisata.AutoSize = true;
            labelnamaWisata.BackColor = Color.Transparent;
            labelnamaWisata.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelnamaWisata.ForeColor = Color.White;
            labelnamaWisata.Location = new Point(23, 33);
            labelnamaWisata.Name = "labelnamaWisata";
            labelnamaWisata.Size = new Size(136, 48);
            labelnamaWisata.TabIndex = 0;
            labelnamaWisata.Text = "Papuma";
            // 
            // panelNavbar
            // 
            panelNavbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavbar.BackColor = Color.FromArgb(55, 163, 165);
            panelNavbar.BackgroundImageLayout = ImageLayout.Stretch;
            panelNavbar.Controls.Add(button1);
            panelNavbar.Controls.Add(labelMyTicket);
            panelNavbar.Location = new Point(198, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(902, 77);
            panelNavbar.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(18, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(17, 24);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMyTicket
            // 
            labelMyTicket.Anchor = AnchorStyles.Top;
            labelMyTicket.AutoSize = true;
            labelMyTicket.BackColor = Color.Transparent;
            labelMyTicket.FlatStyle = FlatStyle.Flat;
            labelMyTicket.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMyTicket.ForeColor = Color.White;
            labelMyTicket.Location = new Point(402, 20);
            labelMyTicket.Name = "labelMyTicket";
            labelMyTicket.Size = new Size(112, 36);
            labelMyTicket.TabIndex = 0;
            labelMyTicket.Text = " MyTicket";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-145, 1);
            label2.Name = "label2";
            label2.Size = new Size(42, 14);
            label2.TabIndex = 3;
            label2.Text = "E - Ticket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 2);
            label4.Name = "label4";
            label4.Size = new Size(42, 14);
            label4.TabIndex = 7;
            label4.Text = "E - Ticket";
            // 
            // MyTicketPapuma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 731);
            Controls.Add(panelNavbar);
            Controls.Add(panelSidebar);
            Controls.Add(panelMain);
            Location = new Point(98, 89);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1095, 704);
            Name = "MyTicketPapuma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyTicketPapuma";
            WindowState = FormWindowState.Maximized;
            Load += MyTicketPapuma_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnWishlist;
        private Button btnHistory;
        private Button btnVoucher;
        private Button btnPaket;
        private Button Homepage;
        private PictureBox pictureBoxLogo;
        private Panel panelMain;
        private Panel panelNavbar;
        private Button button1;
        private Label labelMyTicket;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label labelHarga;
        private Label labelnamaWisata;
        private Panel panel2;
        private RoundedPanel roundedPanel1;
        private Label label2;
        private Label label4;
        private CustomRoundedButton btnTutup;
        private Label label5;
        private CustomRoundedButton customRoundedButton1;
        private RoundedPanel roundedPanel2;
        private Label label6;
        private Label labeldeskripsi;
    }
}