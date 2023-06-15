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
            buttonKonfirmasiPembayaran = new Button();
            buttonPrintStruk = new Button();
            buttonLogoutKasir = new Button();
            label1 = new Label();
            panelLandingKasir = new Panel();
            panelMenuKasir.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuKasir
            // 
            panelMenuKasir.BackColor = Color.DarkRed;
            panelMenuKasir.Controls.Add(label1);
            panelMenuKasir.Controls.Add(buttonLogoutKasir);
            panelMenuKasir.Controls.Add(buttonPrintStruk);
            panelMenuKasir.Controls.Add(buttonKonfirmasiPembayaran);
            panelMenuKasir.Location = new Point(0, 1);
            panelMenuKasir.Name = "panelMenuKasir";
            panelMenuKasir.Size = new Size(308, 552);
            panelMenuKasir.TabIndex = 0;
            panelMenuKasir.Paint += panelMenuKasir_Paint;
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
            // panelLandingKasir
            // 
            panelLandingKasir.BackColor = Color.White;
            panelLandingKasir.Location = new Point(308, 1);
            panelLandingKasir.Name = "panelLandingKasir";
            panelLandingKasir.Size = new Size(474, 554);
            panelLandingKasir.TabIndex = 1;
            panelLandingKasir.Paint += panelLandingKasir_Paint;
            // 
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panelLandingKasir);
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
        private Panel panelLandingKasir;
    }
}