﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_StatusOrder;
using MengaturMenu;
using PrintStruk;


namespace GUI_Implementation
{
    public partial class Kasir : Form
    {
        private List<Order> orders;
        private GUIController controller;
        private PrintStrukPDF printer;
        public Kasir()
        {
            InitializeComponent();
            controller = new GUIController();
            printer = new PrintStrukPDF();
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
            orders = new List<Order>
{
    new Order("1", "Rasya", "Sate Padang", 2, 20000, "Tunai", "Menunggu konfirmasi pembayaran"),
    new Order("2", "Kansas", "Soto Betawi", 1, 12000, "Qris", "Pesanan sedang disiapkan"),
    new Order("3", "Katsu", "Lemon Tea", 3, 35000, "Tunai", "Pesanan sedang disiapkan"),
    new Order("4", "Rasya", "Nasi Goreng", 2, 30000, "Qris", "Menunggu konfirmasi pembayaran"),
    new Order("5", "Katsu", "Ayam Goreng", 1, 50000, "Tunai", "Pesanan sudah selesai")
};


            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(order.KodeAntrian);
                item.SubItems.Add(order.Tenant);
                item.SubItems.Add(order.NamaMenu);
                item.SubItems.Add(order.Qty.ToString());
                item.SubItems.Add(order.Harga.ToString());
                item.SubItems.Add(order.PaymentMethod);
                item.SubItems.Add(order.StatusPesanan);

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
            //implementasi belum selesai , just a proof of concept :/
            List<MenuMakanan<string>> items = new List<MenuMakanan<string>>();
            List<string> images = new List<string>();
            items[0] = new MenuMakanan<string>("Burger", images,25000, "Roti+Daging+roti" );
            items[1] = new MenuMakanan<string>("Pasta", images, 36000, "Italian Dish");
            DateTime tanggal = DateTime.Now;
            Receipt receipt = new Receipt("1001",tanggal, items);
            printer.GenerateReceipt("D:\\", receipt);
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
