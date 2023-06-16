namespace GUI_Implementation
{
    partial class Tenant
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
            panel2 = new Panel();
            buttonInsert = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonLogoutKasir = new Button();
            label1 = new Label();
            buttonMembuatMenu = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonLogoutKasir);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonMembuatMenu);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 557);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonInsert);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 529);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(44, 188);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(168, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 130);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 292);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 9;
            label7.Text = "Rp.";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(168, 332);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(401, 106);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 332);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 4;
            label6.Text = "Deskripsi Menu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 289);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 3;
            label5.Text = "Harga Menu :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 135);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 2;
            label4.Text = "Image Menu :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 79);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 1;
            label3.Text = "Nama Menu :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 18);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 0;
            label2.Text = "Input Menu :";
            label2.Click += label2_Click;
            // 
            // buttonLogoutKasir
            // 
            buttonLogoutKasir.BackColor = Color.White;
            buttonLogoutKasir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogoutKasir.ForeColor = Color.DarkRed;
            buttonLogoutKasir.Location = new Point(32, 480);
            buttonLogoutKasir.Name = "buttonLogoutKasir";
            buttonLogoutKasir.Size = new Size(116, 41);
            buttonLogoutKasir.TabIndex = 4;
            buttonLogoutKasir.Text = "Logout";
            buttonLogoutKasir.UseVisualStyleBackColor = false;
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
            label1.TabIndex = 3;
            label1.Text = "Dashboard Kasir";
            label1.Click += label1_Click;
            // 
            // buttonMembuatMenu
            // 
            buttonMembuatMenu.BackColor = Color.White;
            buttonMembuatMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMembuatMenu.ForeColor = Color.DarkRed;
            buttonMembuatMenu.Location = new Point(30, 123);
            buttonMembuatMenu.Name = "buttonMembuatMenu";
            buttonMembuatMenu.Size = new Size(248, 63);
            buttonMembuatMenu.TabIndex = 2;
            buttonMembuatMenu.Text = "Buat Menu";
            buttonMembuatMenu.UseVisualStyleBackColor = false;
            buttonMembuatMenu.Click += buttonKonfirmasiPembayaran_Click;
            // 
            // button1
            // 
            button1.Location = new Point(265, 456);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 12;
            button1.Text = "Add Menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // Tenant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Name = "Tenant";
            Text = "Tenant";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonMembuatMenu;
        private Button buttonLogoutKasir;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label6;
        private Button buttonInsert;
        private Button button1;
    }
}