namespace GUI_Implementation
{
    public partial class AccountManagerGUI : Form
    {
        public AccountManagerGUI()
        {
            InitializeComponent();
        }

        private void startScreen_Load(object sender, EventArgs e)
        {
            startScreenPanel.Visible = true;
            loginPanel.Visible = false;
            registrationPanel.Visible = false;
        }

    }
}