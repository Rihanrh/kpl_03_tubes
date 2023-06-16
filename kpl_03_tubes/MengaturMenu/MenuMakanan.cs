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
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (listImages == null || listImages.Count == 0)
                throw new ArgumentException("List of images cannot be null or empty.", nameof(listImages));
            if (harga < 0)
                throw new ArgumentException("Price cannot be negative.", nameof(harga));
            if (string.IsNullOrEmpty(deskripsi))
                throw new ArgumentException("Description cannot be null or empty.", nameof(deskripsi));


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
