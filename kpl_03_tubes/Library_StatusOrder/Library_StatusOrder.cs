using System.Diagnostics.Contracts;

namespace Library_StatusOrder
{
    public class MengubahStatusPesanan
    {
        public List<order> orders;

        public MengubahStatusPesanan()
        {
            orders = new List<order>();
        }

        public void addOrder(order order)
        {
            orders.Add(order);
        }

        /*
        public void MengonfirmasiPembayaranKasir(int kodeAntrian)
        {
            // Cari order dengan kode antrian yang diberikan
            var orderCashMethod = orders.FirstOrDefault(o => o.status.Any(s => s.kodeAntrian == kodeAntrian) && o.paymentMethod == "Tunai");

            if (orderCashMethod == null)
            {
                Console.WriteLine("Tidak ada pesanan dengan kode antrian tersebut atau pesanan dibayar dengan Qris.");
                return;
            }

            // Ubah status pesanan
            foreach (var status in orderCashMethod.status)
            {
                if (status.statusOrder == "Menunggu konfirmasi pembayaran")
                {
                    status.statusOrder = "Pesanan sedang disiapkan";
                    Console.WriteLine("Status pesanan dengan kode antrian {0} berhasil diubah menjadi {1}.", kodeAntrian, status.statusOrder);
                    return;
                }
                else
                {
                    Console.WriteLine("Pembayaran Sudah Terkonfirmasi");
                    return;
                }

            }

        }

        public void MengubahStatusPesananTenant(int kodeAntrian)
        {
            // Cari order dengan kode antrian yang diberikan
            var orderCheck = orders.FirstOrDefault(o => o.status.Any(s => s.kodeAntrian == kodeAntrian));


            if (orderCheck == null)
            {
                Console.WriteLine("Tidak ada pesanan dengan kode antrian tersebut.");
                return;
            }

            // Ubah status pesanan
            foreach (var status in orderCheck.status)
            {
                if (status.statusOrder == "Menunggu konfirmasi pembayaran")
                {
                    if (orderCheck.paymentMethod == "Qris")
                    {
                        status.statusOrder = "Pesanan sedang disiapkan";
                        Console.WriteLine("Status pesanan dengan kode antrian {0} berhasil diubah menjadi {1}.", kodeAntrian, status.statusOrder);

                    }
                    else if (orderCheck.paymentMethod == "Tunai")
                    {
                        Console.WriteLine("Metode Pembayaran Bukan Menggunakan Qris");
                    }
                    return;


                }
                else if (status.statusOrder == "Pesanan sedang disiapkan")
                {
                    status.statusOrder = "Pesanan sudah selesai";
                    Console.WriteLine("Status pesanan dengan kode antrian {0} berhasil diubah menjadi {1}.", kodeAntrian, status.statusOrder);
                    return;
                }

            }


        }
        

        public void DisplayOrdersTenant(string tenantID)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------" + "Daftar Pesanan Tenant " + tenantID + "-------------------------");

            for (int i = 0; i < orders.Count; i++)
            {

                if (orders[i].tenant == tenantID)
                {


                    Console.WriteLine();
                    Console.WriteLine("Status: ");
                    for (int j = 0; j < orders[i].status.Count; j++)
                    {
                        Console.WriteLine("- Kode Antrian: " + orders[i].status[j].kodeAntrian);
                        Console.WriteLine("  Status Order: " + orders[i].status[j].statusOrder);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Items:");
                    for (int k = 0; k < orders[i].items.Count; k++)
                    {
                        Console.WriteLine("- Nama Menu: " + orders[i].items[k].namaMenu);
                        Console.WriteLine("  Jumlah: " + orders[i].items[k].qty);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Payment Details:");
                    for (int l = 0; l < orders[i].paymentDetails.Count; l++)
                    {
                        Console.WriteLine("- Nama Menu: " + orders[i].paymentDetails[l].namaMenu);
                        Console.WriteLine("  Harga: " + orders[i].paymentDetails[l].harga);
                        Console.WriteLine("  Total: " + orders[i].paymentDetails[l].total);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Payment Method: " + orders[i].paymentMethod);
                    Console.WriteLine();
                }

            }
            Console.WriteLine("-----------------------------------------------------------------------------");

        }*/



    }

    public class order
    {
        public string kodeAntrian { get; set; }
        public string tenant { get; set; }
        public string namaMenu { get; set; }
        public int qty { get; set; }
        public double harga { get; set; }
        public string paymentMethod { get; set; }
        public string statusPesanan { get; set; }

        public order(string kodeAntrian,string tenant,string namaMenu, int qty, double harga,  string paymentMethod,string statusPesanan)
        {

            try
            {
                Contract.Requires(!string.IsNullOrEmpty(kodeAntrian));
                this.kodeAntrian = kodeAntrian;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }


            // tenenat tidak boleh kosong 
            try
            {
                Contract.Requires(!string.IsNullOrEmpty(tenant));
                this.tenant = tenant;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }

            try
            {
                Contract.Requires(!string.IsNullOrEmpty(namaMenu));
                this.namaMenu = namaMenu;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }

            try
            {
                Contract.Requires(qty > 0);
                this.qty = qty;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }
            try
            {
                Contract.Requires(harga > 0);
                this.harga = harga;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }


            // Status order tidak boleh kosong
            try
            {
                Contract.Requires(statusPesanan != null);
                this.statusPesanan = statusPesanan;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);
            }


            // payment method tidak boleh kosong
            try
            {
                Contract.Requires(!string.IsNullOrEmpty(tenant));
                this.paymentMethod = paymentMethod;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error Message :" + e.Message);

            }


        }

    }

   
}