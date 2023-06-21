using Library_StatusOrder;
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
    public partial class MelihatStatusPemesanan : Form
    {
        private List<Order> orders;
        private GUIController controller;
        public MelihatStatusPemesanan()
        {
            InitializeComponent();
            controller = new GUIController();
        }

        private void PembeliMelihatStatusPemesanan_Load(object sender, EventArgs e)
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
            orders = new List<Order>
            {
                new Order("2", "Aje", "Sate Asin Pedas", 2, 20000, "Tunai", "Menunggu konfirmasi pembayaran"),
                new Order("4", "Rasya", "Nasi Goreng", 2, 30000, "Qris", "Menunggu konfirmasi pembayaran"),
                new Order("5", "Munjul", "Mie Tektek", 2, 30000, "Tunai", "Menunggu konfirmasi pembayaran")
            };


            foreach (var order in orders)
            {

                ListViewItem item = new ListViewItem(order.KodeAntrian);
                item.SubItems.Add(order.NamaMenu);
                item.SubItems.Add(order.Qty.ToString());
                item.SubItems.Add(order.Harga.ToString());
                item.SubItems.Add(order.PaymentMethod);
                item.SubItems.Add(order.StatusPesanan);

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string kodeAntrian = selectedItem.SubItems[0].Text;
                string statusPesanan = selectedItem.SubItems[5].Text;

                MessageBox.Show($"Kode Antrian: {kodeAntrian}\nStatus Pesanan: {statusPesanan}");
            }
        }
    }
}
