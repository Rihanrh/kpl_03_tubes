using AccountManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Add this namespace for MessageBox

namespace GUI_Implementation
{
    public class GUIController
    {
        private AccountConfig accountConfig;
        private AccountMachine accountMachine;

        public GUIController()
        {
            accountConfig = new AccountConfig();
            accountMachine = new AccountMachine();
            accountMachine.currentState = AccountMachine.State.Start;
        }

        public void Register()
        {
            if (accountMachine.currentState != AccountMachine.State.PembeliRegistration &&
                accountMachine.currentState != AccountMachine.State.TenantRegistration &&
                accountMachine.currentState != AccountMachine.State.KasirRegistration)
            {
                MessageBox.Show("Invalid State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
