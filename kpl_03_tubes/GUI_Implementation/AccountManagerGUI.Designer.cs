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
            regisPanel = new Panel();
            regisBack = new Button();
            regisSubmit = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            passwordRegisBox = new TextBox();
            usernameRegisBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            regisTarget = new Label();
            regisChoosePanel = new Panel();
            regisChooseBack = new Button();
            label25 = new Label();
            chooseRegisterKasir = new Button();
            chooseRegisterTenant = new Button();
            chooseRegisterPembeli = new Button();
            label24 = new Label();
            loginChoosePanel = new Panel();
            loginChooseBack = new Button();
            label2 = new Label();
            chooseLoginKasir = new Button();
            chooseLoginTenant = new Button();
            chooseLoginPembeli = new Button();
            label10 = new Label();
            loginPanel = new Panel();
            loginBack = new Button();
            loginSubmit = new Button();
            passwordLoginBox = new TextBox();
            usernameLoginBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            loginTarget = new Label();
            startScreenPanel.SuspendLayout();
            regisPanel.SuspendLayout();
            regisChoosePanel.SuspendLayout();
            loginChoosePanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startScreenPanel
            // 
            startScreenPanel.Controls.Add(endButton);
            startScreenPanel.Controls.Add(loginButton);
            startScreenPanel.Controls.Add(registrasiButton);
            startScreenPanel.Controls.Add(label1);
            startScreenPanel.Location = new Point(0, 0);
            startScreenPanel.Margin = new Padding(3, 4, 3, 4);
            startScreenPanel.Name = "startScreenPanel";
            startScreenPanel.Size = new Size(896, 745);
            startScreenPanel.TabIndex = 0;
            // 
            // endButton
            // 
            endButton.Location = new Point(371, 495);
            endButton.Margin = new Padding(3, 4, 3, 4);
            endButton.Name = "endButton";
            endButton.Size = new Size(86, 31);
            endButton.TabIndex = 3;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += endButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(371, 407);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registrasiButton
            // 
            registrasiButton.Location = new Point(371, 327);
            registrasiButton.Margin = new Padding(3, 4, 3, 4);
            registrasiButton.Name = "registrasiButton";
            registrasiButton.Size = new Size(86, 31);
            registrasiButton.TabIndex = 1;
            registrasiButton.Text = "Registrasi";
            registrasiButton.UseVisualStyleBackColor = true;
            registrasiButton.Click += registrasiButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 207);
            label1.Name = "label1";
            label1.Size = new Size(257, 46);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // regisPanel
            // 
            regisPanel.Controls.Add(regisBack);
            regisPanel.Controls.Add(regisSubmit);
            regisPanel.Controls.Add(label8);
            regisPanel.Controls.Add(label7);
            regisPanel.Controls.Add(label6);
            regisPanel.Controls.Add(label5);
            regisPanel.Controls.Add(passwordRegisBox);
            regisPanel.Controls.Add(usernameRegisBox);
            regisPanel.Controls.Add(label4);
            regisPanel.Controls.Add(label3);
            regisPanel.Controls.Add(regisTarget);
            regisPanel.Location = new Point(0, 0);
            regisPanel.Margin = new Padding(3, 4, 3, 4);
            regisPanel.Name = "regisPanel";
            regisPanel.Size = new Size(896, 745);
            regisPanel.TabIndex = 4;
            // 
            // regisBack
            // 
            regisBack.Location = new Point(371, 548);
            regisBack.Margin = new Padding(3, 4, 3, 4);
            regisBack.Name = "regisBack";
            regisBack.Size = new Size(86, 31);
            regisBack.TabIndex = 11;
            regisBack.Text = "Back";
            regisBack.UseVisualStyleBackColor = true;
            regisBack.Click += regisBack_Click;
            // 
            // regisSubmit
            // 
            regisSubmit.Location = new Point(371, 483);
            regisSubmit.Margin = new Padding(3, 4, 3, 4);
            regisSubmit.Name = "regisSubmit";
            regisSubmit.Size = new Size(86, 31);
            regisSubmit.TabIndex = 10;
            regisSubmit.Text = "Submit";
            regisSubmit.UseVisualStyleBackColor = true;
            regisSubmit.Click += regisSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(345, 413);
            label8.Name = "label8";
            label8.Size = new Size(151, 12);
            label8.TabIndex = 9;
            label8.Text = "*maks 16 karakter, tidak ada spasi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(345, 321);
            label7.Name = "label7";
            label7.Size = new Size(151, 12);
            label7.TabIndex = 8;
            label7.Text = "*maks 20 karakter, tidak ada spasi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 379);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 7;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 287);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // passwordRegisBox
            // 
            passwordRegisBox.Location = new Point(345, 379);
            passwordRegisBox.Margin = new Padding(3, 4, 3, 4);
            passwordRegisBox.Name = "passwordRegisBox";
            passwordRegisBox.Size = new Size(148, 27);
            passwordRegisBox.TabIndex = 5;
            // 
            // usernameRegisBox
            // 
            usernameRegisBox.Location = new Point(345, 287);
            usernameRegisBox.Margin = new Padding(3, 4, 3, 4);
            usernameRegisBox.Name = "usernameRegisBox";
            usernameRegisBox.Size = new Size(148, 27);
            usernameRegisBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 383);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 291);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // regisTarget
            // 
            regisTarget.AutoSize = true;
            regisTarget.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            regisTarget.Location = new Point(272, 180);
            regisTarget.Name = "regisTarget";
            regisTarget.Size = new Size(185, 46);
            regisTarget.TabIndex = 1;
            regisTarget.Text = "regisTarget";
            // 
            // regisChoosePanel
            // 
            regisChoosePanel.Controls.Add(regisChooseBack);
            regisChoosePanel.Controls.Add(label25);
            regisChoosePanel.Controls.Add(chooseRegisterKasir);
            regisChoosePanel.Controls.Add(chooseRegisterTenant);
            regisChoosePanel.Controls.Add(chooseRegisterPembeli);
            regisChoosePanel.Controls.Add(label24);
            regisChoosePanel.Location = new Point(0, 0);
            regisChoosePanel.Margin = new Padding(3, 4, 3, 4);
            regisChoosePanel.Name = "regisChoosePanel";
            regisChoosePanel.Size = new Size(896, 745);
            regisChoosePanel.TabIndex = 4;
            // 
            // regisChooseBack
            // 
            regisChooseBack.Location = new Point(371, 569);
            regisChooseBack.Margin = new Padding(3, 4, 3, 4);
            regisChooseBack.Name = "regisChooseBack";
            regisChooseBack.Size = new Size(86, 31);
            regisChooseBack.TabIndex = 5;
            regisChooseBack.Text = "Back";
            regisChooseBack.UseVisualStyleBackColor = true;
            regisChooseBack.Click += regisChooseBack_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(382, 291);
            label25.Name = "label25";
            label25.Size = new Size(74, 20);
            label25.TabIndex = 4;
            label25.Text = "Pilih Akun";
            // 
            // chooseRegisterKasir
            // 
            chooseRegisterKasir.Location = new Point(371, 495);
            chooseRegisterKasir.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterKasir.Name = "chooseRegisterKasir";
            chooseRegisterKasir.Size = new Size(86, 31);
            chooseRegisterKasir.TabIndex = 3;
            chooseRegisterKasir.Text = "Kasir";
            chooseRegisterKasir.UseVisualStyleBackColor = true;
            chooseRegisterKasir.Click += chooseRegisterKasir_Click;
            // 
            // chooseRegisterTenant
            // 
            chooseRegisterTenant.Location = new Point(373, 417);
            chooseRegisterTenant.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterTenant.Name = "chooseRegisterTenant";
            chooseRegisterTenant.Size = new Size(86, 31);
            chooseRegisterTenant.TabIndex = 2;
            chooseRegisterTenant.Text = "Tenant";
            chooseRegisterTenant.UseVisualStyleBackColor = true;
            chooseRegisterTenant.Click += chooseRegisterTenant_Click;
            // 
            // chooseRegisterPembeli
            // 
            chooseRegisterPembeli.Location = new Point(371, 340);
            chooseRegisterPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterPembeli.Name = "chooseRegisterPembeli";
            chooseRegisterPembeli.Size = new Size(86, 31);
            chooseRegisterPembeli.TabIndex = 1;
            chooseRegisterPembeli.Text = "Pembeli";
            chooseRegisterPembeli.UseVisualStyleBackColor = true;
            chooseRegisterPembeli.Click += chooseRegisterPembeli_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(358, 208);
            label24.Name = "label24";
            label24.Size = new Size(141, 46);
            label24.TabIndex = 0;
            label24.Text = "Register";
            // 
            // loginChoosePanel
            // 
            loginChoosePanel.Controls.Add(loginChooseBack);
            loginChoosePanel.Controls.Add(label2);
            loginChoosePanel.Controls.Add(chooseLoginKasir);
            loginChoosePanel.Controls.Add(chooseLoginTenant);
            loginChoosePanel.Controls.Add(chooseLoginPembeli);
            loginChoosePanel.Controls.Add(label10);
            loginChoosePanel.Location = new Point(0, 2);
            loginChoosePanel.Margin = new Padding(3, 4, 3, 4);
            loginChoosePanel.Name = "loginChoosePanel";
            loginChoosePanel.Size = new Size(896, 745);
            loginChoosePanel.TabIndex = 6;
            // 
            // loginChooseBack
            // 
            loginChooseBack.Location = new Point(371, 569);
            loginChooseBack.Margin = new Padding(3, 4, 3, 4);
            loginChooseBack.Name = "loginChooseBack";
            loginChooseBack.Size = new Size(86, 31);
            loginChooseBack.TabIndex = 5;
            loginChooseBack.Text = "Back";
            loginChooseBack.UseVisualStyleBackColor = true;
            loginChooseBack.Click += loginChooseBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 291);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Pilih Akun";
            // 
            // chooseLoginKasir
            // 
            chooseLoginKasir.Location = new Point(371, 495);
            chooseLoginKasir.Margin = new Padding(3, 4, 3, 4);
            chooseLoginKasir.Name = "chooseLoginKasir";
            chooseLoginKasir.Size = new Size(86, 31);
            chooseLoginKasir.TabIndex = 3;
            chooseLoginKasir.Text = "Kasir";
            chooseLoginKasir.UseVisualStyleBackColor = true;
            chooseLoginKasir.Click += chooseLoginKasir_Click;
            // 
            // chooseLoginTenant
            // 
            chooseLoginTenant.Location = new Point(373, 417);
            chooseLoginTenant.Margin = new Padding(3, 4, 3, 4);
            chooseLoginTenant.Name = "chooseLoginTenant";
            chooseLoginTenant.Size = new Size(86, 31);
            chooseLoginTenant.TabIndex = 2;
            chooseLoginTenant.Text = "Tenant";
            chooseLoginTenant.UseVisualStyleBackColor = true;
            chooseLoginTenant.Click += chooseLoginTenant_Click;
            // 
            // chooseLoginPembeli
            // 
            chooseLoginPembeli.Location = new Point(371, 340);
            chooseLoginPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseLoginPembeli.Name = "chooseLoginPembeli";
            chooseLoginPembeli.Size = new Size(86, 31);
            chooseLoginPembeli.TabIndex = 1;
            chooseLoginPembeli.Text = "Pembeli";
            chooseLoginPembeli.UseVisualStyleBackColor = true;
            chooseLoginPembeli.Click += chooseLoginPembeli_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(364, 208);
            label10.Name = "label10";
            label10.Size = new Size(103, 46);
            label10.TabIndex = 0;
            label10.Text = "Login";
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginBack);
            loginPanel.Controls.Add(loginSubmit);
            loginPanel.Controls.Add(passwordLoginBox);
            loginPanel.Controls.Add(usernameLoginBox);
            loginPanel.Controls.Add(label14);
            loginPanel.Controls.Add(label15);
            loginPanel.Controls.Add(loginTarget);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(896, 745);
            loginPanel.TabIndex = 7;
            // 
            // loginBack
            // 
            loginBack.Location = new Point(371, 548);
            loginBack.Margin = new Padding(3, 4, 3, 4);
            loginBack.Name = "loginBack";
            loginBack.Size = new Size(86, 31);
            loginBack.TabIndex = 11;
            loginBack.Text = "Back";
            loginBack.UseVisualStyleBackColor = true;
            loginBack.Click += loginBack_Click;
            // 
            // loginSubmit
            // 
            loginSubmit.Location = new Point(371, 483);
            loginSubmit.Margin = new Padding(3, 4, 3, 4);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(86, 31);
            loginSubmit.TabIndex = 10;
            loginSubmit.Text = "Submit";
            loginSubmit.UseVisualStyleBackColor = true;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // passwordLoginBox
            // 
            passwordLoginBox.Location = new Point(345, 379);
            passwordLoginBox.Margin = new Padding(3, 4, 3, 4);
            passwordLoginBox.Name = "passwordLoginBox";
            passwordLoginBox.Size = new Size(148, 27);
            passwordLoginBox.TabIndex = 5;
            // 
            // usernameLoginBox
            // 
            usernameLoginBox.Location = new Point(345, 287);
            usernameLoginBox.Margin = new Padding(3, 4, 3, 4);
            usernameLoginBox.Name = "usernameLoginBox";
            usernameLoginBox.Size = new Size(148, 27);
            usernameLoginBox.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(261, 383);
            label14.Name = "label14";
            label14.Size = new Size(73, 20);
            label14.TabIndex = 3;
            label14.Text = "Password:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(261, 291);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 2;
            label15.Text = "Username:";
            // 
            // loginTarget
            // 
            loginTarget.AutoSize = true;
            loginTarget.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loginTarget.Location = new Point(272, 180);
            loginTarget.Name = "loginTarget";
            loginTarget.Size = new Size(188, 46);
            loginTarget.TabIndex = 1;
            loginTarget.Text = "loginTarget";
            // 
            // AccountManagerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(loginPanel);
            Controls.Add(loginChoosePanel);
            Controls.Add(regisPanel);
            Controls.Add(regisChoosePanel);
            Controls.Add(startScreenPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManagerGUI";
            Text = "Form1";
            startScreenPanel.ResumeLayout(false);
            startScreenPanel.PerformLayout();
            regisPanel.ResumeLayout(false);
            regisPanel.PerformLayout();
            regisChoosePanel.ResumeLayout(false);
            regisChoosePanel.PerformLayout();
            loginChoosePanel.ResumeLayout(false);
            loginChoosePanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel startScreenPanel;
        private Button endButton;
        private Button loginButton;
        private Button registrasiButton;
        private Label label1;
        private Panel regisPanel;
        private Label label6;
        private Label label5;
        private TextBox passwordRegisBox;
        private TextBox usernameRegisBox;
        private Label label4;
        private Label label3;
        private Label regisTarget;
        private Label label8;
        private Label label7;
        private Button regisBack;
        private Button regisSubmit;
        private Panel regisChoosePanel;
        private Button regisChooseBack;
        private Label label25;
        private Button chooseRegisterKasir;
        private Button chooseRegisterTenant;
        private Button chooseRegisterPembeli;
        private Label label24;
        private Panel loginChoosePanel;
        private Button loginChooseBack;
        private Label label2;
        private Button chooseLoginKasir;
        private Button chooseLoginTenant;
        private Button chooseLoginPembeli;
        private Label label10;
        private Panel loginPanel;
        private Button loginBack;
        private Button loginSubmit;
        private TextBox passwordLoginBox;
        private TextBox usernameLoginBox;
        private Label label14;
        private Label label15;
        private Label loginTarget;
    }
}