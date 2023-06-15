namespace GUI_Implementation
{
    partial class Kasir
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
            panelMenuKasir = new Panel();
            textBoxStatusPesanan = new TextBox();
            textBoxMetodePembayaran = new TextBox();
            textBoxHarga = new TextBox();
            textBoxJumlah = new TextBox();
            textBoxMenu = new TextBox();
            textBoxTenant = new TextBox();
            textBoxNoAntrian = new TextBox();
            labelStatus = new Label();
            labelMetodePembayaran = new Label();
            labelHarga = new Label();
            labelQTY = new Label();
            labelNamaMenu = new Label();
            labelTenant = new Label();
            labelNoAntrian = new Label();
            listView1 = new ListView();
            label1 = new Label();
            buttonLogoutKasir = new Button();
            buttonPrintStruk = new Button();
            buttonKonfirmasiPembayaran = new Button();
            panelMenuKasir.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuKasir
            // 
            panelMenuKasir.BackColor = Color.DarkRed;
            panelMenuKasir.Controls.Add(textBoxStatusPesanan);
            panelMenuKasir.Controls.Add(textBoxMetodePembayaran);
            panelMenuKasir.Controls.Add(textBoxHarga);
            panelMenuKasir.Controls.Add(textBoxJumlah);
            panelMenuKasir.Controls.Add(textBoxMenu);
            panelMenuKasir.Controls.Add(textBoxTenant);
            panelMenuKasir.Controls.Add(textBoxNoAntrian);
            panelMenuKasir.Controls.Add(labelStatus);
            panelMenuKasir.Controls.Add(labelMetodePembayaran);
            panelMenuKasir.Controls.Add(labelHarga);
            panelMenuKasir.Controls.Add(labelQTY);
            panelMenuKasir.Controls.Add(labelNamaMenu);
            panelMenuKasir.Controls.Add(labelTenant);
            panelMenuKasir.Controls.Add(labelNoAntrian);
            panelMenuKasir.Controls.Add(listView1);
            panelMenuKasir.Controls.Add(label1);
            panelMenuKasir.Controls.Add(buttonLogoutKasir);
            panelMenuKasir.Controls.Add(buttonPrintStruk);
            panelMenuKasir.Controls.Add(buttonKonfirmasiPembayaran);
            panelMenuKasir.Location = new Point(0, 1);
            panelMenuKasir.Name = "panelMenuKasir";
            panelMenuKasir.Size = new Size(1303, 552);
            panelMenuKasir.TabIndex = 0;
            panelMenuKasir.Paint += panelMenuKasir_Paint;
            // 
            // textBoxStatusPesanan
            // 
            textBoxStatusPesanan.Location = new Point(959, 455);
            textBoxStatusPesanan.Name = "textBoxStatusPesanan";
            textBoxStatusPesanan.Size = new Size(217, 27);
            textBoxStatusPesanan.TabIndex = 17;
            // 
            // textBoxMetodePembayaran
            // 
            textBoxMetodePembayaran.Location = new Point(959, 398);
            textBoxMetodePembayaran.Name = "textBoxMetodePembayaran";
            textBoxMetodePembayaran.Size = new Size(217, 27);
            textBoxMetodePembayaran.TabIndex = 16;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(959, 347);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(217, 27);
            textBoxHarga.TabIndex = 15;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(447, 516);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(217, 27);
            textBoxJumlah.TabIndex = 14;
            // 
            // textBoxMenu
            // 
            textBoxMenu.Location = new Point(447, 455);
            textBoxMenu.Name = "textBoxMenu";
            textBoxMenu.Size = new Size(217, 27);
            textBoxMenu.TabIndex = 13;
            // 
            // textBoxTenant
            // 
            textBoxTenant.Location = new Point(447, 398);
            textBoxTenant.Name = "textBoxTenant";
            textBoxTenant.Size = new Size(217, 27);
            textBoxTenant.TabIndex = 12;
            // 
            // textBoxNoAntrian
            // 
            textBoxNoAntrian.Location = new Point(447, 347);
            textBoxNoAntrian.Name = "textBoxNoAntrian";
            textBoxNoAntrian.Size = new Size(217, 27);
            textBoxNoAntrian.TabIndex = 11;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(726, 451);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(159, 28);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status Pesanan :";
            // 
            // labelMetodePembayaran
            // 
            labelMetodePembayaran.AutoSize = true;
            labelMetodePembayaran.BackColor = Color.Transparent;
            labelMetodePembayaran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMetodePembayaran.ForeColor = Color.White;
            labelMetodePembayaran.Location = new Point(726, 394);
            labelMetodePembayaran.Name = "labelMetodePembayaran";
            labelMetodePembayaran.Size = new Size(211, 28);
            labelMetodePembayaran.TabIndex = 9;
            labelMetodePembayaran.Text = "Metode Pembayaran :";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(726, 343);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(77, 28);
            labelHarga.TabIndex = 8;
            labelHarga.Text = "Harga :";
            // 
            // labelQTY
            // 
            labelQTY.AutoSize = true;
            labelQTY.BackColor = Color.Transparent;
            labelQTY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelQTY.ForeColor = Color.White;
            labelQTY.Location = new Point(297, 515);
            labelQTY.Name = "labelQTY";
            labelQTY.Size = new Size(94, 28);
            labelQTY.TabIndex = 7;
            labelQTY.Text = "Jumlah : ";
            // 
            // labelNamaMenu
            // 
            labelNamaMenu.AutoSize = true;
            labelNamaMenu.BackColor = Color.Transparent;
            labelNamaMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNamaMenu.ForeColor = Color.White;
            labelNamaMenu.Location = new Point(297, 451);
            labelNamaMenu.Name = "labelNamaMenu";
            labelNamaMenu.Size = new Size(76, 28);
            labelNamaMenu.TabIndex = 6;
            labelNamaMenu.Text = "Menu :";
            // 
            // labelTenant
            // 
            labelTenant.AutoSize = true;
            labelTenant.BackColor = Color.Transparent;
            labelTenant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTenant.ForeColor = Color.White;
            labelTenant.Location = new Point(297, 394);
            labelTenant.Name = "labelTenant";
            labelTenant.Size = new Size(84, 28);
            labelTenant.TabIndex = 5;
            labelTenant.Text = "Tenant :";
            // 
            // labelNoAntrian
            // 
            labelNoAntrian.AutoSize = true;
            labelNoAntrian.BackColor = Color.Transparent;
            labelNoAntrian.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoAntrian.ForeColor = Color.White;
            labelNoAntrian.Location = new Point(297, 343);
            labelNoAntrian.Name = "labelNoAntrian";
            labelNoAntrian.Size = new Size(122, 28);
            labelNoAntrian.TabIndex = 4;
            labelNoAntrian.Text = "No Antrian :";
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(297, 11);
            listView1.Name = "listView1";
            listView1.Size = new Size(995, 311);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 1;
            label1.Text = "Dashboard Kasir";
            label1.Click += label1_Click;
            // 
            // buttonLogoutKasir
            // 
            buttonLogoutKasir.BackColor = Color.White;
            buttonLogoutKasir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogoutKasir.ForeColor = Color.DarkRed;
            buttonLogoutKasir.Location = new Point(32, 480);
            buttonLogoutKasir.Name = "buttonLogoutKasir";
            buttonLogoutKasir.Size = new Size(116, 41);
            buttonLogoutKasir.TabIndex = 2;
            buttonLogoutKasir.Text = "Logout";
            buttonLogoutKasir.UseVisualStyleBackColor = false;
            buttonLogoutKasir.Click += buttonLogoutKasir_Click;
            // 
            // buttonPrintStruk
            // 
            buttonPrintStruk.BackColor = Color.White;
            buttonPrintStruk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrintStruk.ForeColor = Color.DarkRed;
            buttonPrintStruk.Location = new Point(32, 277);
            buttonPrintStruk.Name = "buttonPrintStruk";
            buttonPrintStruk.Size = new Size(248, 63);
            buttonPrintStruk.TabIndex = 1;
            buttonPrintStruk.Text = "Print Struk";
            buttonPrintStruk.UseVisualStyleBackColor = false;
            buttonPrintStruk.Click += buttonPrintStruk_Click;
            // 
            // buttonKonfirmasiPembayaran
            // 
            buttonKonfirmasiPembayaran.BackColor = Color.White;
            buttonKonfirmasiPembayaran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKonfirmasiPembayaran.ForeColor = Color.DarkRed;
            buttonKonfirmasiPembayaran.Location = new Point(32, 154);
            buttonKonfirmasiPembayaran.Name = "buttonKonfirmasiPembayaran";
            buttonKonfirmasiPembayaran.Size = new Size(248, 63);
            buttonKonfirmasiPembayaran.TabIndex = 0;
            buttonKonfirmasiPembayaran.Text = "Konfirmasi Pembayaran";
            buttonKonfirmasiPembayaran.UseVisualStyleBackColor = false;
            buttonKonfirmasiPembayaran.Click += buttonKonfirmasiPembayaran_Click;
            // 
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 553);
            Controls.Add(panelMenuKasir);
            Name = "Kasir";
            Text = "Kasir";
            Load += Kasir_Load;
            panelMenuKasir.ResumeLayout(false);
            panelMenuKasir.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuKasir;
        private Button buttonKonfirmasiPembayaran;
        private Button buttonPrintStruk;
        private Button buttonLogoutKasir;
        private Label label1;
        private TextBox textBoxStatusPesanan;
        private TextBox textBoxMetodePembayaran;
        private TextBox textBoxHarga;
        private TextBox textBoxJumlah;
        private TextBox textBoxMenu;
        private TextBox textBoxTenant;
        private TextBox textBoxNoAntrian;
        private Label labelStatus;
        private Label labelMetodePembayaran;
        private Label labelHarga;
        private Label labelQTY;
        private Label labelNamaMenu;
        private Label labelTenant;
        private Label labelNoAntrian;
        private ListView listView1;
    }
}