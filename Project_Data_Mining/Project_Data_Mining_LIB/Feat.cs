using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_Data_Mining_LIB
{
    public class Feat
    {
        #region Fields
        private int id;
        // Pakai kelas karena class tidak bisa dipakai (default c#)
        private Class kelas;
        private Data data;
        private int feat_id;
        private string nilai;
        #endregion

        #region Constructors
        public Feat(int id, Data data, Class kelas, int feat_id, string nilai)
        {
            this.Id = id;
            this.Data = data;
            this.Kelas = kelas;
            this.Feat_id = feat_id;
            this.Nilai = nilai;
        }
        public Feat(Data data, Class kelas, int feat_id, string nilai)
        {
            this.Data = data;
            this.Kelas = kelas;
            this.Feat_id = feat_id;
            this.Nilai = nilai;
        }
        #endregion

        #region Properties
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public Data Data 
        { 
            get => data; 
            set => data = value; 
        }
        public Class Kelas
        {
            get => kelas;
            set => kelas = value;
        }
        public int Feat_id
        {
            get => feat_id;
            set => feat_id = value;
        }
        public string Nilai
        { 
            get => nilai; 
            set => nilai = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Feat f)
        {
            string sql = "insert into feats (document_id, class_id, feat_id, nilai) values ('" + f.Data.Document_id + "', '" + f.Kelas.Id + "', " + f.Feat_id + ", '" + f.Nilai + "')";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }
        public static int AmbilParent(string class_id)
        {
            string sql = "select count(distinct(document_id)) from feats where class_id = '" + class_id + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int banyakData = 0;

            while (hasil.Read() == true)
            {
                banyakData = hasil.GetInt32(0);
            }
            return banyakData;
        }
        public static List<string> AmbilData(int feat_id)
        {
            string sql = "select distinct nilai from feats where feat_id = " + feat_id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<string> listData = new List<string>();

            while (hasil.Read() == true)
            {
                listData.Add(hasil.GetString(0));
            }
            return listData;
        }

        public static int HitungData(int feat_id, string class_id, string nilai)
        {
            string sql = "select count(distinct(document_id)) from feats where feat_id = " + feat_id + " and class_id = '" + class_id + "' and nilai = '" + nilai + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int banyakData = 0;

            while (hasil.Read() == true)
            {
                banyakData = hasil.GetInt32(0);
            }
            return banyakData;
        }
        #endregion
    }
}
