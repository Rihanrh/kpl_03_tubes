namespace GUI_Implementation
{
    partial class TenantMengubahStatusPesanan
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
            panel1 = new Panel();
            buttonUbahStatusPesanan = new Button();
            textBoxMetodePembayaran = new TextBox();
            textBoxHarga = new TextBox();
            textBoxJumlah = new TextBox();
            textBoxMenu = new TextBox();
            textBoxNoAntrian = new TextBox();
            comboBox1 = new ComboBox();
            labelStatusPesanan = new Label();
            labelMetodePembayaran = new Label();
            labelHarga = new Label();
            labelJumlah = new Label();
            labelnamaMenu = new Label();
            labelNoAntrian = new Label();
            labelJudulStatusPesanan = new Label();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(buttonUbahStatusPesanan);
            panel1.Controls.Add(textBoxMetodePembayaran);
            panel1.Controls.Add(textBoxHarga);
            panel1.Controls.Add(textBoxJumlah);
            panel1.Controls.Add(textBoxMenu);
            panel1.Controls.Add(textBoxNoAntrian);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(labelStatusPesanan);
            panel1.Controls.Add(labelMetodePembayaran);
            panel1.Controls.Add(labelHarga);
            panel1.Controls.Add(labelJumlah);
            panel1.Controls.Add(labelnamaMenu);
            panel1.Controls.Add(labelNoAntrian);
            panel1.Controls.Add(labelJudulStatusPesanan);
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 551);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonUbahStatusPesanan
            // 
            buttonUbahStatusPesanan.BackColor = Color.White;
            buttonUbahStatusPesanan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUbahStatusPesanan.ForeColor = Color.DarkRed;
            buttonUbahStatusPesanan.Location = new Point(35, 469);
            buttonUbahStatusPesanan.Name = "buttonUbahStatusPesanan";
            buttonUbahStatusPesanan.Size = new Size(268, 54);
            buttonUbahStatusPesanan.TabIndex = 14;
            buttonUbahStatusPesanan.Text = "Ubah Status Pesanan";
            buttonUbahStatusPesanan.UseVisualStyleBackColor = false;
            buttonUbahStatusPesanan.Click += buttonUbahStatusPesanan_Click;
            // 
            // textBoxMetodePembayaran
            // 
            textBoxMetodePembayaran.Location = new Point(272, 346);
            textBoxMetodePembayaran.Name = "textBoxMetodePembayaran";
            textBoxMetodePembayaran.Size = new Size(165, 27);
            textBoxMetodePembayaran.TabIndex = 13;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(272, 278);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(165, 27);
            textBoxHarga.TabIndex = 12;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(272, 213);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(165, 27);
            textBoxJumlah.TabIndex = 11;
            // 
            // textBoxMenu
            // 
            textBoxMenu.Location = new Point(272, 152);
            textBoxMenu.Name = "textBoxMenu";
            textBoxMenu.Size = new Size(165, 27);
            textBoxMenu.TabIndex = 10;
            // 
            // textBoxNoAntrian
            // 
            textBoxNoAntrian.Location = new Point(272, 91);
            textBoxNoAntrian.Name = "textBoxNoAntrian";
            textBoxNoAntrian.Size = new Size(165, 27);
            textBoxNoAntrian.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Menunggu konfirmasi pembayaran", "Pesanan sedang disiapkan", "Pesanan sudah selesai" });
            comboBox1.Location = new Point(272, 413);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelStatusPesanan
            // 
            labelStatusPesanan.AutoSize = true;
            labelStatusPesanan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatusPesanan.ForeColor = Color.White;
            labelStatusPesanan.Location = new Point(36, 413);
            labelStatusPesanan.Name = "labelStatusPesanan";
            labelStatusPesanan.Size = new Size(159, 28);
            labelStatusPesanan.TabIndex = 7;
            labelStatusPesanan.Text = "Status Pesanan :";
            // 
            // labelMetodePembayaran
            // 
            labelMetodePembayaran.AutoSize = true;
            labelMetodePembayaran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMetodePembayaran.ForeColor = Color.White;
            labelMetodePembayaran.Location = new Point(36, 342);
            labelMetodePembayaran.Name = "labelMetodePembayaran";
            labelMetodePembayaran.Size = new Size(211, 28);
            labelMetodePembayaran.TabIndex = 6;
            labelMetodePembayaran.Text = "Metode Pembayaran :";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(36, 277);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(77, 28);
            labelHarga.TabIndex = 5;
            labelHarga.Text = "Harga :";
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelJumlah.ForeColor = Color.White;
            labelJumlah.Location = new Point(35, 213);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(88, 28);
            labelJumlah.TabIndex = 4;
            labelJumlah.Text = "Jumlah :";
            // 
            // labelnamaMenu
            // 
            labelnamaMenu.AutoSize = true;
            labelnamaMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelnamaMenu.ForeColor = Color.White;
            labelnamaMenu.Location = new Point(36, 152);
            labelnamaMenu.Name = "labelnamaMenu";
            labelnamaMenu.Size = new Size(76, 28);
            labelnamaMenu.TabIndex = 3;
            labelnamaMenu.Text = "Menu :";
            // 
            // labelNoAntrian
            // 
            labelNoAntrian.AutoSize = true;
            labelNoAntrian.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoAntrian.ForeColor = Color.White;
            labelNoAntrian.Location = new Point(35, 91);
            labelNoAntrian.Name = "labelNoAntrian";
            labelNoAntrian.Size = new Size(122, 28);
            labelNoAntrian.TabIndex = 2;
            labelNoAntrian.Text = "No Antrian :";
            labelNoAntrian.Click += labelNoAntrian_Click;
            // 
            // labelJudulStatusPesanan
            // 
            labelJudulStatusPesanan.AutoSize = true;
            labelJudulStatusPesanan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudulStatusPesanan.ForeColor = Color.White;
            labelJudulStatusPesanan.Location = new Point(118, 8);
            labelJudulStatusPesanan.Name = "labelJudulStatusPesanan";
            labelJudulStatusPesanan.Size = new Size(295, 31);
            labelJudulStatusPesanan.TabIndex = 1;
            labelJudulStatusPesanan.Text = "Mengubah Status Pesanan";
            labelJudulStatusPesanan.Click += labelJudulStatusPesanan_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(564, 11);
            listView1.Name = "listView1";
            listView1.Size = new Size(779, 512);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // TenantMengubahStatusPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 553);
            Controls.Add(panel1);
            Name = "TenantMengubahStatusPesanan";
            Text = "Mengubah Status Pesanan - Tenant";
            Load += TenantMengubahStatusPesanan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelNoAntrian;
        private Label labelJudulStatusPesanan;
        private ListView listView1;
        private ComboBox comboBox1;
        private Label labelStatusPesanan;
        private Label labelMetodePembayaran;
        private Label labelHarga;
        private Label labelJumlah;
        private Label labelnamaMenu;
        private TextBox textBoxHarga;
        private TextBox textBoxJumlah;
        private TextBox textBoxMenu;
        private TextBox textBoxNoAntrian;
        private Button buttonUbahStatusPesanan;
        private TextBox textBoxMetodePembayaran;
    }
}