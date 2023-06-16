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
    public partial class Tenant : Form
    {
        GUIController controller;
        List<string> pathImages;
        TenantMengubahStatusPesanan statusPesananTenant;
        public Tenant()
        {
            InitializeComponent();
            this.controller = new GUIController();
            this.pathImages = new List<string>();
            this.statusPesananTenant = new TenantMengubahStatusPesanan();
        }

        private void buttonKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ///Getting the path and saving it
                string selectedImagePath = openFileDialog.FileName;
                pathImages.Add(selectedImagePath);
                Image selectedImage = Image.FromFile(selectedImagePath);

                labelOtherImage.Text = "Other Image added";
               // pictureBox1.Image = selectedImage;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxDeskrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = BoxNama.Text;
            string hargaStr = BoxHarga.Text;
            double harga = double.Parse(hargaStr);
            string deskripsi = BoxDeskrip.Text;
            controller.MenambahMenu(controller.MembuatMenu(nama, pathImages, harga, deskripsi));
            BoxDeskrip.Text = "";
            BoxHarga.Text = "";
            BoxNama.Text = "";
            pathImages.Clear();
            MessageBox.Show("Sucessfully Added!");
            
        }

        private void statusPesanan_Click(object sender, EventArgs e)
        {
            statusPesananTenant.Visible = true;
        }
    }
}
