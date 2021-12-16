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
    public partial class FormApproxityMatrix : Form
    {
        public FormApproxityMatrix()
        {
            InitializeComponent();
        }

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("Document_id", "Document_id");
            dataGridView.Columns["Document_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["Document_id"].SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (Data d in FormUtama.listData)
            {
                dataGridView.Columns.Add(d.Document_id, d.Document_id);
            }

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            foreach (Data d in FormUtama.listData)
            {
                dataGridView.Columns[d.Document_id].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[d.Document_id].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;

        }

        private bool CheckAvailability()
        {
            for (int row = 0; row < FormUtama.listData.Count; row++)
            {
                for (int col = 0; col < FormUtama.listData.Count; col++)
                {
                    for (int i = 0; i < FormUtama.featNumber; i++)
                    {
                        double num1;
                        double num2;
                        if (double.TryParse(FormUtama.listData[row].ListFeat[i].Nilai, out num1) && double.TryParse(FormUtama.listData[col].ListFeat[i].Nilai, out num2))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Kalkulasi gagal karena terdapat nilai feat yang bukan angka", "Error");
                            return false;
                        }
                    }
                }
            }
            return true;
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
            if (!FormUtama.dataReaded)
            {
                FormUtama.listData = Data.BacaData();
                FormUtama.dataReaded = true;
            }
            FormatDataGrid();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckAvailability())
                {
                    //Kosongi isi datagridview
                    dataGridView.Rows.Clear();
                    List<double> Feat1 = new List<double>();
                    List<double> Feat2 = new List<double>();

                    #region Manhattan
                    if (radioButtonManhattan.Checked)
                    {
                        for (int row = 0; row < FormUtama.listData.Count; row++)
                        {
                            this.dataGridView.Rows.Add();
                            dataGridView.Rows[row].Cells[0].Value = FormUtama.listData[row].Document_id;
                            for (int col = 0; col < FormUtama.listData.Count; col++)
                            {
                                dataGridView.Rows[row].Cells[col + 1].Value = ManhattanCalculation(FormUtama.listData[row], FormUtama.listData[col], FormUtama.featNumber);
                            }
                        }
                    }
                    #endregion

                    #region Euclidean
                    if (radioButtonEuclidean.Checked)
                    {
                        for (int row = 0; row < FormUtama.listData.Count; row++)
                        {
                            this.dataGridView.Rows.Add();
                            dataGridView.Rows[row].Cells[0].Value = FormUtama.listData[row].Document_id;
                            for (int col = 0; col < FormUtama.listData.Count; col++)
                            {
                                dataGridView.Rows[row].Cells[col + 1].Value = EuclideanCalculation(FormUtama.listData[row], FormUtama.listData[col], FormUtama.featNumber);
                            }
                        }
                    }
                    #endregion

                    #region Supremum
                    if (radioButtonSupremum.Checked)
                    {
                        for (int row = 0; row < FormUtama.listData.Count; row++)
                        {
                            this.dataGridView.Rows.Add();
                            dataGridView.Rows[row].Cells[0].Value = FormUtama.listData[row].Document_id;
                            for (int col = 0; col < FormUtama.listData.Count; col++)
                            {
                                dataGridView.Rows[row].Cells[col + 1].Value = SupremumCalculation(FormUtama.listData[row], FormUtama.listData[col], FormUtama.featNumber);
                            }
                        }

                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region MenuStrip
        private void approximityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormResult frm = new FormResult(); //Create Object
            //frm.Owner = this.Owner;
            //frm.Show();
            //this.Close();
        }
        private void giniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGINI frm = new FormGINI(); //Create Object
            frm.Owner = this.Owner;
            frm.Show();
            this.Close();
        }
        private void entropyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntropy frm = new FormEntropy(); //Create Object
            frm.Owner = this.Owner;
            frm.Show();
            this.Close();
        }
        #endregion

        #region DesainButton
        private void buttonCalculate_MouseEnter(object sender, EventArgs e)
        {
            buttonCalculate.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonCalculate_MouseLeave(object sender, EventArgs e)
        {
            buttonCalculate.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
