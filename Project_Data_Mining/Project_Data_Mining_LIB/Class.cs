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
        #endregion

        #region Constructors
        public Class(string id)
        {
            this.Id = id;
        }
        #endregion

        #region Properties
        public string Id 
        { 
            get => id; 
            set => id = value; 
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

        public static List<Class> BacaData()
        {
            string sql = "select * from classes";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Class> listClass = new List<Class>();

            while (hasil.Read() == true)
            {
                Class c = new Class(hasil.GetString(0));
                listClass.Add(c);
            }
            return listClass;
        }

        public static Class AmbilData(Class c)
        {
            string sql = "select * from classes where id = '" + c.Id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            Class cl = new Class(hasil.GetString(0));

            return cl;
        }
        #endregion
    }
}
