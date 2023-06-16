namespace GUI_Implementation
{
    partial class PilihMenu
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
            listBox1 = new ListBox();
            labelStatus = new Label();
            buttonPilih = new Button();
            buttonSelesai = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 28);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 0;
            label1.Text = "Pilih Menu";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(156, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 204);
            listBox1.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(188, 332);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(94, 38);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status";
            labelStatus.Click += label2_Click;
            // 
            // buttonPilih
            // 
            buttonPilih.Location = new Point(234, 399);
            buttonPilih.Name = "buttonPilih";
            buttonPilih.Size = new Size(94, 29);
            buttonPilih.TabIndex = 3;
            buttonPilih.Text = "Pilih";
            buttonPilih.UseVisualStyleBackColor = true;
            buttonPilih.Click += buttonPilih_Click;
            // 
            // buttonSelesai
            // 
            buttonSelesai.Location = new Point(449, 399);
            buttonSelesai.Name = "buttonSelesai";
            buttonSelesai.Size = new Size(94, 29);
            buttonSelesai.TabIndex = 4;
            buttonSelesai.Text = "Selesai";
            buttonSelesai.UseVisualStyleBackColor = true;
            buttonSelesai.Click += buttonSelesai_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(432, 208);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(239, 104);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // PilihMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(782, 553);
            Controls.Add(listBox2);
            Controls.Add(buttonSelesai);
            Controls.Add(buttonPilih);
            Controls.Add(labelStatus);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "PilihMenu";
            Text = "PilihMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label labelStatus;
        private Button buttonPilih;
        private Button buttonSelesai;
        private ListBox listBox2;
    }
}