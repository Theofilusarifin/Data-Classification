﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Project_Data_Mining_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Constructors
        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword + ";SSL Mode=None";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = strCon;
            
            // KoneksiDB yang dipakai adalah KoneksiDB yang sudah di set di construstor (atas)
            Connect();
        }
        public Koneksi()
        {
            //Buka konfigurasi App.Config
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Ambil section userSettings yang otomatis dibuat berdasarkan file .settings
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            //Ambil bagian setting Project_Data_Mining.db
            var settingsSection = userSettings.Sections["Project_Data_Mining.db"] as ClientSettingsSection;  //jan lupa isi nama .db nya

            //Ambil tiap variabel setting
            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword + ";SSL Mode=None";
            
            KoneksiDB = new MySqlConnection();
            
            KoneksiDB.ConnectionString = strCon;
            
            Connect();
        }

        #endregion

        #region Properties
        public MySqlConnection KoneksiDB 
        { 
            get => koneksiDB;
            private set => koneksiDB = value; //Dibuat private untuk alasan keaamanan 
        }
        #endregion

        #region Methods
        public void Connect()
        {
            //Jika connection sedang terbuka maka tutup dahulu
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            koneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql, Koneksi koneksi)
        {
            MySqlCommand c = new MySqlCommand(sql, koneksi.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static int JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            int hasil = 0;
            hasil = c.ExecuteNonQuery();
            return hasil;
        }

        public static int JalankanPerintahDML(string sql, Koneksi koneksi)
        {
            MySqlCommand c = new MySqlCommand(sql, koneksi.KoneksiDB);
            int hasil = 0;
            hasil = c.ExecuteNonQuery();
            return hasil;
        }
        #endregion
    }
}
