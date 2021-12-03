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

        private double ManhattanCalculation(Data d1, Data d2, int featNumber)
        {
            double result = 0;
            for (int i = 0; i < featNumber; i++)
            {
                result += Math.Abs((double.Parse(d1.ListFeat[i].Nilai) - double.Parse(d2.ListFeat[i].Nilai)));
            }
            return result;
        }

        private double EuclideanCalculation(Data d1, Data d2, int featNumber)
        {
            double result = 0;
            for (int i = 0; i < featNumber; i++)
            {
                result += Math.Pow((double.Parse(d1.ListFeat[i].Nilai) - double.Parse(d2.ListFeat[i].Nilai)), 2);
            }
            result = Math.Round(Math.Sqrt(result),2);
            return result;
        }

        private double SupremumCalculation(Data d1, Data d2, int featNumber)
        {
            List<double> listResult = new List<double>();
            for (int i = 0; i < featNumber; i++)
            {
                listResult.Add(Math.Abs((double.Parse(d1.ListFeat[i].Nilai) - double.Parse(d2.ListFeat[i].Nilai))));
            }
            return listResult.Max();
        }
        #endregion

        private void FormResult_Load(object sender, EventArgs e)
        {
            listData = Data.BacaData();
            FormatDataGrid();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();
            List<double> Feat1 = new List<double>();
            List<double> Feat2 = new List<double>();

            #region Manhattan
            if (radioButtonManhattan.Checked)
            {
                for (int row = 0; row < listData.Count; row++)
                {
                    this.dataGridView.Rows.Add();
                    dataGridView.Rows[row].Cells[0].Value = listData[row].Document_id;
                    for (int col = 0; col < listData.Count; col++)
                    {
                        dataGridView.Rows[row].Cells[col + 1].Value = ManhattanCalculation(listData[row], listData[col], FormUtama.featNumber);
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
            if (radioButtonSupremum.Checked)
            {
                for (int x = 0; x < DataClass.DataMemberCount; x++)
                {
                    for (int row = 0; row < listData.Count; row++)
                    {
                        this.dataGridView.Rows.Add();
                        dataGridView.Rows[row].Cells[0].Value = listData[row].Document_id;
                        for (int col = 0; col < listData.Count; col++)
                        {
                            dataGridView.Rows[row].Cells[col + 1].Value = SupremumCalculation(listData[row], listData[col], FormUtama.featNumber);
                        }
                    }
                }
            }
            #endregion
        }
    }
}
