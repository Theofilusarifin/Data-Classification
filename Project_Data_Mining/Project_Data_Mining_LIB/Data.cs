using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_Data_Mining_LIB
{
    public class Data
    {
        private string document_id;
        private List<Feat> listFeat; // Composition

        #region Constructors
        public Data(string document_id)
        {
            this.Document_id = document_id;
            this.ListFeat = new List<Feat>();
        }
        #endregion

        #region Properties
        public string Document_id 
        { 
            get => document_id; 
            set => document_id = value; 
        }
        public List<Feat> ListFeat 
        { 
            get => listFeat; 
            private set => listFeat = value; 
        }
        #endregion

        #region Method
        public static Boolean TambahData(Data d)
        {
            string sql = "insert into datas values ('" + d.Document_id + "')";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Data> BacaData()
        {
            string sql = "select * from datas";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Data> listData = new List<Data>();

            while (hasil.Read() == true)
            {
                Data d = new Data(hasil.GetString(0));

                string sql_join = "select class_id, feat_id, nilai from feats where document_id = '" + d.Document_id + "'";
                MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(sql_join);

                while (hasil_join.Read() == true)
                {
                    Class c = new Class(hasil_join.GetString(0));
                    Feat f = new Feat(d, c, hasil_join.GetInt32(1), hasil_join.GetString(2));
                    d.ListFeat.Add(f);
                }
                listData.Add(d);
            }
            return listData;
        }
        #endregion
    }
}
