namespace GUI_Implementation
{
    partial class FormCheckout
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
            label1 = new Label();
            listBoxMenu = new ListBox();
            listBoxPesanan = new ListBox();
            buttonPilih = new Button();
            buttonHapus = new Button();
            buttonCheckout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(292, 32);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            label1.Click += label1_Click;
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 20;
            listBoxMenu.Location = new Point(78, 134);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(203, 204);
            listBoxMenu.TabIndex = 1;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // listBoxPesanan
            // 
            listBoxPesanan.FormattingEnabled = true;
            listBoxPesanan.ItemHeight = 20;
            listBoxPesanan.Location = new Point(376, 234);
            listBoxPesanan.Name = "listBoxPesanan";
            listBoxPesanan.Size = new Size(245, 104);
            listBoxPesanan.TabIndex = 2;
            listBoxPesanan.SelectedIndexChanged += listBoxPesanan_SelectedIndexChanged;
            // 
            // buttonPilih
            // 
            buttonPilih.Location = new Point(187, 427);
            buttonPilih.Name = "buttonPilih";
            buttonPilih.Size = new Size(94, 29);
            buttonPilih.TabIndex = 3;
            buttonPilih.Text = "Pilih";
            buttonPilih.UseVisualStyleBackColor = true;
            buttonPilih.Click += buttonPilih_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(326, 427);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.RightToLeft = RightToLeft.No;
            buttonHapus.Size = new Size(94, 29);
            buttonHapus.TabIndex = 4;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += button2_Click;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(467, 427);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(94, 29);
            buttonCheckout.TabIndex = 5;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // FormCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonCheckout);
            Controls.Add(buttonHapus);
            Controls.Add(buttonPilih);
            Controls.Add(listBoxPesanan);
            Controls.Add(listBoxMenu);
            Controls.Add(label1);
            Name = "FormCheckout";
            Text = "FormCheckout";
            Load += FormCheckout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxMenu;
        private ListBox listBoxPesanan;
        private Button buttonPilih;
        private Button buttonHapus;
        private Button buttonCheckout;
    }
}