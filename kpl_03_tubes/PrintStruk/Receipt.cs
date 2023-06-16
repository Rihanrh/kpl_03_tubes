using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MengaturMenu;

namespace PrintStruk
{
    public class Receipt
    {
    
            public string idTransaksi { get; set; }
            public DateTime tanggal { get; set; }
            public List<MenuMakanan<string>> items { get; set; }
            public double totalCost { get; set; }

            public Receipt() { }

            public Receipt(string iD_Transaksi, DateTime tanggal, List<MenuMakanan<string>> items)
            {
                Contract.Requires(!string.IsNullOrWhiteSpace(iD_Transaksi), "ID_Transaksi cannot be null or empty");
                Contract.Requires(items != null && items.Count > 0, "Items cannot be null or empty");
                Contract.Requires(Contract.ForAll(items, item => item != null), "All Items cannot be null");
                Contract.Requires(Contract.ForAll(items, item => item.hargaMenu > 0), "All items harga_menu should be greater than 0");
                Contract.Requires(tanggal <= DateTime.Today, "Tanggal cannot be greater than today");

                this.idTransaksi = iD_Transaksi;
                this.tanggal = tanggal;
                this.items = items;
                this.totalCost = items.Sum(item => item.hargaMenu);
            }
    }
}

