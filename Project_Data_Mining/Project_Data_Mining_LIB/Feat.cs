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
        private Data data;
        private int feat_id;
        private double nilai;
        #endregion

        #region Constructors
        public Feat(int id, Data data, int feat_id, double nilai)
        {
            this.Id = id;
            this.Data = data;
            this.Feat_id = feat_id;
            this.Nilai = nilai;
        }
        public Feat(Data data, int feat_id, double nilai)
        {
            this.Data = data;
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
        public int Feat_id
        {
            get => feat_id;
            set => feat_id = value;
        }
        public double Nilai
        { 
            get => nilai; 
            set => nilai = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Feat f)
        {
            string sql = "insert into feats (document_id, feat_id, nilai) values ('" + f.Data.Document_id + "', " + f.Feat_id + ", " + f.Nilai + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        #endregion
    }
}
