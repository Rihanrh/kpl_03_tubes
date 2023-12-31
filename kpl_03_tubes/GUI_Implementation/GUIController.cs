﻿using AccountManager;
using Library_StatusOrder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountManager.AccountMachine;
using MengaturMenu;

namespace GUI_Implementation
{
    public class GUIController
    {
        private AccountManagerGUI accountManagerGUI;
        private AccountConfig accountConfig;
        private AccountMachine accountMachine;
        private TenantMengubahStatusPesanan viewTenant;
        private List<Order> orders;
        private Kasir viewKasir;
        //Sementara
        private List<MenuMakanan<string>> DaftarMenu = new List<MenuMakanan<string>>();

        public State CurrentState => accountMachine.currentState;

        public GUIController()
        {
            accountConfig = new AccountConfig();
            accountMachine = new AccountMachine();
            accountMachine.currentState = AccountMachine.State.Start;

        }

        public void HandleTrigger(Trigger trigger)
        {
            accountMachine.activeTrigger(trigger);
        }

        public void Register(string username, string password, State currentState)
        {
            if (username.Length > 20 || username.Contains(" "))
            {
                MessageBox.Show("Username Invalid! isi sesuai peraturan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length > 16 || password.Contains(" "))
            {
                MessageBox.Show("Password Invalid! isi sesuai peraturan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipe_akun = "";
            if (currentState == State.PembeliRegistration)
            {
                tipe_akun = "Pembeli";
            }
            else if (currentState == State.TenantRegistration)
            {
                tipe_akun = "Tenant";
            }
            else if (currentState == State.KasirRegistration)
            {
                tipe_akun = "Kasir";

            }

            Config config = new Config(tipe_akun, username, password);
            AccountConfig acc = new AccountConfig();
            acc.configs.Add(config); // Add the new config to the configs list
            acc.WriteNewConfigFile();

            MessageBox.Show("Registrasi Berhasil. Kembali ke halaman utama", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Login(string username, string password, State currentState)
        {
            string tipe_akun = "";
            if (currentState == State.PembeliLogin)
            {
                tipe_akun = "Pembeli";
            }
            else if (currentState == State.TenantLogin)
            {
                tipe_akun = "Tenant";
            }
            else if (currentState == State.KasirLogin)
            {
                tipe_akun = "Kasir";
            }

            AccountConfig acc = new AccountConfig();
            List<Config> config = acc.ReadConfigFile();

            Config userAccount = config.FirstOrDefault(c => c.tipe_akun == tipe_akun && c.username == username && c.password == password);

            return userAccount != null;
        }

        public void UpdateOrderStatus(TenantMengubahStatusPesanan view)
        {
            if (view.ListViewSelectedItemsCount > 0)
            {
                view.UpdateSelectedListViewItem();
            }
        }

        public void UpdateKonfirmasiPembayaran(Kasir view)
        {
            if (view.ListViewSelectedItemsCount > 0)
            {
                view.UpdateKonfirmasiPembayaran();
            }
        }

        public void StatusPemesanan(MelihatStatusPemesanan view)
        {}
      
        public MenuMakanan<string> MembuatMenu(string nama,List<string> list,double harga, string deskripsi)
        {
            try
            {
                //Debug Assert memastikan tidak null
                Debug.Assert(!string.IsNullOrEmpty(nama), "Name cannot be null or empty.");
                Debug.Assert(harga >= 0, "Price cannot be negative.");
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

    }
}
