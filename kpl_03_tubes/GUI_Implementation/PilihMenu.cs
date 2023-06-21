using Microsoft.VisualBasic;
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
    public partial class PilihMenu : Form
    {
        private enum State
        {
            Awal,
            PilihMenu,
            Selesai,
        }
        private List<string> daftarMenu;

        private State currentState;


        public PilihMenu()
        {
            InitializeComponent();
            currentState = State.Awal;
            daftarMenu = new List<string>();
            TampilkanMenu();
            UpdateUI();
        }

        private void TampilkanMenu()
        {
            //Menampilkan menu yang tersedia
            string[] daftarMenu = GetDaftarMenu();
            listBox1.Items.AddRange(daftarMenu);

            listBox1.DataSource = daftarMenu;
        }

        private string[] GetDaftarMenu()
        {
            // Menggunakan Secure Coding: Menerapkan separasi data dan kode
            string[] daftarMenu = new string[]
            {
                "Nasi Goreng - Rp 15.000",
                "Katsu - Rp 18.000",
                "Mie Goreng - Rp 13.000",
                "Ayam Geprek - Rp 18.000"
            };
            return daftarMenu;
        }

        private void UpdateUI()
        {
            // Menggunakan metode automata dimana dimulai dari state awal
            switch (currentState)
            {
                case State.Awal:
                    labelStatus.Text = "Silakan pilih menu makanan:";
                    listBox1.Enabled = true;
                    buttonPilih.Enabled = true;
                    buttonSelesai.Enabled = true;
                    break;
                case State.PilihMenu:
                    labelStatus.Text = "Anda telah memilih menu makanan.";
                    listBox1.Enabled = true;
                    buttonPilih.Enabled = true;
                    buttonSelesai.Enabled = true;
                    break;
                case State.Selesai:
                    labelStatus.Text = "Pesanan Anda selesai. Terima kasih!";
                    listBox1.Enabled = true;
                    buttonPilih.Enabled = false;
                    buttonSelesai.Enabled = false;
                    break;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            //Action untuk memilih menu makanan
            if (listBox1.SelectedIndex != -1)
            {
                currentState = State.PilihMenu;
                string menu = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(menu);
            }
            else
            {
                MessageBox.Show("Silakan pilih menu makanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            //Action ketika telah selesai memilih menu makanan
            currentState = State.Selesai;
            UpdateUI();

            MessageBox.Show("Silakan Melakukan Checkout :)", "Notification", MessageBoxButtons.OK);
        }

        private void PilihMenu_Load(object sender, EventArgs e)
        {
            TampilkanMenu();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
