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
    public partial class FormEntropy : Form
    {

        public FormEntropy()
        {
            InitializeComponent();
        }

        private bool calculated = false;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!calculated)
                {
                    // listbox di clear
                    listBoxInfo.Items.Clear();

                    if (!FormUtama.entropyCalculated)
                    {
                        // list untuk menampung banyak data per class
                        List<int> dataPerClass = new List<int>();
                        // untuk setiap class
                        for (int cNum = 0; cNum < FormUtama.classNumber; cNum++)
                        {
                            // hitung banyak data per class
                            int count = Feat.AmbilParent(FormUtama.listClass[cNum]);
                            // masukkan hasil hitungan ke list
                            dataPerClass.Add(count);
                        }
                        // data di total
                        FormUtama.totalParent = dataPerClass.Sum();

                        // hitung entropy dari parent
                        FormUtama.entropyParent = 0;
                        foreach (int cCount in dataPerClass)
                        {
                            double x = (double)cCount / (double)FormUtama.totalParent;
                            double temp = (-x) * Math.Log(x, 2);
                            FormUtama.entropyParent += temp;
                        }
                    }

                    // Tampilkan entropy parent ke listbox
                    listBoxInfo.Items.Add("Entropy Parent : " + FormUtama.entropyParent);

                    for (int feat = 1; feat <= FormUtama.featNumber; feat++)
                    {
                        if (!FormUtama.entropyCalculated)
                        {
                            List<string> listParameter = Feat.AmbilData(feat);
                            double sigma = 0;
                            // kalau isi listParameter lebih dari 5
                            if (listParameter.Count > 5)
                            {
                                throw new ArgumentException("Jumlah jenis nilai yang berbeda pada Feat " + feat.ToString() + " melebihi 5");
                            }
                            else
                            {
                                // untuk setiap parameter di list
                                foreach (string parameter in listParameter) //orange
                                {
                                    List<int> listDataCount = new List<int>();
                                    // untuk setiap kelas
                                    foreach (string kelas in FormUtama.listClass)//c0,c1
                                    {
                                        // menghitung data
                                        int dataCount = Feat.HitungData(feat, kelas, parameter);
                                        listDataCount.Add(dataCount);
                                    }
                                    int totalData = listDataCount.Sum();//total orange

                                    // untuk setiap jumlah data di list
                                    double entropyFeat = 0;
                                    foreach (int dCount in listDataCount)
                                    {
                                        double x = (double)dCount / (double)totalData;
                                        entropyFeat += (-x) * Math.Log(x, 2);
                                    }

                                    sigma += (double)totalData / (double)FormUtama.totalParent * entropyFeat;
                                }

                                FormUtama.listFeatEntropy.Add(sigma);

                                double gain = FormUtama.entropyParent - sigma;
                                FormUtama.listEntropyGain.Add(gain);
                            }
                        }

                        // Tambahkan M ke listbox
                        listBoxInfo.Items.Add("");
                        listBoxInfo.Items.Add("Feat " + feat);
                        listBoxInfo.Items.Add("Entropy : " + FormUtama.listFeatEntropy[feat - 1].ToString());

                        // Tambahkan gain ke listbox
                        listBoxInfo.Items.Add("Gain : " + FormUtama.listEntropyGain[feat - 1].ToString());
                    }

                    // Best Split
                    listBoxInfo.Items.Add("");
                    double bestSplit = FormUtama.listEntropyGain.Max();
                    listBoxInfo.Items.Add("Best Split adalah Feat " + (FormUtama.listEntropyGain.IndexOf(bestSplit) + 1).ToString() + " karena memiliki nilai gain terbesar diantara nilai gain atribut lainnya");

                    // Set supaya tidak ada perhitungan ulang
                    FormUtama.entropyCalculated = true;

                    // Set supaya ga bisa spam button
                    calculated = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region MenuStrip
        private void approximityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApproxityMatrix frm = new FormApproxityMatrix(); //Create Object
            frm.Owner = this.Owner;
            frm.Show();
            this.Close();
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
            //FormEntropy frm = new FormEntropy(); //Create Object
            //frm.Owner = this.Owner;
            //frm.Show();
            //this.Close();
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
