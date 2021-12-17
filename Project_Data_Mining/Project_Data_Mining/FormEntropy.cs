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

        #region Methods
        private bool IsNumber(List<string> list)
        {
            // untu setiap data di list
            foreach (string data in list)
            {
                double num1;
                // kalau data adalah angka atau bisa diubah jadi angka (double)
                if (double.TryParse(data, out num1))
                {
                    // lanjut ke data berikutnya
                }
                // kalau tidak
                else
                {
                    // hasil false
                    return false;
                }
            }
            // hasil true
            return true;
        }
        #endregion

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
                            double temp = 0;
                            if (x != 0) temp = (-x) * Math.Log(x, 2);
                            
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

                            #region IsNumber
                            if (!IsNumber(listParameter))
                            {
                                #region Data Categorical Calculation
                                // kalau isi listParameter lebih dari 5
                                if (listParameter.Count > 5)
                                {
                                    throw new ArgumentException("Jumlah jenis nilai yang berbeda pada Feat " + feat.ToString() + " melebihi 5");
                                }
                                else
                                {
                                    // untuk setiap parameter di list
                                    foreach (string parameter in listParameter)
                                    {
                                        List<int> listDataCount = new List<int>();
                                        // untuk setiap kelas
                                        foreach (string kelas in FormUtama.listClass)
                                        {
                                            // menghitung data
                                            int dataCount = Feat.HitungData(feat, kelas, parameter);
                                            listDataCount.Add(dataCount);
                                        }
                                        int totalData = listDataCount.Sum();

                                        // untuk setiap jumlah data di list
                                        double entropyFeat = 0;
                                        foreach (int dCount in listDataCount)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            if (x != 0) entropyFeat += (-x) * Math.Log(x, 2);
                                            else entropyFeat += 0;
                                        }

                                        sigma += (double)totalData / (double)FormUtama.totalParent * entropyFeat;
                                    }

                                    FormUtama.listFeatEntropy.Add(sigma);

                                    double gain = FormUtama.giniParent - sigma;
                                    FormUtama.listEntropyGain.Add(gain);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Data Continuous Calculation
                                // kalau isi listParameter lebih dari 5
                                if (listParameter.Count > 5)
                                {
                                    throw new ArgumentException("Jumlah jenis nilai yang berbeda pada Feat " + feat.ToString() + " melebihi 5");
                                }
                                else
                                {
                                    List<double> parameter = new List<double>();

                                    foreach (string s in listParameter)
                                    {
                                        parameter.Add(int.Parse(s));
                                    }
                                    parameter.Sort();

                                    List<double> listMilestone = new List<double>();
                                    // untuk setiap angka
                                    for (int i = 0; i < parameter.Count; i++)
                                    {
                                        if (i != parameter.Count - 1)
                                        {
                                            double milestone = (parameter[i] + parameter[i + 1]) / 2;
                                            listMilestone.Add(milestone);
                                            MessageBox.Show(milestone.ToString());
                                        }
                                        else
                                        {
                                            if (parameter[0] < 10)
                                            {
                                                listMilestone.Add(parameter[0] - 1);
                                            }
                                            else if (parameter[0] < 100)
                                            {
                                                listMilestone.Add(parameter[0] - 5);
                                            }
                                            else if (parameter[0] < 1000)
                                            {
                                                listMilestone.Add(parameter[0] - 10);
                                            }

                                            if (parameter[parameter.Count - 1] < 10)
                                            {
                                                listMilestone.Add(parameter[parameter.Count - 1] + 1);
                                            }
                                            else if (parameter[parameter.Count - 1] < 100)
                                            {
                                                listMilestone.Add(parameter[parameter.Count - 1] + 5);
                                            }
                                            else if (parameter[parameter.Count - 1] < 1000)
                                            {
                                                listMilestone.Add(parameter[parameter.Count - 1] + 10);
                                            }

                                            listMilestone.Sort();
                                        }
                                    }

                                    // untuk setiap parameter di list
                                    foreach (double milestone in listMilestone)
                                    {
                                        List<int> countLebihKecil = new List<int>();
                                        int totalData;
                                        double entropyFeat;
                                        double M = 0;

                                        #region Cari Data <=
                                        // untuk setiap kelas
                                        foreach (string kelas in FormUtama.listClass)
                                        {
                                            // menghitung data
                                            int dataCount = Feat.CariDataLebihKecil(feat, kelas, milestone);
                                            countLebihKecil.Add(dataCount);
                                        }
                                        totalData = countLebihKecil.Sum();

                                        // untuk setiap jumlah data di list
                                        entropyFeat = 0;
                                        foreach (int dCount in countLebihKecil)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            if (x != 0 && totalData != 0) entropyFeat += (-x) * Math.Log(x, 2);
                                            else entropyFeat += 0;
                                        }

                                        M += (double)totalData / (double)FormUtama.totalParent * entropyFeat;
                                        #endregion

                                        #region Cari Data >
                                        List<int> countLebihBesar = new List<int>();
                                        // untuk setiap kelas
                                        foreach (string kelas in FormUtama.listClass)
                                        {
                                            // menghitung data
                                            int dataCount = Feat.CariDataLebihBesar(feat, kelas, milestone);
                                            countLebihBesar.Add(dataCount);
                                        }
                                        totalData = countLebihBesar.Sum();

                                        // untuk setiap jumlah data di list
                                        entropyFeat = 0;
                                        foreach (int dCount in countLebihBesar)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            if (x != 0 && totalData != 0) entropyFeat += (-x) * Math.Log(x, 2);
                                            else entropyFeat += 0;
                                        }

                                        M += (double)totalData / (double)FormUtama.totalParent * entropyFeat;
                                        #endregion

                                        FormUtama.listFeatEntropyCon.Add(M);

                                        double gain = FormUtama.giniParent - M;
                                        FormUtama.listEntropyConGain.Add(gain);
                                    }

                                    FormUtama.listFeatEntropy.Add(FormUtama.listFeatEntropyCon.Min());
                                    FormUtama.listEntropyGain.Add(FormUtama.listEntropyConGain.Max());
                                }
                                #endregion
                            }
                            #endregion
                        }

                        // Tambahkan M ke listbox
                        listBoxInfo.Items.Add("");
                        listBoxInfo.Items.Add("Feat " + feat);
                        listBoxInfo.Items.Add("------------");
                        listBoxInfo.Items.Add("Entropy: " + FormUtama.listFeatEntropy[feat - 1].ToString());

                        // Tambahkan gain ke listbox
                        listBoxInfo.Items.Add("Gain: " + FormUtama.listEntropyGain[feat - 1].ToString());
                    }

                    // Best Split
                    listBoxInfo.Items.Add("");
                    double bestSplit = FormUtama.listEntropyGain.Max();
                    listBoxInfo.Items.Add("Best Split adalah Feat " + (FormUtama.listEntropyGain.IndexOf(bestSplit) + 1).ToString("") + " karena memiliki nilai gain terbesar diantara nilai gain atribut lainnya");

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
