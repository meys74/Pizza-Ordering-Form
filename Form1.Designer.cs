namespace siparis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpbxBilgiler = new GroupBox();
            cmbbxPizzaBoy = new ComboBox();
            cmbbxIcecek = new ComboBox();
            numIcecekAdet = new NumericUpDown();
            numPizzaAdet = new NumericUpDown();
            txtbxAdres = new TextBox();
            txtbxTel = new TextBox();
            txtbxAd = new TextBox();
            lblIcecekAdet = new Label();
            lblPizzaAdet = new Label();
            lblAdres = new Label();
            lblIcecek = new Label();
            lblPizzaBoy = new Label();
            lblTel = new Label();
            lblAd = new Label();
            grpbxEkstra = new GroupBox();
            chckbxKiyma = new CheckBox();
            chckbxPeynir = new CheckBox();
            chckbxMantar = new CheckBox();
            chckbxZeytin = new CheckBox();
            chckbxSosis = new CheckBox();
            chckbxSucuk = new CheckBox();
            grpbxSiparisler = new GroupBox();
            lstbxUcret = new ListBox();
            lstbxIcecekveAdet = new ListBox();
            lstbxEkstra = new ListBox();
            lstbxPizzaBoyveAdet = new ListBox();
            lstbxAdres = new ListBox();
            lblIcecekveAdet = new Label();
            lblEkstra = new Label();
            lblPizzaBoyveAdet = new Label();
            lblAdresSiparis = new Label();
            lblTelSiparis = new Label();
            lblAdSiparis = new Label();
            lstbxTel = new ListBox();
            lstbxAd = new ListBox();
            lblUcret = new Label();
            btnSiparisAl = new Button();
            btnTemizle = new Button();
            btnHepsiniTemizle = new Button();
            grpbxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIcecekAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPizzaAdet).BeginInit();
            grpbxEkstra.SuspendLayout();
            grpbxSiparisler.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxBilgiler
            // 
            grpbxBilgiler.Controls.Add(cmbbxPizzaBoy);
            grpbxBilgiler.Controls.Add(cmbbxIcecek);
            grpbxBilgiler.Controls.Add(numIcecekAdet);
            grpbxBilgiler.Controls.Add(numPizzaAdet);
            grpbxBilgiler.Controls.Add(txtbxAdres);
            grpbxBilgiler.Controls.Add(txtbxTel);
            grpbxBilgiler.Controls.Add(txtbxAd);
            grpbxBilgiler.Controls.Add(lblIcecekAdet);
            grpbxBilgiler.Controls.Add(lblPizzaAdet);
            grpbxBilgiler.Controls.Add(lblAdres);
            grpbxBilgiler.Controls.Add(lblIcecek);
            grpbxBilgiler.Controls.Add(lblPizzaBoy);
            grpbxBilgiler.Controls.Add(lblTel);
            grpbxBilgiler.Controls.Add(lblAd);
            grpbxBilgiler.Location = new Point(27, 25);
            grpbxBilgiler.Name = "grpbxBilgiler";
            grpbxBilgiler.Size = new Size(477, 237);
            grpbxBilgiler.TabIndex = 0;
            grpbxBilgiler.TabStop = false;
            grpbxBilgiler.Text = "Bilgiler";
            // 
            // cmbbxPizzaBoy
            // 
            cmbbxPizzaBoy.FormattingEnabled = true;
            cmbbxPizzaBoy.Items.AddRange(new object[] { "Boyut Seçiniz...", "Küçük (329TL)", "Orta (389TL)", "Büyük (449TL)" });
            cmbbxPizzaBoy.Location = new Point(99, 146);
            cmbbxPizzaBoy.Name = "cmbbxPizzaBoy";
            cmbbxPizzaBoy.Size = new Size(121, 23);
            cmbbxPizzaBoy.TabIndex = 16;
            cmbbxPizzaBoy.SelectedIndexChanged += cmbbxPizzaBoy_SelectedIndexChanged;
            // 
            // cmbbxIcecek
            // 
            cmbbxIcecek.FormattingEnabled = true;
            cmbbxIcecek.Items.AddRange(new object[] { "İçecek Seçiniz...", "500ml Su (+10TL)", "200ml Soda(+40TL)", "250ml Meyve Suyu(+45TL)", "200ml Fanta(+45TL)", "200ml Coca-Cola(+55TL)", "200ml Coca-Cola Zero(+55TL)", "200ml Lipton Ice Tea(+50TL)" });
            cmbbxIcecek.Location = new Point(99, 190);
            cmbbxIcecek.Name = "cmbbxIcecek";
            cmbbxIcecek.Size = new Size(121, 23);
            cmbbxIcecek.TabIndex = 15;
            cmbbxIcecek.SelectedIndexChanged += cmbbxIcecek_SelectedIndexChanged;
            // 
            // numIcecekAdet
            // 
            numIcecekAdet.Location = new Point(285, 189);
            numIcecekAdet.Name = "numIcecekAdet";
            numIcecekAdet.Size = new Size(67, 23);
            numIcecekAdet.TabIndex = 14;
            // 
            // numPizzaAdet
            // 
            numPizzaAdet.Location = new Point(285, 147);
            numPizzaAdet.Name = "numPizzaAdet";
            numPizzaAdet.Size = new Size(67, 23);
            numPizzaAdet.TabIndex = 13;
            numPizzaAdet.ValueChanged += numPizzaAdet_ValueChanged;
            // 
            // txtbxAdres
            // 
            txtbxAdres.Location = new Point(285, 37);
            txtbxAdres.Multiline = true;
            txtbxAdres.Name = "txtbxAdres";
            txtbxAdres.Size = new Size(172, 88);
            txtbxAdres.TabIndex = 12;
            // 
            // txtbxTel
            // 
            txtbxTel.Location = new Point(99, 82);
            txtbxTel.Name = "txtbxTel";
            txtbxTel.Size = new Size(121, 23);
            txtbxTel.TabIndex = 11;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(99, 40);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(121, 23);
            txtbxAd.TabIndex = 10;
            // 
            // lblIcecekAdet
            // 
            lblIcecekAdet.AutoSize = true;
            lblIcecekAdet.Location = new Point(244, 193);
            lblIcecekAdet.Name = "lblIcecekAdet";
            lblIcecekAdet.Size = new Size(35, 15);
            lblIcecekAdet.TabIndex = 9;
            lblIcecekAdet.Text = "Adet:";
            // 
            // lblPizzaAdet
            // 
            lblPizzaAdet.AutoSize = true;
            lblPizzaAdet.Location = new Point(244, 146);
            lblPizzaAdet.Name = "lblPizzaAdet";
            lblPizzaAdet.Size = new Size(35, 15);
            lblPizzaAdet.TabIndex = 8;
            lblPizzaAdet.Text = "Adet:";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(239, 40);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 7;
            lblAdres.Text = "Adres:";
            lblAdres.Click += lblAdres_Click;
            // 
            // lblIcecek
            // 
            lblIcecek.AutoSize = true;
            lblIcecek.Location = new Point(40, 191);
            lblIcecek.Name = "lblIcecek";
            lblIcecek.Size = new Size(43, 15);
            lblIcecek.TabIndex = 6;
            lblIcecek.Text = "İçecek:";
            lblIcecek.Click += lblIcecek_Click;
            // 
            // lblPizzaBoy
            // 
            lblPizzaBoy.AutoSize = true;
            lblPizzaBoy.Location = new Point(24, 149);
            lblPizzaBoy.Name = "lblPizzaBoy";
            lblPizzaBoy.Size = new Size(59, 15);
            lblPizzaBoy.TabIndex = 5;
            lblPizzaBoy.Text = "Pizza Boy:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(35, 86);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(48, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefon:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(17, 43);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(66, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adı Soyadı:";
            // 
            // grpbxEkstra
            // 
            grpbxEkstra.Controls.Add(chckbxKiyma);
            grpbxEkstra.Controls.Add(chckbxPeynir);
            grpbxEkstra.Controls.Add(chckbxMantar);
            grpbxEkstra.Controls.Add(chckbxZeytin);
            grpbxEkstra.Controls.Add(chckbxSosis);
            grpbxEkstra.Controls.Add(chckbxSucuk);
            grpbxEkstra.Location = new Point(527, 28);
            grpbxEkstra.Name = "grpbxEkstra";
            grpbxEkstra.Size = new Size(255, 122);
            grpbxEkstra.TabIndex = 1;
            grpbxEkstra.TabStop = false;
            grpbxEkstra.Text = "Ekstra (Her biri +5TL)";
            // 
            // chckbxKiyma
            // 
            chckbxKiyma.AutoSize = true;
            chckbxKiyma.Location = new Point(140, 86);
            chckbxKiyma.Name = "chckbxKiyma";
            chckbxKiyma.Size = new Size(59, 19);
            chckbxKiyma.TabIndex = 5;
            chckbxKiyma.Text = "Kıyma";
            chckbxKiyma.UseVisualStyleBackColor = true;
            // 
            // chckbxPeynir
            // 
            chckbxPeynir.AutoSize = true;
            chckbxPeynir.Location = new Point(140, 54);
            chckbxPeynir.Name = "chckbxPeynir";
            chckbxPeynir.Size = new Size(59, 19);
            chckbxPeynir.TabIndex = 4;
            chckbxPeynir.Text = "Peynir";
            chckbxPeynir.UseVisualStyleBackColor = true;
            // 
            // chckbxMantar
            // 
            chckbxMantar.AutoSize = true;
            chckbxMantar.Location = new Point(140, 22);
            chckbxMantar.Name = "chckbxMantar";
            chckbxMantar.Size = new Size(64, 19);
            chckbxMantar.TabIndex = 3;
            chckbxMantar.Text = "Mantar";
            chckbxMantar.UseVisualStyleBackColor = true;
            // 
            // chckbxZeytin
            // 
            chckbxZeytin.AutoSize = true;
            chckbxZeytin.Location = new Point(28, 86);
            chckbxZeytin.Name = "chckbxZeytin";
            chckbxZeytin.Size = new Size(59, 19);
            chckbxZeytin.TabIndex = 2;
            chckbxZeytin.Text = "Zeytin";
            chckbxZeytin.UseVisualStyleBackColor = true;
            // 
            // chckbxSosis
            // 
            chckbxSosis.AutoSize = true;
            chckbxSosis.Location = new Point(28, 54);
            chckbxSosis.Name = "chckbxSosis";
            chckbxSosis.Size = new Size(52, 19);
            chckbxSosis.TabIndex = 1;
            chckbxSosis.Text = "Sosis";
            chckbxSosis.UseVisualStyleBackColor = true;
            // 
            // chckbxSucuk
            // 
            chckbxSucuk.AutoSize = true;
            chckbxSucuk.Location = new Point(28, 22);
            chckbxSucuk.Name = "chckbxSucuk";
            chckbxSucuk.Size = new Size(58, 19);
            chckbxSucuk.TabIndex = 0;
            chckbxSucuk.Text = "Sucuk";
            chckbxSucuk.UseVisualStyleBackColor = true;
            chckbxSucuk.CheckedChanged += chckbxSucuk_CheckedChanged;
            // 
            // grpbxSiparisler
            // 
            grpbxSiparisler.Controls.Add(lstbxUcret);
            grpbxSiparisler.Controls.Add(lstbxIcecekveAdet);
            grpbxSiparisler.Controls.Add(lstbxEkstra);
            grpbxSiparisler.Controls.Add(lstbxPizzaBoyveAdet);
            grpbxSiparisler.Controls.Add(lstbxAdres);
            grpbxSiparisler.Controls.Add(lblIcecekveAdet);
            grpbxSiparisler.Controls.Add(lblEkstra);
            grpbxSiparisler.Controls.Add(lblPizzaBoyveAdet);
            grpbxSiparisler.Controls.Add(lblAdresSiparis);
            grpbxSiparisler.Controls.Add(lblTelSiparis);
            grpbxSiparisler.Controls.Add(lblAdSiparis);
            grpbxSiparisler.Controls.Add(lstbxTel);
            grpbxSiparisler.Controls.Add(lstbxAd);
            grpbxSiparisler.Controls.Add(lblUcret);
            grpbxSiparisler.Location = new Point(27, 274);
            grpbxSiparisler.Name = "grpbxSiparisler";
            grpbxSiparisler.Size = new Size(829, 210);
            grpbxSiparisler.TabIndex = 2;
            grpbxSiparisler.TabStop = false;
            grpbxSiparisler.Text = "Siparişler";
            // 
            // lstbxUcret
            // 
            lstbxUcret.FormattingEnabled = true;
            lstbxUcret.ItemHeight = 15;
            lstbxUcret.Location = new Point(703, 75);
            lstbxUcret.Name = "lstbxUcret";
            lstbxUcret.Size = new Size(109, 109);
            lstbxUcret.TabIndex = 22;
            // 
            // lstbxIcecekveAdet
            // 
            lstbxIcecekveAdet.FormattingEnabled = true;
            lstbxIcecekveAdet.ItemHeight = 15;
            lstbxIcecekveAdet.Location = new Point(588, 75);
            lstbxIcecekveAdet.Name = "lstbxIcecekveAdet";
            lstbxIcecekveAdet.Size = new Size(109, 109);
            lstbxIcecekveAdet.TabIndex = 21;
            // 
            // lstbxEkstra
            // 
            lstbxEkstra.FormattingEnabled = true;
            lstbxEkstra.ItemHeight = 15;
            lstbxEkstra.Location = new Point(473, 75);
            lstbxEkstra.Name = "lstbxEkstra";
            lstbxEkstra.Size = new Size(109, 109);
            lstbxEkstra.TabIndex = 20;
            // 
            // lstbxPizzaBoyveAdet
            // 
            lstbxPizzaBoyveAdet.FormattingEnabled = true;
            lstbxPizzaBoyveAdet.ItemHeight = 15;
            lstbxPizzaBoyveAdet.Location = new Point(358, 75);
            lstbxPizzaBoyveAdet.Name = "lstbxPizzaBoyveAdet";
            lstbxPizzaBoyveAdet.Size = new Size(109, 109);
            lstbxPizzaBoyveAdet.TabIndex = 19;
            // 
            // lstbxAdres
            // 
            lstbxAdres.FormattingEnabled = true;
            lstbxAdres.ItemHeight = 15;
            lstbxAdres.Location = new Point(243, 75);
            lstbxAdres.Name = "lstbxAdres";
            lstbxAdres.Size = new Size(109, 109);
            lstbxAdres.TabIndex = 18;
            // 
            // lblIcecekveAdet
            // 
            lblIcecekveAdet.AutoSize = true;
            lblIcecekveAdet.Location = new Point(588, 41);
            lblIcecekveAdet.Name = "lblIcecekveAdet";
            lblIcecekveAdet.Size = new Size(83, 15);
            lblIcecekveAdet.TabIndex = 17;
            lblIcecekveAdet.Text = "İçecek ve Adet";
            // 
            // lblEkstra
            // 
            lblEkstra.AutoSize = true;
            lblEkstra.Location = new Point(473, 41);
            lblEkstra.Name = "lblEkstra";
            lblEkstra.Size = new Size(38, 15);
            lblEkstra.TabIndex = 6;
            lblEkstra.Text = "Ekstra";
            lblEkstra.Click += lblEkstra_Click;
            // 
            // lblPizzaBoyveAdet
            // 
            lblPizzaBoyveAdet.AutoSize = true;
            lblPizzaBoyveAdet.Location = new Point(358, 41);
            lblPizzaBoyveAdet.Name = "lblPizzaBoyveAdet";
            lblPizzaBoyveAdet.Size = new Size(99, 15);
            lblPizzaBoyveAdet.TabIndex = 17;
            lblPizzaBoyveAdet.Text = "Pizza Boy ve Adet";
            // 
            // lblAdresSiparis
            // 
            lblAdresSiparis.AutoSize = true;
            lblAdresSiparis.Location = new Point(243, 41);
            lblAdresSiparis.Name = "lblAdresSiparis";
            lblAdresSiparis.Size = new Size(37, 15);
            lblAdresSiparis.TabIndex = 17;
            lblAdresSiparis.Text = "Adres";
            // 
            // lblTelSiparis
            // 
            lblTelSiparis.AutoSize = true;
            lblTelSiparis.Location = new Point(128, 41);
            lblTelSiparis.Name = "lblTelSiparis";
            lblTelSiparis.Size = new Size(45, 15);
            lblTelSiparis.TabIndex = 17;
            lblTelSiparis.Text = "Telefon";
            // 
            // lblAdSiparis
            // 
            lblAdSiparis.AutoSize = true;
            lblAdSiparis.Location = new Point(13, 41);
            lblAdSiparis.Name = "lblAdSiparis";
            lblAdSiparis.Size = new Size(60, 15);
            lblAdSiparis.TabIndex = 17;
            lblAdSiparis.Text = "Adı Soyad";
            // 
            // lstbxTel
            // 
            lstbxTel.FormattingEnabled = true;
            lstbxTel.ItemHeight = 15;
            lstbxTel.Location = new Point(128, 75);
            lstbxTel.Name = "lstbxTel";
            lstbxTel.Size = new Size(109, 109);
            lstbxTel.TabIndex = 8;
            // 
            // lstbxAd
            // 
            lstbxAd.FormattingEnabled = true;
            lstbxAd.ItemHeight = 15;
            lstbxAd.Location = new Point(13, 75);
            lstbxAd.Name = "lstbxAd";
            lstbxAd.Size = new Size(109, 109);
            lstbxAd.TabIndex = 7;
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Location = new Point(703, 41);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(35, 15);
            lblUcret.TabIndex = 6;
            lblUcret.Text = "Ücret";
            // 
            // btnSiparisAl
            // 
            btnSiparisAl.BackColor = SystemColors.ControlLight;
            btnSiparisAl.Location = new Point(527, 177);
            btnSiparisAl.Name = "btnSiparisAl";
            btnSiparisAl.Size = new Size(111, 23);
            btnSiparisAl.TabIndex = 3;
            btnSiparisAl.Text = "Sipariş Al";
            btnSiparisAl.UseVisualStyleBackColor = false;
            btnSiparisAl.Click += btnSiparisAl_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ControlLight;
            btnTemizle.Location = new Point(527, 224);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(111, 23);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnHepsiniTemizle
            // 
            btnHepsiniTemizle.BackColor = SystemColors.ControlLight;
            btnHepsiniTemizle.Location = new Point(656, 177);
            btnHepsiniTemizle.Name = "btnHepsiniTemizle";
            btnHepsiniTemizle.Size = new Size(126, 70);
            btnHepsiniTemizle.TabIndex = 5;
            btnHepsiniTemizle.Text = "Siparişleri Temizle";
            btnHepsiniTemizle.UseVisualStyleBackColor = false;
            btnHepsiniTemizle.Click += btnHepsiniTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(868, 498);
            Controls.Add(btnHepsiniTemizle);
            Controls.Add(btnTemizle);
            Controls.Add(btnSiparisAl);
            Controls.Add(grpbxSiparisler);
            Controls.Add(grpbxEkstra);
            Controls.Add(grpbxBilgiler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpbxBilgiler.ResumeLayout(false);
            grpbxBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIcecekAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPizzaAdet).EndInit();
            grpbxEkstra.ResumeLayout(false);
            grpbxEkstra.PerformLayout();
            grpbxSiparisler.ResumeLayout(false);
            grpbxSiparisler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxBilgiler;
        private GroupBox grpbxEkstra;
        private GroupBox grpbxSiparisler;
        private Label lblIcecekAdet;
        private Label lblPizzaAdet;
        private Label lblAdres;
        private Label lblIcecek;
        private Label lblPizzaBoy;
        private Label lblTel;
        private Label lblAd;
        private Label lblUcret;
        private ComboBox cmbbxPizzaBoy;
        private ComboBox cmbbxIcecek;
        private NumericUpDown numIcecekAdet;
        private NumericUpDown numPizzaAdet;
        private TextBox txtbxAdres;
        private TextBox txtbxTel;
        private TextBox txtbxAd;
        private CheckBox chckbxKiyma;
        private CheckBox chckbxPeynir;
        private CheckBox chckbxMantar;
        private CheckBox chckbxZeytin;
        private CheckBox chckbxSosis;
        private CheckBox chckbxSucuk;
        private ListBox lstbxTel;
        private ListBox lstbxAd;
        private Button btnSiparisAl;
        private Button btnTemizle;
        private Button btnHepsiniTemizle;
        private Label lblIcecekveAdet;
        private Label lblEkstra;
        private Label lblPizzaBoyveAdet;
        private Label lblAdresSiparis;
        private Label lblTelSiparis;
        private Label lblAdSiparis;
        private ListBox lstbxUcret;
        private ListBox lstbxIcecekveAdet;
        private ListBox lstbxEkstra;
        private ListBox lstbxPizzaBoyveAdet;
        private ListBox lstbxAdres;
    }
}
