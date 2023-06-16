using System.Diagnostics.Contracts;

namespace Library_StatusOrder
{
    // Class untuk mengubah status pesanan
    public class MengubahStatusPesanan
    {

        public List<Order> Orders { get; set; }

        // membuat list of order baru
        public MengubahStatusPesanan()
        {
            Orders = new List<Order>();
        }

    }

    // class order
    public class Order
    {
        // attribut untuk class order
        public string KodeAntrian { get; set; }
        public string Tenant { get; set; }
        public string NamaMenu { get; set; }
        public int Qty { get; set; }
        public double Harga { get; set; }
        public string PaymentMethod { get; set; }
        public string StatusPesanan { get; set; }

        // constructor
        public Order(string kodeAntrian, string tenant, string namaMenu, int qty, double harga, string paymentMethod, string statusPesanan)
        {
            // kodeAntrian tidak boleh kosong
            Contract.Requires(!string.IsNullOrEmpty(kodeAntrian));
            KodeAntrian = kodeAntrian;

            // Tenant tidak boleh kosong
            Contract.Requires(!string.IsNullOrEmpty(tenant));
            Tenant = tenant;

            // nama menu tidak boleh kosong
            Contract.Requires(!string.IsNullOrEmpty(namaMenu));
            NamaMenu = namaMenu;

            // kuantitas tidak boleh kosong
            Contract.Requires(qty > 0);
            Qty = qty;

            // harga tidak boleh kosong
            Contract.Requires(harga > 0);
            Harga = harga;

            // Status pesanan tidak boleh kosong
            Contract.Requires(statusPesanan != null);
            StatusPesanan = statusPesanan;

            // Payment method tidak boleh kosong
            Contract.Requires(!string.IsNullOrEmpty(paymentMethod));
            PaymentMethod = paymentMethod;
        }
    }
}
