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
            label13 = new Label();
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
            pictureBox5 = new PictureBox();
            regisChoosePanel = new Panel();
            label12 = new Label();
            label2 = new Label();
            regisChooseBack = new Button();
            chooseRegisterKasir = new Button();
            chooseRegisterPembeli = new Button();
            chooseRegisterTenant = new Button();
            pictureBox4 = new PictureBox();
            loginChoosePanel = new Panel();
            label11 = new Label();
            loginChooseBack = new Button();
            chooseLoginKasir = new Button();
            chooseLoginTenant = new Button();
            chooseLoginPembeli = new Button();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            loginPanel = new Panel();
            label9 = new Label();
            loginBack = new Button();
            loginSubmit = new Button();
            passwordLoginBox = new TextBox();
            usernameLoginBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            loginTarget = new Label();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            startScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            regisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            regisChoosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            loginChoosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            startScreenPanel.Size = new Size(896, 745);
            startScreenPanel.TabIndex = 0;
            // 
            // endButton
            // 
            endButton.BackColor = Color.IndianRed;
            endButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            endButton.ForeColor = Color.White;
            endButton.Location = new Point(344, 474);
            endButton.Margin = new Padding(3, 4, 3, 4);
            endButton.Name = "endButton";
            endButton.Size = new Size(172, 59);
            endButton.TabIndex = 3;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.IndianRed;
            loginButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(345, 394);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(171, 58);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registrasiButton
            // 
            registrasiButton.BackColor = Color.IndianRed;
            registrasiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registrasiButton.ForeColor = Color.White;
            registrasiButton.Location = new Point(345, 315);
            registrasiButton.Margin = new Padding(3, 4, 3, 4);
            registrasiButton.Name = "registrasiButton";
            registrasiButton.Size = new Size(171, 58);
            registrasiButton.TabIndex = 1;
            registrasiButton.Text = "Registrasi";
            registrasiButton.UseVisualStyleBackColor = false;
            registrasiButton.Click += registrasiButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(537, 29);
            label1.Name = "label1";
            label1.Size = new Size(335, 86);
            label1.TabIndex = 0;
            label1.Text = "KantinAja!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(896, 747);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // regisPanel
            // 
            regisPanel.Controls.Add(label13);
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
            regisPanel.Controls.Add(pictureBox5);
            regisPanel.Location = new Point(0, 0);
            regisPanel.Margin = new Padding(3, 4, 3, 4);
            regisPanel.Name = "regisPanel";
            regisPanel.Size = new Size(896, 745);
            regisPanel.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.IndianRed;
            label13.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(537, 29);
            label13.Name = "label13";
            label13.Size = new Size(335, 86);
            label13.TabIndex = 15;
            label13.Text = "KantinAja!";
            // 
            // regisBack
            // 
            regisBack.BackColor = Color.IndianRed;
            regisBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            regisBack.ForeColor = Color.White;
            regisBack.Location = new Point(345, 548);
            regisBack.Margin = new Padding(3, 4, 3, 4);
            regisBack.Name = "regisBack";
            regisBack.Size = new Size(171, 58);
            regisBack.TabIndex = 11;
            regisBack.Text = "Back";
            regisBack.UseVisualStyleBackColor = false;
            regisBack.Click += regisBack_Click;
            // 
            // regisSubmit
            // 
            regisSubmit.BackColor = Color.IndianRed;
            regisSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            regisSubmit.ForeColor = Color.White;
            regisSubmit.Location = new Point(345, 458);
            regisSubmit.Margin = new Padding(3, 4, 3, 4);
            regisSubmit.Name = "regisSubmit";
            regisSubmit.Size = new Size(171, 58);
            regisSubmit.TabIndex = 10;
            regisSubmit.Text = "Submit";
            regisSubmit.UseVisualStyleBackColor = false;
            regisSubmit.Click += regisSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightCoral;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(345, 413);
            label8.Name = "label8";
            label8.Size = new Size(151, 12);
            label8.TabIndex = 9;
            label8.Text = "*maks 16 karakter, tidak ada spasi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightCoral;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(345, 321);
            label7.Name = "label7";
            label7.Size = new Size(151, 12);
            label7.TabIndex = 8;
            label7.Text = "*maks 20 karakter, tidak ada spasi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.ForeColor = Color.White;
            label6.Location = new Point(517, 379);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 7;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCoral;
            label5.ForeColor = Color.White;
            label5.Location = new Point(517, 287);
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
            passwordRegisBox.Size = new Size(166, 27);
            passwordRegisBox.TabIndex = 5;
            // 
            // usernameRegisBox
            // 
            usernameRegisBox.Location = new Point(345, 287);
            usernameRegisBox.Margin = new Padding(3, 4, 3, 4);
            usernameRegisBox.Name = "usernameRegisBox";
            usernameRegisBox.Size = new Size(166, 27);
            usernameRegisBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 383);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.ForeColor = Color.White;
            label3.Location = new Point(261, 291);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // regisTarget
            // 
            regisTarget.AutoSize = true;
            regisTarget.BackColor = Color.IndianRed;
            regisTarget.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            regisTarget.ForeColor = Color.White;
            regisTarget.Location = new Point(537, 160);
            regisTarget.Name = "regisTarget";
            regisTarget.Size = new Size(192, 46);
            regisTarget.TabIndex = 1;
            regisTarget.Text = "regisTarget";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.background;
            pictureBox5.Location = new Point(0, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(896, 747);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // regisChoosePanel
            // 
            regisChoosePanel.Controls.Add(label12);
            regisChoosePanel.Controls.Add(label2);
            regisChoosePanel.Controls.Add(regisChooseBack);
            regisChoosePanel.Controls.Add(chooseRegisterKasir);
            regisChoosePanel.Controls.Add(chooseRegisterPembeli);
            regisChoosePanel.Controls.Add(chooseRegisterTenant);
            regisChoosePanel.Controls.Add(pictureBox4);
            regisChoosePanel.Location = new Point(0, 0);
            regisChoosePanel.Margin = new Padding(3, 4, 3, 4);
            regisChoosePanel.Name = "regisChoosePanel";
            regisChoosePanel.Size = new Size(896, 745);
            regisChoosePanel.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.IndianRed;
            label12.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(537, 160);
            label12.Name = "label12";
            label12.Size = new Size(324, 46);
            label12.TabIndex = 15;
            label12.Text = "Pilih Akun Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(537, 29);
            label2.Name = "label2";
            label2.Size = new Size(335, 86);
            label2.TabIndex = 14;
            label2.Text = "KantinAja!";
            // 
            // regisChooseBack
            // 
            regisChooseBack.BackColor = Color.IndianRed;
            regisChooseBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            regisChooseBack.ForeColor = Color.White;
            regisChooseBack.Location = new Point(340, 555);
            regisChooseBack.Margin = new Padding(3, 4, 3, 4);
            regisChooseBack.Name = "regisChooseBack";
            regisChooseBack.Size = new Size(171, 58);
            regisChooseBack.TabIndex = 5;
            regisChooseBack.Text = "Back";
            regisChooseBack.UseVisualStyleBackColor = false;
            regisChooseBack.Click += regisChooseBack_Click;
            // 
            // chooseRegisterKasir
            // 
            chooseRegisterKasir.BackColor = Color.IndianRed;
            chooseRegisterKasir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseRegisterKasir.ForeColor = Color.White;
            chooseRegisterKasir.Location = new Point(340, 469);
            chooseRegisterKasir.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterKasir.Name = "chooseRegisterKasir";
            chooseRegisterKasir.Size = new Size(171, 58);
            chooseRegisterKasir.TabIndex = 3;
            chooseRegisterKasir.Text = "Kasir";
            chooseRegisterKasir.UseVisualStyleBackColor = false;
            chooseRegisterKasir.Click += chooseRegisterKasir_Click;
            // 
            // chooseRegisterPembeli
            // 
            chooseRegisterPembeli.BackColor = Color.IndianRed;
            chooseRegisterPembeli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseRegisterPembeli.ForeColor = Color.White;
            chooseRegisterPembeli.Location = new Point(340, 291);
            chooseRegisterPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterPembeli.Name = "chooseRegisterPembeli";
            chooseRegisterPembeli.Size = new Size(171, 58);
            chooseRegisterPembeli.TabIndex = 1;
            chooseRegisterPembeli.Text = "Pembeli";
            chooseRegisterPembeli.UseVisualStyleBackColor = false;
            chooseRegisterPembeli.Click += chooseRegisterPembeli_Click;
            // 
            // chooseRegisterTenant
            // 
            chooseRegisterTenant.BackColor = Color.IndianRed;
            chooseRegisterTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseRegisterTenant.ForeColor = Color.White;
            chooseRegisterTenant.Location = new Point(340, 379);
            chooseRegisterTenant.Margin = new Padding(3, 4, 3, 4);
            chooseRegisterTenant.Name = "chooseRegisterTenant";
            chooseRegisterTenant.Size = new Size(171, 58);
            chooseRegisterTenant.TabIndex = 2;
            chooseRegisterTenant.Text = "Tenant";
            chooseRegisterTenant.UseVisualStyleBackColor = false;
            chooseRegisterTenant.Click += chooseRegisterTenant_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.background;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(896, 747);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // loginChoosePanel
            // 
            loginChoosePanel.Controls.Add(label11);
            loginChoosePanel.Controls.Add(loginChooseBack);
            loginChoosePanel.Controls.Add(chooseLoginKasir);
            loginChoosePanel.Controls.Add(chooseLoginTenant);
            loginChoosePanel.Controls.Add(chooseLoginPembeli);
            loginChoosePanel.Controls.Add(label10);
            loginChoosePanel.Controls.Add(pictureBox3);
            loginChoosePanel.Location = new Point(0, 2);
            loginChoosePanel.Margin = new Padding(3, 4, 3, 4);
            loginChoosePanel.Name = "loginChoosePanel";
            loginChoosePanel.Size = new Size(896, 745);
            loginChoosePanel.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.IndianRed;
            label11.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(537, 27);
            label11.Name = "label11";
            label11.Size = new Size(335, 86);
            label11.TabIndex = 13;
            label11.Text = "KantinAja!";
            // 
            // loginChooseBack
            // 
            loginChooseBack.BackColor = Color.IndianRed;
            loginChooseBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginChooseBack.ForeColor = Color.White;
            loginChooseBack.Location = new Point(340, 553);
            loginChooseBack.Margin = new Padding(3, 4, 3, 4);
            loginChooseBack.Name = "loginChooseBack";
            loginChooseBack.Size = new Size(171, 58);
            loginChooseBack.TabIndex = 5;
            loginChooseBack.Text = "Back";
            loginChooseBack.UseVisualStyleBackColor = false;
            loginChooseBack.Click += loginChooseBack_Click;
            // 
            // chooseLoginKasir
            // 
            chooseLoginKasir.BackColor = Color.IndianRed;
            chooseLoginKasir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseLoginKasir.ForeColor = Color.White;
            chooseLoginKasir.Location = new Point(340, 467);
            chooseLoginKasir.Margin = new Padding(3, 4, 3, 4);
            chooseLoginKasir.Name = "chooseLoginKasir";
            chooseLoginKasir.Size = new Size(171, 58);
            chooseLoginKasir.TabIndex = 3;
            chooseLoginKasir.Text = "Kasir";
            chooseLoginKasir.UseVisualStyleBackColor = false;
            chooseLoginKasir.Click += chooseLoginKasir_Click;
            // 
            // chooseLoginTenant
            // 
            chooseLoginTenant.BackColor = Color.IndianRed;
            chooseLoginTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseLoginTenant.ForeColor = Color.White;
            chooseLoginTenant.Location = new Point(340, 377);
            chooseLoginTenant.Margin = new Padding(3, 4, 3, 4);
            chooseLoginTenant.Name = "chooseLoginTenant";
            chooseLoginTenant.Size = new Size(171, 58);
            chooseLoginTenant.TabIndex = 2;
            chooseLoginTenant.Text = "Tenant";
            chooseLoginTenant.UseVisualStyleBackColor = false;
            chooseLoginTenant.Click += chooseLoginTenant_Click;
            // 
            // chooseLoginPembeli
            // 
            chooseLoginPembeli.BackColor = Color.IndianRed;
            chooseLoginPembeli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseLoginPembeli.ForeColor = Color.White;
            chooseLoginPembeli.Location = new Point(340, 289);
            chooseLoginPembeli.Margin = new Padding(3, 4, 3, 4);
            chooseLoginPembeli.Name = "chooseLoginPembeli";
            chooseLoginPembeli.Size = new Size(171, 58);
            chooseLoginPembeli.TabIndex = 1;
            chooseLoginPembeli.Text = "Pembeli";
            chooseLoginPembeli.UseVisualStyleBackColor = false;
            chooseLoginPembeli.Click += chooseLoginPembeli_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.IndianRed;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(537, 158);
            label10.Name = "label10";
            label10.Size = new Size(284, 46);
            label10.TabIndex = 0;
            label10.Text = "Pilih Akun Login";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.background;
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(896, 747);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(label9);
            loginPanel.Controls.Add(loginBack);
            loginPanel.Controls.Add(loginSubmit);
            loginPanel.Controls.Add(passwordLoginBox);
            loginPanel.Controls.Add(usernameLoginBox);
            loginPanel.Controls.Add(label14);
            loginPanel.Controls.Add(label15);
            loginPanel.Controls.Add(loginTarget);
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(896, 745);
            loginPanel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.IndianRed;
            label9.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(537, 29);
            label9.Name = "label9";
            label9.Size = new Size(335, 86);
            label9.TabIndex = 12;
            label9.Text = "KantinAja!";
            // 
            // loginBack
            // 
            loginBack.BackColor = Color.IndianRed;
            loginBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginBack.ForeColor = Color.White;
            loginBack.Location = new Point(345, 548);
            loginBack.Margin = new Padding(3, 4, 3, 4);
            loginBack.Name = "loginBack";
            loginBack.Size = new Size(171, 58);
            loginBack.TabIndex = 11;
            loginBack.Text = "Back";
            loginBack.UseVisualStyleBackColor = false;
            loginBack.Click += loginBack_Click;
            // 
            // loginSubmit
            // 
            loginSubmit.BackColor = Color.IndianRed;
            loginSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginSubmit.ForeColor = Color.White;
            loginSubmit.Location = new Point(345, 458);
            loginSubmit.Margin = new Padding(3, 4, 3, 4);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(171, 58);
            loginSubmit.TabIndex = 10;
            loginSubmit.Text = "Submit";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // passwordLoginBox
            // 
            passwordLoginBox.Location = new Point(345, 379);
            passwordLoginBox.Margin = new Padding(3, 4, 3, 4);
            passwordLoginBox.Name = "passwordLoginBox";
            passwordLoginBox.Size = new Size(166, 27);
            passwordLoginBox.TabIndex = 5;
            // 
            // usernameLoginBox
            // 
            usernameLoginBox.Location = new Point(345, 287);
            usernameLoginBox.Margin = new Padding(3, 4, 3, 4);
            usernameLoginBox.Name = "usernameLoginBox";
            usernameLoginBox.Size = new Size(166, 27);
            usernameLoginBox.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightCoral;
            label14.ForeColor = Color.White;
            label14.Location = new Point(261, 383);
            label14.Name = "label14";
            label14.Size = new Size(73, 20);
            label14.TabIndex = 3;
            label14.Text = "Password:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.LightCoral;
            label15.ForeColor = Color.White;
            label15.Location = new Point(256, 291);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 2;
            label15.Text = "Username:";
            // 
            // loginTarget
            // 
            loginTarget.AutoSize = true;
            loginTarget.BackColor = Color.IndianRed;
            loginTarget.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            loginTarget.ForeColor = Color.White;
            loginTarget.Location = new Point(537, 160);
            loginTarget.Name = "loginTarget";
            loginTarget.Size = new Size(195, 46);
            loginTarget.TabIndex = 1;
            loginTarget.Text = "loginTarget";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.background;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(896, 747);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.background;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(896, 747);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // AccountManagerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(regisPanel);
            Controls.Add(loginPanel);
            Controls.Add(startScreenPanel);
            Controls.Add(regisChoosePanel);
            Controls.Add(loginChoosePanel);
            Controls.Add(pictureBox6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManagerGUI";
            Text = "Form1";
            startScreenPanel.ResumeLayout(false);
            startScreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            regisPanel.ResumeLayout(false);
            regisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            regisChoosePanel.ResumeLayout(false);
            regisChoosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            loginChoosePanel.ResumeLayout(false);
            loginChoosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private Label label11;
        private PictureBox pictureBox3;
        private Label label9;
        private PictureBox pictureBox2;
        private Label label13;
        private PictureBox pictureBox5;
        private Label label12;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}