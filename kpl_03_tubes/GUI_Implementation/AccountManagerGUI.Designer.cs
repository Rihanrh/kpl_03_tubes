namespace GUI_Implementation
{
    partial class AccountManagerGUI
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
            startScreenPanel = new Panel();
            endButton = new Button();
            loginButton = new Button();
            registrasiButton = new Button();
            label1 = new Label();
            registrationPanel = new Panel();
            loginPanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            startScreenPanel.SuspendLayout();
            registrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startScreenPanel
            // 
            startScreenPanel.Controls.Add(endButton);
            startScreenPanel.Controls.Add(loginButton);
            startScreenPanel.Controls.Add(registrasiButton);
            startScreenPanel.Controls.Add(label1);
            startScreenPanel.Location = new Point(0, 1);
            startScreenPanel.Name = "startScreenPanel";
            startScreenPanel.Size = new Size(784, 559);
            startScreenPanel.TabIndex = 0;
            // 
            // endButton
            // 
            endButton.Location = new Point(325, 371);
            endButton.Name = "endButton";
            endButton.Size = new Size(75, 23);
            endButton.TabIndex = 3;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(325, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // registrasiButton
            // 
            registrasiButton.Location = new Point(325, 245);
            registrasiButton.Name = "registrasiButton";
            registrasiButton.Size = new Size(75, 23);
            registrasiButton.TabIndex = 1;
            registrasiButton.Text = "Registrasi";
            registrasiButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(264, 155);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // registrationPanel
            // 
            registrationPanel.Controls.Add(label8);
            registrationPanel.Controls.Add(label7);
            registrationPanel.Controls.Add(label6);
            registrationPanel.Controls.Add(label5);
            registrationPanel.Controls.Add(textBox2);
            registrationPanel.Controls.Add(textBox1);
            registrationPanel.Controls.Add(label4);
            registrationPanel.Controls.Add(label3);
            registrationPanel.Controls.Add(label2);
            registrationPanel.Location = new Point(0, 0);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(784, 559);
            registrationPanel.TabIndex = 4;
            // 
            // loginPanel
            // 
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(784, 559);
            loginPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 139);
            label2.Name = "label2";
            label2.Size = new Size(130, 37);
            label2.TabIndex = 1;
            label2.Text = "Registrasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 218);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 287);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 215);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 284);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 7;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(302, 241);
            label7.Name = "label7";
            label7.Size = new Size(115, 11);
            label7.TabIndex = 8;
            label7.Text = "*maks 20 huruf, tidak ada spasi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(302, 310);
            label8.Name = "label8";
            label8.Size = new Size(115, 11);
            label8.TabIndex = 9;
            label8.Text = "*maks 20 huruf, tidak ada spasi";
            // 
            // AccountManagerGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(registrationPanel);
            Controls.Add(loginPanel);
            Controls.Add(startScreenPanel);
            Name = "AccountManagerGUI";
            Text = "Form1";
            startScreenPanel.ResumeLayout(false);
            startScreenPanel.PerformLayout();
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel startScreenPanel;
        private Button endButton;
        private Button loginButton;
        private Button registrasiButton;
        private Label label1;
        private Panel registrationPanel;
        private Panel loginPanel;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
    }
}