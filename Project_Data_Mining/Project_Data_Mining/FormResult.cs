using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Data_Mining_LIB;

namespace Project_Data_Mining
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }
        List<Data> listData = new List<Data>();
        
        #region RadioButton
        private void radioButtonManhattan_Click(object sender, EventArgs e)
        {
            radioButtonEuclidean.Checked = false;
            radioButtonSupreme.Checked = false;
        }

        private void radioButtonEuclidean_Click(object sender, EventArgs e)
        {
            radioButtonManhattan.Checked = false;
            radioButtonSupreme.Checked = false;
        }

        private void radioButtonSupreme_Click(object sender, EventArgs e)
        {
            radioButtonManhattan.Checked = false;
            radioButtonEuclidean.Checked = false;
        }
        #endregion

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("Document_id", "Document_id");
            foreach (Data d in listData)
            {
                dataGridView.Columns.Add(d.Document_id, d.Document_id);
            }

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            foreach (Data d in listData)
            {
                dataGridView.Columns[d.Document_id].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            //dataGridView.Rows.Clear();

            //if (listBarang.Count > 0)
            //{
            //    foreach (Barang b in listBarang)
            //    {
            //        dataGridView.Rows.Add(b.Id, b.Nama, b.Harga, b.Kategori.Nama);
            //    }
            //}
            //else
            //{
            //    dataGridView.DataSource = null;
            //}
        }

        private double EuclideanCalculation(Data d1, Data d2, int featNumber)
        {
            double result = 0;
            for (int i = 0; i < featNumber; i++)
            {
                result += Math.Pow((d1.ListFeat[i].Nilai - d2.ListFeat[i].Nilai), 2);
            }
            result = Math.Round(Math.Sqrt(result),2);
            return result;
        }
        #endregion

        private void FormResult_Load(object sender, EventArgs e)
        {
            listData = Data.BacaData();
            FormatDataGrid();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double manhattan, supreme;
            double max;
            List<double> Feat1 = new List<double>();
            List<double> Feat2 = new List<double>();

            #region Manhattan
            if (radioButtonManhattan.Checked)
            {
                for (int x = 0; x < DataClass.DataMemberCount; x++)
                {
                    for (int y = 0; y < DataClass.DataMemberCount; y++)
                    {
                        manhattan = 
                        Math.Abs(Convert.ToDouble(Feat1[x]) - Convert.ToDouble(Feat1[y])) + 
                        Math.Abs(Convert.ToDouble(Feat2[x]) - Convert.ToDouble(Feat2[y]));

                        manhattan = Math.Round(manhattan, 2);
                    }
                }
            }
            #endregion

            #region Euclidean
            if (radioButtonEuclidean.Checked)
            {
                for (int row = 0; row < listData.Count; row++)
                {
                    this.dataGridView.Rows.Add();
                    dataGridView.Rows[row].Cells[0].Value = listData[row].Document_id;
                    for (int col = 0; col < listData.Count; col++)
                    {
                        dataGridView.Rows[row].Cells[col + 1].Value = EuclideanCalculation(listData[row], listData[col], FormUtama.featNumber);
                    }
                }
            }
            #endregion

            #region Supreme
            if (radioButtonSupreme.Checked)
            {
                for (int x = 0; x < DataClass.DataMemberCount; x++)
                {
                    for (int y = 0; y < DataClass.DataMemberCount; y++)
                    {
                        double f1 = Math.Abs(Convert.ToDouble(Feat1[x]) - Convert.ToDouble(Feat1[y]));
                        double f2 = Math.Abs(Convert.ToDouble(Feat2[x]) - Convert.ToDouble(Feat2[y]));
                        if (f1 > f2) max = f1;
                        else max = f2;

                        supreme = max;
                    }
                }
            }
            #endregion
        }
    }
}
