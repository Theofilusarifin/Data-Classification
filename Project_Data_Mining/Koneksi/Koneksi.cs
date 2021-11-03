using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Koneksi
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
            Connect();
        }
        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections[""] as ClientSettingsSection;  //jan lupa isi nama .db nya

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
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
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
        public static int JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            int hasil = 0;
            hasil = c.ExecuteNonQuery();
            return hasil;
        }
        #endregion
    }
}
