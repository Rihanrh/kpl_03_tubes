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
            pictureBox1 = new PictureBox();
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
            pictureBox2 = new PictureBox();
            regisChoosePanel = new Panel();
            label12 = new Label();
            regisChooseBack = new Button();
            chooseRegisterKasir = new Button();
            chooseRegisterPembeli = new Button();
            chooseRegisterTenant = new Button();
            pictureBox3 = new PictureBox();
            loginChoosePanel = new Panel();
            loginChooseBack = new Button();
            chooseLoginKasir = new Button();
            chooseLoginTenant = new Button();
            chooseLoginPembeli = new Button();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            loginPanel = new Panel();
            loginBack = new Button();
            loginSubmit = new Button();
            passwordLoginBox = new TextBox();
            usernameLoginBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            loginTarget = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            startScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            regisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            regisChoosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            loginChoosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // startScreenPanel
            // 
            startScreenPanel.BackColor = SystemColors.Control;
            startScreenPanel.Controls.Add(endButton);
            startScreenPanel.Controls.Add(loginButton);
            startScreenPanel.Controls.Add(registrasiButton);
            startScreenPanel.Controls.Add(label1);
            startScreenPanel.Controls.Add(pictureBox1);
            startScreenPanel.Location = new Point(0, 0);
            startScreenPanel.Margin = new Padding(3, 4, 3, 4);
            startScreenPanel.Name = "startScreenPanel";
            startScreenPanel.Size = new Size(785, 556);
            startScreenPanel.TabIndex = 0;
            // 
            // endButton
            // 
            endButton.BackColor = Color.White;
            endButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            endButton.ForeColor = Color.FromArgb(175, 35, 40);
            endButton.Location = new Point(216, 402);
            endButton.Margin = new Padding(3, 4, 3, 4);
            endButton.Name = "endButton";
            endButton.Size = new Size(350, 58);
            endButton.TabIndex = 3;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(175, 35, 40);
            loginButton.Location = new Point(216, 316);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(350, 58);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registrasiButton
            // 
            registrasiButton.BackColor = Color.White;
            registrasiButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrasiButton.ForeColor = Color.FromArgb(175, 35, 40);
            registrasiButton.Location = new Point(216, 224);
            registrasiButton.Margin = new Padding(3, 4, 3, 4);
            registrasiButton.Name = "registrasiButton";
            registrasiButton.Size = new Size(350, 58);
            registrasiButton.TabIndex = 1;
            registrasiButton.Text = "Registrasi";
            registrasiButton.UseVisualStyleBackColor = false;
            registrasiButton.Click += registrasiButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(272, 79);
            label1.Name = "label1";
            label1.Size = new Size(242, 51);
            label1.TabIndex = 0;
            label1.Text = "Pilih Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Account_Selection;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 556);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            regisPanel.Controls.Add(pictureBox2);
            regisPanel.Location = new Point(0, 0);
            regisPanel.Margin = new Padding(3, 4, 3, 4);
            regisPanel.Name = "regisPanel";
            regisPanel.Size = new Size(785, 556);
            regisPanel.TabIndex = 4;
            // 
            // regisBack
            // 
            regisBack.BackColor = Color.White;
            regisBack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regisBack.ForeColor = Color.FromArgb(175, 35, 40);
            regisBack.Location = new Point(216, 447);
            regisBack.Margin = new Padding(3, 4, 3, 4);
            regisBack.Name = "regisBack";
            regisBack.Size = new Size(350, 58);
            regisBack.TabIndex = 11;
            regisBack.Text = "Back";
            regisBack.UseVisualStyleBackColor = false;
            regisBack.Click += regisBack_Click;
            // 
            // regisSubmit
            // 
            regisSubmit.BackColor = Color.White;
            regisSubmit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regisSubmit.ForeColor = Color.FromArgb(175, 35, 40);
            regisSubmit.Location = new Point(216, 357);
            regisSubmit.Margin = new Padding(3, 4, 3, 4);
            regisSubmit.Name = "regisSubmit";
            regisSubmit.Size = new Size(350, 58);
            regisSubmit.TabIndex = 10;
            regisSubmit.Text = "Submit";
            regisSubmit.UseVisualStyleBackColor = false;
            regisSubmit.Click += regisSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial Rounded MT Bold", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(175, 35, 40);
            label8.Location = new Point(263, 321);
            label8.Name = "label8";
            label8.Size = new Size(175, 11);
            label8.TabIndex = 9;
            label8.Text = "*maks 16 karakter, tidak ada spasi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial Rounded MT Bold", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(175, 35, 40);
            label7.Location = new Point(263, 229);
            label7.Name = "label7";
            label7.Size = new Size(175, 11);
            label7.TabIndex = 8;
            label7.Text = "*maks 20 karakter, tidak ada spasi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(175, 35, 40);
            label6.Location = new Point(537, 288);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 7;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(175, 35, 40);
            label5.Location = new Point(537, 198);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // passwordRegisBox
            // 
            passwordRegisBox.Location = new Point(263, 290);
            passwordRegisBox.Margin = new Padding(3, 4, 3, 4);
            passwordRegisBox.Name = "passwordRegisBox";
            passwordRegisBox.Size = new Size(260, 27);
            passwordRegisBox.TabIndex = 5;
            // 
            // usernameRegisBox
            // 
            usernameRegisBox.Location = new Point(263, 198);
            usernameRegisBox.Margin = new Padding(3, 4, 3, 4);
            usernameRegisBox.Name = "usernameRegisBox";
            usernameRegisBox.Size = new Size(260, 27);
            usernameRegisBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(175, 35, 40);
            label4.Location = new Point(179, 294);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(175, 35, 40);
            label3.Location = new Point(179, 202);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // regisTarget
            // 
            regisTarget.AutoSize = true;
            regisTarget.BackColor = Color.IndianRed;
            regisTarget.Font = new Font("Arial Rounded MT Bold", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            regisTarget.ForeColor = Color.White;
            regisTarget.Location = new Point(236, 96);
            regisTarget.Name = "regisTarget";
            regisTarget.Size = new Size(260, 49);
            regisTarget.TabIndex = 1;
            regisTarget.Text = "regisTarget";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Account_Selection;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(785, 556);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // regisChoosePanel
            // 
            regisChoosePanel.Controls.Add(label12);
            regisChoosePanel.Controls.Add(regisChooseBack);
            regisChoosePanel.Controls.Add(chooseRegisterKasir);
            regisChoosePanel.Controls.Add(chooseRegisterPembeli);
            regisChoosePanel.Controls.Add(chooseRegisterTenant);
            regisChoosePanel.Controls.Add(pictureBox3);
            regisChoosePanel.Location = new Point(0, 0);
            regisChoosePanel.Margin = new Padding(3, 4, 3, 4);
            regisChoosePanel.Name = "regisChoosePanel";
            regisChoosePanel.Size = new Size(785, 556);
            regisChoosePanel.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.IndianRed;
            label12.Font = new Font("Arial Rounded MT Bold", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(196, 96);
            label12.Name = "label12";
            label12.Size = new Size(407, 49);
            label12.TabIndex = 15;
            label12.Text = "Pilih Akun Register";
            // 
            // regisChooseBack
            // 
            regisChooseBack.BackColor = Color.White;
            regisChooseBack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regisChooseBack.ForeColor = Color.FromArgb(175, 35, 40);
            regisChooseBack.Location = new Point(216, 447);
            regisChooseBack.Margin = new Padding(3, 4, 3, 4);
            regisChooseBack.Name = "regisChooseBack";
            regisChooseBack.Size = new Size(350, 58);
            regisChooseBack.TabIndex = 5;
            regisChooseBack.Text = "Back";
            regisChooseBack.UseVisualStyleBackColor = false;
            regisChooseBack.Click += regisChooseBack_Click;
            // 
            // chooseRegisterKasir
            // 
            chooseRegisterKasir.BackColor = Color.White;
            chooseRegisterKasir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseRegisterKasir.ForeColor = Color.FromArgb(175, 35, 40);
            chooseRegisterKasir.Location = new Point(216, 357);
            chooseRegisterKasir.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterKasir.Name = "chooseRegisterKasir";
            chooseRegisterKasir.Size = new Size(350, 58);
            chooseRegisterKasir.TabIndex = 3;
            chooseRegisterKasir.Text = "Kasir";
            chooseRegisterKasir.UseVisualStyleBackColor = false;
            chooseRegisterKasir.Click += chooseRegisterKasir_Click;
            // 
            // chooseRegisterPembeli
            // 
            chooseRegisterPembeli.BackColor = Color.White;
            chooseRegisterPembeli.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseRegisterPembeli.ForeColor = Color.FromArgb(175, 35, 40);
            chooseRegisterPembeli.Location = new Point(216, 181);
            chooseRegisterPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterPembeli.Name = "chooseRegisterPembeli";
            chooseRegisterPembeli.Size = new Size(350, 58);
            chooseRegisterPembeli.TabIndex = 1;
            chooseRegisterPembeli.Text = "Pembeli";
            chooseRegisterPembeli.UseVisualStyleBackColor = false;
            chooseRegisterPembeli.Click += chooseRegisterPembeli_Click;
            // 
            // chooseRegisterTenant
            // 
            chooseRegisterTenant.BackColor = Color.White;
            chooseRegisterTenant.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseRegisterTenant.ForeColor = Color.FromArgb(175, 35, 40);
            chooseRegisterTenant.Location = new Point(215, 269);
            chooseRegisterTenant.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterTenant.Name = "chooseRegisterTenant";
            chooseRegisterTenant.Size = new Size(350, 58);
            chooseRegisterTenant.TabIndex = 2;
            chooseRegisterTenant.Text = "Tenant";
            chooseRegisterTenant.UseVisualStyleBackColor = false;
            chooseRegisterTenant.Click += chooseRegisterTenant_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Account_Selection;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(785, 556);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // loginChoosePanel
            // 
            loginChoosePanel.Controls.Add(loginChooseBack);
            loginChoosePanel.Controls.Add(chooseLoginKasir);
            loginChoosePanel.Controls.Add(chooseLoginTenant);
            loginChoosePanel.Controls.Add(chooseLoginPembeli);
            loginChoosePanel.Controls.Add(label10);
            loginChoosePanel.Controls.Add(pictureBox4);
            loginChoosePanel.Location = new Point(0, 0);
            loginChoosePanel.Margin = new Padding(3, 4, 3, 4);
            loginChoosePanel.Name = "loginChoosePanel";
            loginChoosePanel.Size = new Size(785, 556);
            loginChoosePanel.TabIndex = 6;
            // 
            // loginChooseBack
            // 
            loginChooseBack.BackColor = Color.White;
            loginChooseBack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginChooseBack.ForeColor = Color.FromArgb(175, 35, 40);
            loginChooseBack.Location = new Point(216, 447);
            loginChooseBack.Margin = new Padding(3, 4, 3, 4);
            loginChooseBack.Name = "loginChooseBack";
            loginChooseBack.Size = new Size(350, 58);
            loginChooseBack.TabIndex = 5;
            loginChooseBack.Text = "Back";
            loginChooseBack.UseVisualStyleBackColor = false;
            loginChooseBack.Click += loginChooseBack_Click;
            // 
            // chooseLoginKasir
            // 
            chooseLoginKasir.BackColor = Color.White;
            chooseLoginKasir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseLoginKasir.ForeColor = Color.FromArgb(175, 35, 40);
            chooseLoginKasir.Location = new Point(216, 357);
            chooseLoginKasir.Margin = new Padding(3, 4, 3, 4);
            chooseLoginKasir.Name = "chooseLoginKasir";
            chooseLoginKasir.Size = new Size(350, 58);
            chooseLoginKasir.TabIndex = 3;
            chooseLoginKasir.Text = "Kasir";
            chooseLoginKasir.UseVisualStyleBackColor = false;
            chooseLoginKasir.Click += chooseLoginKasir_Click;
            // 
            // chooseLoginTenant
            // 
            chooseLoginTenant.BackColor = Color.White;
            chooseLoginTenant.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseLoginTenant.ForeColor = Color.FromArgb(175, 35, 40);
            chooseLoginTenant.Location = new Point(215, 269);
            chooseLoginTenant.Margin = new Padding(3, 4, 3, 4);
            chooseLoginTenant.Name = "chooseLoginTenant";
            chooseLoginTenant.Size = new Size(350, 58);
            chooseLoginTenant.TabIndex = 2;
            chooseLoginTenant.Text = "Tenant";
            chooseLoginTenant.UseVisualStyleBackColor = false;
            chooseLoginTenant.Click += chooseLoginTenant_Click;
            // 
            // chooseLoginPembeli
            // 
            chooseLoginPembeli.BackColor = Color.White;
            chooseLoginPembeli.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chooseLoginPembeli.ForeColor = Color.FromArgb(175, 35, 40);
            chooseLoginPembeli.Location = new Point(216, 181);
            chooseLoginPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseLoginPembeli.Name = "chooseLoginPembeli";
            chooseLoginPembeli.Size = new Size(350, 58);
            chooseLoginPembeli.TabIndex = 1;
            chooseLoginPembeli.Text = "Pembeli";
            chooseLoginPembeli.UseVisualStyleBackColor = false;
            chooseLoginPembeli.Click += chooseLoginPembeli_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.IndianRed;
            label10.Font = new Font("Arial Rounded MT Bold", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(216, 96);
            label10.Name = "label10";
            label10.Size = new Size(346, 49);
            label10.TabIndex = 0;
            label10.Text = "Pilih Akun Login";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Account_Selection;
            pictureBox4.Location = new Point(-5, -5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(790, 561);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
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
            loginPanel.Controls.Add(pictureBox5);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(785, 556);
            loginPanel.TabIndex = 7;
            // 
            // loginBack
            // 
            loginBack.BackColor = Color.White;
            loginBack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginBack.ForeColor = Color.FromArgb(175, 35, 40);
            loginBack.Location = new Point(216, 447);
            loginBack.Margin = new Padding(3, 4, 3, 4);
            loginBack.Name = "loginBack";
            loginBack.Size = new Size(350, 58);
            loginBack.TabIndex = 11;
            loginBack.Text = "Back";
            loginBack.UseVisualStyleBackColor = false;
            loginBack.Click += loginBack_Click;
            // 
            // loginSubmit
            // 
            loginSubmit.BackColor = Color.White;
            loginSubmit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginSubmit.ForeColor = Color.FromArgb(175, 35, 40);
            loginSubmit.Location = new Point(216, 357);
            loginSubmit.Margin = new Padding(3, 4, 3, 4);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(350, 58);
            loginSubmit.TabIndex = 10;
            loginSubmit.Text = "Submit";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // passwordLoginBox
            // 
            passwordLoginBox.Location = new Point(263, 290);
            passwordLoginBox.Margin = new Padding(3, 4, 3, 4);
            passwordLoginBox.Name = "passwordLoginBox";
            passwordLoginBox.Size = new Size(260, 27);
            passwordLoginBox.TabIndex = 5;
            // 
            // usernameLoginBox
            // 
            usernameLoginBox.Location = new Point(263, 198);
            usernameLoginBox.Margin = new Padding(3, 4, 3, 4);
            usernameLoginBox.Name = "usernameLoginBox";
            usernameLoginBox.Size = new Size(260, 27);
            usernameLoginBox.TabIndex = 4;
            usernameLoginBox.TextChanged += usernameLoginBox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(175, 35, 40);
            label14.Location = new Point(179, 294);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 3;
            label14.Text = "Password:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(175, 35, 40);
            label15.Location = new Point(179, 202);
            label15.Name = "label15";
            label15.Size = new Size(78, 15);
            label15.TabIndex = 2;
            label15.Text = "Username:";
            // 
            // loginTarget
            // 
            loginTarget.AutoSize = true;
            loginTarget.BackColor = Color.IndianRed;
            loginTarget.Font = new Font("Arial Rounded MT Bold", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginTarget.ForeColor = Color.White;
            loginTarget.Location = new Point(236, 96);
            loginTarget.Name = "loginTarget";
            loginTarget.Size = new Size(255, 49);
            loginTarget.TabIndex = 1;
            loginTarget.Text = "loginTarget";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Account_Selection;
            pictureBox5.Location = new Point(1, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(785, 556);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Account_Selection;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(785, 556);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // AccountManagerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(loginPanel);
            Controls.Add(startScreenPanel);
            Controls.Add(loginChoosePanel);
            Controls.Add(regisChoosePanel);
            Controls.Add(regisPanel);
            Controls.Add(pictureBox6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManagerGUI";
            Text = "Form1";
            startScreenPanel.ResumeLayout(false);
            startScreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            regisPanel.ResumeLayout(false);
            regisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            regisChoosePanel.ResumeLayout(false);
            regisChoosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            loginChoosePanel.ResumeLayout(false);
            loginChoosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Button chooseRegisterKasir;
        private Button chooseRegisterTenant;
        private Button chooseRegisterPembeli;
        private Panel loginChoosePanel;
        private Button loginChooseBack;
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
        private Label label12;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}