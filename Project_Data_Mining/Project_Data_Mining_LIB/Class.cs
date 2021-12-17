using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_Data_Mining_LIB
{
    public class Class
    {
        #region Fields
        private string id;
        
        private int jumlah; // untuk menghitung jumlah kelas
        #endregion

        #region Constructors
        public Class(string id)
        {
            this.Id = id;
        }

        public Class(string id, int jumlah)
        {
            this.Id = id;
            this.Jumlah = jumlah;
        }
        #endregion

        #region Properties
        public string Id 
        { 
            get => id; 
            set => id = value; 
        }
        public int Jumlah
        {
            get => jumlah;
            set => jumlah = value;
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Class c)
        {
            string sql = "insert into classes values ('" + c.Id + "')";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //public static List<Class> BacaData()
        //{
        //    string sql = "select distinct id from classes";

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

        //    List<Class> listClass = new List<Class>();

        //    while (hasil.Read() == true)
        //    {
        //        Class c = new Class(hasil.GetString(0));
        //        listClass.Add(c);
        //    }
        //    return listClass;
        //}

        //public static List<Class> BacaData(string id)
        //{
        //    string sql = "select id, count(id) from classes" +
        //                 "where id = " + id;

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

        //    List<Class> listClass = new List<Class>();

        //    while (hasil.Read() == true)
        //    {
        //        Class c = new Class(hasil.GetString(0), int.Parse(hasil.GetString(1)));
        //        listClass.Add(c);
        //    }
        //    return listClass;
        //}

        //public static Class AmbilData(Class c)
        //{
        //    string sql = "select * from classes where id = '" + c.Id + "'";
        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
        //    Class cl = new Class(hasil.GetString(0));

        //    return cl;
        //}
        #endregion
    }
}
