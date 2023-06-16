using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace MengaturMenu
{
    public class MenuMakanan<T>
    {
        public string nameMenu { get; set; }
        public List<T> pathImages { get; set; }
        public double hargaMenu { get; set; }
        public string deskripsiMenu { get; set; }

        //Constructor Class Generic inisialisasi properties class
        public MenuMakanan(string name, List<T> listImages, double harga, string deskripsi)
        {
            // Preconditions
            Contract.Requires(!string.IsNullOrEmpty(name), "Name cannot be null or empty.");
            Contract.Requires(listImages != null && listImages.Count > 0, "List of images cannot be null or empty.");
            Contract.Requires(harga >= 0, "Price cannot be negative.");
            Contract.Requires(!string.IsNullOrEmpty(deskripsi), "Description cannot be null or empty.");

            nameMenu = name;
            pathImages = listImages;
            hargaMenu = harga;
            deskripsiMenu = deskripsi;
        }
        //Metode menampilkan path Image
        public void ShowImages()
        {
            // Debugging assertion
            Debug.Assert(pathImages != null, "List of images cannot be null.");

            foreach (var imagePath in pathImages)
            {
                Console.WriteLine(imagePath);
            }
        }
    }
}
