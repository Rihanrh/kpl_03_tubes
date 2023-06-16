using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountManager;
using Library_StatusOrder;

namespace GUI_Implementation
{
    public partial class TenantMengubahStatusPesanan : Form
    {
        private List<order> orders;
        public TenantMengubahStatusPesanan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelNoAntrian_Click(object sender, EventArgs e)
        {

        }

        private void TenantMengubahStatusPesanan_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("No Antrian", 100);
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
                new order("4", "Rasya", "Nasi Goreng", 2, 30000, "Qris", "Menunggu konfirmasi pembayaran")
            };


            foreach (var order in orders)
            {

                ListViewItem item = new ListViewItem(order.kodeAntrian);
                item.SubItems.Add(order.namaMenu);
                item.SubItems.Add(order.qty.ToString());
                item.SubItems.Add(order.harga.ToString());
                item.SubItems.Add(order.paymentMethod);
                item.SubItems.Add(order.statusPesanan);

                listView1.Items.Add(item);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBoxNoAntrian.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxMenu.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxJumlah.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxHarga.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxMetodePembayaran.Text = listView1.SelectedItems[0].SubItems[4].Text;

        }

        private void buttonUbahStatusPesanan_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBoxNoAntrian.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBoxMenu.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBoxJumlah.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBoxHarga.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textBoxMetodePembayaran.Text;
                listView1.SelectedItems[0].SubItems[5].Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
