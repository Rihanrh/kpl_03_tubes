using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Implementation
{
    public partial class FormCheckout : Form
    {
        private List<string> daftarMenu;
        public FormCheckout()
        {
            InitializeComponent();
            daftarMenu = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            TampilkanMenu();
        }

        private void TampilkanMenu()
        {
            daftarMenu.Add("Nasi Goreng - Rp 15.000");
            daftarMenu.Add("Katsu - Rp 18.000");
            daftarMenu.Add("Mie Goreng - Rp 13.000");
            daftarMenu.Add("Ayam Geprek - Rp 18.000");

            listBoxMenu.DataSource = daftarMenu;
        }


        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPesanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxPesanan.SelectedIndex != -1)
            {
                listBoxPesanan.Items.RemoveAt(listBoxPesanan.SelectedIndex);
            }
        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedIndex != -1)
            {
                string menu = listBoxMenu.SelectedItem.ToString();
                listBoxPesanan.Items.Add(menu);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            decimal totalHarga = 0;
            foreach (string item in listBoxPesanan.Items)
            {
                string[] menu = item.Split('-');
                decimal harga = decimal.Parse(menu[1].Trim().Replace("Rp", ""));
                totalHarga += harga;
            }

            MessageBox.Show("Total Harga: Rp " + totalHarga.ToString("N0"), "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBoxPesanan.Items.Clear();
        }
    }
}
