using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI_Implementation.FormCheckout;

namespace GUI_Implementation
{
    public partial class FormCheckout : Form
    {
        private List<MenuItem> menuItems;
        private List<MenuItem> pesananItems;

        public string NamaHarga { get; private set; }

        public FormCheckout()
        {
            InitializeComponent();
            menuItems = new List<MenuItem>();
            pesananItems = new List<MenuItem>();
        }

        public class MenuItem
        {
            public string Nama { get; set; }
            public decimal Harga { get; set; }
            public string NamaHarga => Nama + " - Rp " + Harga.ToString("N0");

            public MenuItem(string nama, decimal harga)
            {
                Nama = nama;
                Harga = harga;
            }

            public override string ToString()
            {
                return NamaHarga;
            }
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
            // Tambahkan kode untuk menampilkan daftar menu makanan
            menuItems.Add(new MenuItem("Nasi Goreng", 15000));
            menuItems.Add(new MenuItem("Mie Ayam", 12000));
            menuItems.Add(new MenuItem("Sate Ayam", 10000));
            menuItems.Add(new MenuItem("Soto Ayam", 8000));

            listBoxMenu.Items.AddRange(menuItems.ToArray());
            listBoxMenu.DisplayMember = "NamaHarga";
        }


        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPesanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MenuItem selectedItem = listBoxPesanan.SelectedItem as MenuItem;
            if (selectedItem != null)
            {
                pesananItems.Remove(selectedItem);
                listBoxPesanan.Items.Remove(selectedItem);
            }
        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            MenuItem selectedItem = listBoxMenu.SelectedItem as MenuItem;
            if (selectedItem != null)
            {
                pesananItems.Add(selectedItem);
                listBoxPesanan.Items.Add(selectedItem);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            decimal totalHarga = pesananItems.Sum(item => item.Harga);

            MessageBox.Show("Total Harga: Rp " + totalHarga.ToString("N0"), "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kosongkan daftar pesanan
            listBoxPesanan.Items.Clear();
            pesananItems.Clear();
        }
    }
}
