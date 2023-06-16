using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_StatusOrder;

namespace GUI_Implementation
{
    public partial class Kasir : Form
    {
        private List<order> orders;
        private GUIController controller;
        public Kasir()
        {
            InitializeComponent();
            controller = new GUIController();
        }

        private void Kasir_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("No Antrian", 100);
            listView1.Columns.Add("Nama Tenant", 150);
            listView1.Columns.Add("Nama Menu", 200);
            listView1.Columns.Add("Qty", 50);
            listView1.Columns.Add("Harga", 100);
            listView1.Columns.Add("Metode Pembayaran", 150);
            listView1.Columns.Add("Status", 200);
            fillListView();
        }
        public void fillListView()
        {
            orders = new List<order>
{
    new order("1", "Rasya", "Sate Padang", 2, 20000, "Tunai", "Menunggu konfirmasi pembayaran"),
    new order("2", "Kansas", "Soto Betawi", 1, 12000, "Qris", "Pesanan sedang disiapkan"),
    new order("3", "Katsu", "Lemon Tea", 3, 35000, "Tunai", "Pesanan sedang disiapkan"),
    new order("4", "Rasya", "Nasi Goreng", 2, 30000, "Qris", "Menunggu konfirmasi pembayaran"),
    new order("5", "Katsu", "Ayam Goreng", 1, 50000, "Tunai", "Pesanan sudah selesai")
};


            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(order.kodeAntrian);
                item.SubItems.Add(order.tenant);
                item.SubItems.Add(order.namaMenu);
                item.SubItems.Add(order.qty.ToString());
                item.SubItems.Add(order.harga.ToString());
                item.SubItems.Add(order.paymentMethod);
                item.SubItems.Add(order.statusPesanan);

                listView1.Items.Add(item);
            }
        }

        private void panelMenuKasir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {
            controller.UpdateKonfirmasiPembayaran(this);
        }

        private void buttonPrintStruk_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogoutKasir_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLandingKasir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int ListViewSelectedItemsCount => listView1.SelectedItems.Count;

        private void listView1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                textBoxNoAntrian.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxTenant.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxMenu.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxJumlah.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBoxHarga.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBoxMetodePembayaran.Text = listView1.SelectedItems[0].SubItems[5].Text;
                textBoxStatusPesanan.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
            
        }

        public void UpdateKonfirmasiPembayaran()
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBoxNoAntrian.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBoxTenant.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBoxMenu.Text;
            listView1.SelectedItems[0].SubItems[3].Text = textBoxJumlah.Text;
            listView1.SelectedItems[0].SubItems[4].Text = textBoxHarga.Text;
            listView1.SelectedItems[0].SubItems[5].Text = textBoxMetodePembayaran.Text;
            listView1.SelectedItems[0].SubItems[6].Text = textBoxStatusPesanan.Text;
        }


    }
}
