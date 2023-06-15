namespace GUI_Implementation
{
    public partial class AccountManagerGUI : Form
    {
        private GUIController controller;
        public AccountManagerGUI()
        {
            InitializeComponent();
            controller = new GUIController();
            Load += startScreen_Load;
        }

        private void startScreen_Load(object sender, EventArgs e)
        {
            startScreenPanel.Visible = true;
            regisChoosePanel.Visible = false;
            loginChoosePanel.Visible = false;
            regisPanel.Visible = false;
            loginPanel.Visible = false;
        }

        private void registrasiButton_Click(object sender, EventArgs e)
        {
            startScreenPanel.Visible = false;
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.RegisButton);
            regisChoosePanel.Visible = true;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chooseRegisterPembeli_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectPembeli);
            regisChoosePanel.Visible = false;
            regisScreenLoad();
        }

        private void regisScreenLoad()
        {
            if (controller.CurrentState == AccountManager.AccountMachine.State.PembeliRegistration)
            {
                regisTarget.Text = "Registrasi Pembeli";
            }
            else if (controller.CurrentState == AccountManager.AccountMachine.State.TenantRegistration)
            {
                regisTarget.Text = "Registrasi Tenant";
            }
            else if (controller.CurrentState == AccountManager.AccountMachine.State.KasirRegistration)
            {
                regisTarget.Text = "Registrasi Kasir";
            }
            regisPanel.Visible = true;
        }

        private void regisChooseBack_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.Cancel);
            regisChoosePanel.Visible = false;
            startScreenPanel.Visible = true;
        }

        private void regisBack_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.Cancel);
            regisPanel.Visible = false;
            regisChoosePanel.Visible = true;
        }

        private void chooseRegisterTenant_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectTenant);
            regisChoosePanel.Visible = false;
            regisScreenLoad();
        }

        private void chooseRegisterKasir_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectKasir);
            regisChoosePanel.Visible = false;
            regisScreenLoad();
        }

        private void regisSubmit_Click(object sender, EventArgs e)
        {
            controller.Register(usernameRegisBox.Text, passwordRegisBox.Text, controller.CurrentState);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            startScreenPanel.Visible = false;
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.LoginButton);
            loginChoosePanel.Visible = true;
        }

        private void loginScreenLoad()
        {
            if (controller.CurrentState == AccountManager.AccountMachine.State.PembeliLogin)
            {
                loginTarget.Text = "Login Pembeli";
            }
            else if (controller.CurrentState == AccountManager.AccountMachine.State.TenantLogin)
            {
                loginTarget.Text = "Login Tenant";
            }
            else if (controller.CurrentState == AccountManager.AccountMachine.State.KasirLogin)
            {
                loginTarget.Text = "Login Kasir";
            }
            loginPanel.Visible = true;
        }

        private void chooseLoginPembeli_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectPembeli);
            loginChoosePanel.Visible = false;
            loginScreenLoad();
        }

        private void chooseLoginTenant_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectTenant);
            loginChoosePanel.Visible = false;
            loginScreenLoad();
        }

        private void chooseLoginKasir_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.SelectKasir);
            loginChoosePanel.Visible = false;
            loginScreenLoad();
        }

        private void loginChooseBack_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.Cancel);
            loginChoosePanel.Visible = false;
            startScreenPanel.Visible = true;
        }

        private void loginBack_Click(object sender, EventArgs e)
        {
            controller.HandleTrigger(AccountManager.AccountMachine.Trigger.Cancel);
            loginPanel.Visible = false;
            loginChoosePanel.Visible = true;
        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            if (controller.Login(usernameLoginBox.Text, passwordLoginBox.Text, controller.CurrentState))
            {
                MessageBox.Show("Login Berhasil!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Kasir kasir = new Kasir();
                kasir.Show();

            }
            else
            {
                MessageBox.Show("Username/Password/Tipe akun invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}