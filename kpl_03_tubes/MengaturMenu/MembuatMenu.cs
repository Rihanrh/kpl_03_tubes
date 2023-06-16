using System;
using System.Collections.Generic;
using System.Diagnostics;
using MengaturMenu;

namespace MengaturMenu
{
    public class Menu
    {
        public List<MenuMakanan<string>> DaftarMenu = new List<MenuMakanan<string>>();

        public MenuMakanan<string> MembuatMenu()
        {
            bool inputLagi = true;

            try
            {
                Console.Write("Silahkan Masukkan Nama Makanan Baru: ");
                string nama = Console.ReadLine();

                Debug.Assert(!string.IsNullOrEmpty(nama), "Name cannot be null or empty.");

                Console.WriteLine("Silahkan Masukkan Gambar Makanan:");
                List<string> list = new List<string> { };
                while (inputLagi)
                {
                    Console.WriteLine("input:");
                    string str = Console.ReadLine();
                    Debug.Assert(!string.IsNullOrEmpty(str), "Image path cannot be null or empty.");
                    list.Add(str);

                    Console.WriteLine("Apakah ingin tambah gambar? Y/N");
                    string pilihan = Console.ReadLine();
                    Debug.Assert(!string.IsNullOrEmpty(pilihan), "Answer cannot be null or empty.");

                    if (pilihan.ToUpper() == "N")
                    {
                        inputLagi = false;
                    }
                    else if (pilihan.ToUpper() != "Y")
                    {
                        Console.WriteLine("Input tidak valid. Harap masukkan Y atau N.");
                    }
                }

                Console.WriteLine("Silahkan Masukkan Harga Makanan: ");
                double harga = Convert.ToDouble(Console.ReadLine());

                Debug.Assert(harga >= 0, "Price cannot be negative.");

                Console.WriteLine("Silahkan Masukkan Deskripsi Singkat Makanan: ");
                string deskripsi = Console.ReadLine();

                Debug.Assert(!string.IsNullOrEmpty(deskripsi), "Description cannot be null or empty.");

                MenuMakanan<string> menuMakanan = new MenuMakanan<string>(nama, list, harga, deskripsi);
                return menuMakanan;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void MenambahMenu(MenuMakanan<string> menuMakanan)
        {
            DaftarMenu.Add(menuMakanan);
        }
        public void HapusMenu(string name)
        {
            MenuMakanan<string> menuToRemove = DaftarMenu.Find(menu => menu.nameMenu.Equals(name));
            if (menuToRemove != null)
            {
                DaftarMenu.Remove(menuToRemove);
                Console.WriteLine($"Menu {name} berhasil dihapus.");
            }
            else
            {
                Console.WriteLine($"Tidak ada menu dengan nama {name} ditemukan.");
            }
        }

        public void UbahMenu(string nama_menu, string newNama_menu, double harga, string deskripsi, List<string> path_images)
        {
            for (int i = 0; i < DaftarMenu.Count; i++)
            {
                if (DaftarMenu[i].nameMenu == nama_menu)
                {
                    DaftarMenu[i].nameMenu = newNama_menu;
                    DaftarMenu[i].hargaMenu = harga;
                    DaftarMenu[i].deskripsiMenu = deskripsi;
                    DaftarMenu[i].pathImages = path_images;
                    Console.WriteLine("Menu berhasil diubah.");
                    return;
                }
            }
            Console.WriteLine("Menu dengan nama tersebut tidak ditemukan.");
        }


        public void showAllMenu()
        {
            Console.WriteLine("Daftar Menu :");
            for (int i = 0; i < DaftarMenu.Count; i++)
            {
                Console.WriteLine("Nama :" + DaftarMenu[i].nameMenu + " Harga :" + DaftarMenu[i].hargaMenu);
                Console.WriteLine("Deskripsi :" + DaftarMenu[i].deskripsiMenu);
                Console.WriteLine("Gambar :");
                DaftarMenu[i].ShowImages();
                Console.WriteLine();
            }
        }
    }
}
