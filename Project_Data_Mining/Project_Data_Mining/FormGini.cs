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
    public partial class FormGINI : Form
    {
        #region Tidak Digunakan
        //List<string> listClass = FormUtama.listClass;
        //List<Data> listData = Data.BacaData();

        //#region Method
        //public static double CountGiniFString(List<string> Feat, List<string> parent, List<string> listFeats, List<string> listClass, int curFeat)
        //{
        //    int count = 0;
        //    double probabilityNow, GINI = 0;
        //    double probabilityCum = 0;
        //    for (int x = 0; x < Feat.Count; x += 2)
        //    {
        //        //looping class yang mungkin
        //        for (int y = 0; y < parent.Count; y++)
        //        {
        //            //looping semua data yang ada
        //            for (int z = 0; z < listFeats.Count; z++)
        //            {
        //                //cek apakah data ini sama dengan feat yang dicari
        //                if (listFeats[z] == Feat[x])
        //                {
        //                    //cek apakah sesuai dengan parent
        //                    if (listClass[z] == parent[y])
        //                    {
        //                        count++;
        //                    }
        //                }
        //            }
        //            //dapat probability tiap opsi sesuai class
        //            probabilityNow = (double)(count) / double.Parse(Feat[x + 1]);
        //            //bersihkan nilai count
        //            count = 0;
        //            //hitung probabilitas kuadratnya ->kumulatif
        //            probabilityCum += Math.Pow(probabilityNow, 2);
        //        }
        //        //hitung GINI opsi
        //        double GINIOpt = 1 - probabilityCum;//sudah benar hasilnya;
        //        GINI += double.Parse(Feat[x + 1]) / listFeats.Count * GINIOpt;
        //        //bersihkan probalitycum
        //        probabilityCum = 0;
        //    }
        //    return Math.Round(GINI, 2);
        //}
        //public static double CountGiniFNum(List<string> Feat, List<string> parent, List<string> listFeats, List<string> listClass , int curFeat)
        //{
        //    int min = 0;
        //    int max = 0;
        //    int median = 0;
        //    List<int> featNum = new List<int>(); //opsi feat 1
        //                                         //kalau benar, cari nilai tengahnya
        //    for (int x = 0; x < Feat.Count; x += 2)
        //    {
        //        //cek sekarang iterasi ke berapa, jgn lanjutkan proses bila sdh n-2
        //        if (x < Feat.Count - 2)
        //        {
        //            median = (int)(double.Parse(Feat[x]) + double.Parse(Feat[x + 2])) / 2;
        //            featNum.Add(median);
        //            for (int y = 0; y < listFeats.Count; y++)
        //            {
        //                if (curFeat == y)
        //                {
        //                    if (int.Parse(listFeats[y]) < median)
        //                        min++;
        //                    else
        //                        max++;
        //                }
        //            }
        //            //store nilai min dan max ke list
        //            featNum.Add(min);
        //            featNum.Add(max);
        //            //bersihkan nilai min dan max
        //            min = 0; max = 0;
        //        }
        //    }
        //    int DataMin = 0;
        //    int DataMax = 0;
        //    double ProbDataMinNow, ProbDataMaxNow;
        //    double ProbCumMin, ProbCumMax, gini, OPTGiniMin, OPTGiniMax;
        //    double finGini = 1;
        //    ProbDataMinNow = ProbDataMaxNow = ProbCumMin = ProbCumMax = gini = OPTGiniMin = OPTGiniMax = 0;
        //    for (int x = 0; x < featNum.Count; x += 3)
        //    {
        //        //untuk melooping class yang memungkinkan   
        //        for (int y = 0; y < parent.Count; y++)
        //        {
        //            //untuk melooping data yang tersedia
        //            for (int z = 0; z < listFeats.Count; z++)
        //            {
        //                if (listClass[z] == parent[y])
        //                {
        //                    //ketika memanggil method f1 check jika parentnya sudah sesuai
        //                    if (curFeat == z)
        //                    {
        //                        if (int.Parse(listFeats[z]) < featNum[x])
        //                            //menambahkan jika sudah cocok semua
        //                            DataMin++;
        //                        else
        //                            DataMax++;
        //                    }
        //                }
        //            }
        //            //untuk mendapatkan prob tiap opsi sesuai class
        //            ProbDataMinNow = (double)(DataMin) / (double)(featNum[x + 1]);
        //            ProbDataMaxNow = (double)(DataMax) / (double)(featNum[x + 2]);
        //            DataMax = 0;
        //            DataMin = 0;
        //            //menghitung prob pangkat 2nya ->kumulatif
        //            ProbCumMin += Math.Pow(ProbDataMinNow, 2);
        //            ProbCumMax += Math.Pow(ProbDataMaxNow, 2);
        //        }
        //        //hitung opsi Gini
        //        OPTGiniMax = 1 - ProbCumMax;
        //        OPTGiniMin = 1 - ProbCumMin;
        //        gini = (double)(featNum[x + 1]) / listFeats.Count * OPTGiniMin + (double)(featNum[x + 2]) / listFeats.Count * OPTGiniMax;
        //        //check apakah bernilai terkecil
        //        if (gini < finGini)
        //        {
        //            finGini = gini;
        //        }
        //        ProbCumMin = 0;
        //        ProbCumMax = 0;
        //    }
        //    return Math.Round(finGini, 2);
        //}

        #endregion

        public FormGINI()
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

        #region Button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!calculated)
                {
                    // Clear listbox
                    listBoxInfo.Items.Clear();

                    if (!FormUtama.giniCalculated)
                    {
                        // Class Parent Calculation
                        List<int> listParentCount = new List<int>();
                        for (int cNum = 0; cNum < FormUtama.classNumber; cNum++)
                        {
                            int count = Feat.AmbilParent(FormUtama.listClass[cNum]);
                            listParentCount.Add(count);
                        }
                        FormUtama.totalParent = listParentCount.Sum();

                        // Gini Parent Calculation
                        FormUtama.giniParent = 1;
                        foreach (int cCount in listParentCount)
                        {
                            double temp = Math.Pow(((double)cCount / (double)FormUtama.totalParent), 2);
                            FormUtama.giniParent -= temp;
                        }
                    }
                    
                    // Tampilkan gini ke listbox
                    listBoxInfo.Items.Add("Gini Parent: " + FormUtama.giniParent);

                    // Foreach Feat Gini Calculation
                    for (int fnum = 1; fnum <= FormUtama.featNumber; fnum++)
                    {
                        if (!FormUtama.giniCalculated)
                        {
                            List<string> listParameter = Feat.AmbilData(fnum);
                            double sigma = 0;

                            #region IsNumber
                            if (!IsNumber(listParameter))
                            {
                                #region Data Categorical Calculation
                                // kalau isi listParameter lebih dari 5
                                if (listParameter.Count > 5)
                                {
                                    throw new ArgumentException("Jumlah jenis nilai yang berbeda pada Feat " + fnum.ToString() + " melebihi 5");
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
                                            int dataCount = Feat.HitungData(fnum, kelas, parameter);
                                            listDataCount.Add(dataCount);
                                        }
                                        int totalData = listDataCount.Sum();

                                        // untuk setiap jumlah data di list
                                        double giniFeat = 1;
                                        foreach (int dCount in listDataCount)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            giniFeat -= Math.Pow(x, 2);
                                        }

                                        sigma += (double)totalData / (double)FormUtama.totalParent * giniFeat;
                                    }

                                    FormUtama.listFeatGini.Add(sigma);

                                    double gain = FormUtama.giniParent - sigma;
                                    FormUtama.listGiniGain.Add(gain);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Data Continuous Calculation
                                // kalau isi listParameter lebih dari 5
                                if (listParameter.Count > 5)
                                {
                                    throw new ArgumentException("Jumlah jenis nilai yang berbeda pada Feat " + fnum.ToString() + " melebihi 5");
                                }
                                else
                                {
                                    listParameter.Sort();
                                    List<string> listMilestone = new List<string>();
                                    // untuk setiap angka
                                    for (int i = 0; i < listParameter.Count; i++)
                                    {
                                        if (i != listParameter.Count - 1)
                                        {
                                            int milestone = (int.Parse(listParameter[i]) + int.Parse(listParameter[i + 1])) / 2;
                                            listMilestone.Add(milestone.ToString());
                                        }
                                        else
                                        {
                                            if (int.Parse(listParameter[0]) < 10)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[0]) - 1).ToString());
                                            }
                                            else if (int.Parse(listParameter[0]) < 100)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[0]) - 5).ToString());
                                            }
                                            else if (int.Parse(listParameter[0]) < 1000)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[0]) - 10).ToString());
                                            }

                                            if (int.Parse(listParameter[listParameter.Count - 1]) < 10)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[listParameter.Count - 1]) + 1).ToString());
                                            }
                                            else if (int.Parse(listParameter[listParameter.Count - 1]) < 100)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[listParameter.Count - 1]) + 5).ToString());
                                            }
                                            else if (int.Parse(listParameter[listParameter.Count - 1]) < 1000)
                                            {
                                                listMilestone.Add((int.Parse(listParameter[listParameter.Count - 1]) + 10).ToString());
                                            }

                                            listMilestone.Sort();
                                        }
                                    }

                                    // untuk setiap parameter di list
                                    foreach (string milestone in listMilestone)
                                    {
                                        List<int> countLebihKecil = new List<int>();
                                        int totalData;
                                        double giniFeat;
                                        double M = 0;

                                        // untuk setiap kelas
                                        foreach (string kelas in FormUtama.listClass)
                                        {
                                            // menghitung data
                                            int dataCount = Feat.CariDataLebihKecil(fnum, kelas, milestone);
                                            countLebihKecil.Add(dataCount);
                                        }
                                        totalData = countLebihKecil.Sum();

                                        // untuk setiap jumlah data di list
                                        giniFeat = 1;
                                        foreach (int dCount in countLebihKecil)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            if (totalData != 0) giniFeat -= Math.Pow(x, 2);
                                            else giniFeat -= 0;
                                        }

                                        M += (double)totalData / (double)FormUtama.totalParent * giniFeat;

                                        List<int> countLebihBesar = new List<int>();
                                        // untuk setiap kelas
                                        foreach (string kelas in FormUtama.listClass)
                                        {
                                            // menghitung data
                                            int dataCount = Feat.CariDataLebihBesar(fnum, kelas, milestone);
                                            countLebihBesar.Add(dataCount);
                                        }
                                        totalData = countLebihBesar.Sum();

                                        // untuk setiap jumlah data di list
                                        giniFeat = 1;
                                        foreach (int dCount in countLebihBesar)
                                        {
                                            double x = (double)dCount / (double)totalData;
                                            if (totalData != 0) giniFeat -= Math.Pow(x, 2);
                                            else giniFeat -= 0;
                                        }

                                        M += (double)totalData / (double)FormUtama.totalParent * giniFeat;

                                        FormUtama.listFeatGiniCon.Add(M);

                                        double gain = FormUtama.giniParent - M;
                                        FormUtama.listGiniConGain.Add(gain);
                                    }

                                    FormUtama.listFeatGini.Add(FormUtama.listFeatGiniCon.Min());
                                    FormUtama.listGiniGain.Add(FormUtama.listGiniConGain.Max());
                                }
                                #endregion
                            }
                            #endregion
                        }

                        // Tambahkan M ke listbox
                        listBoxInfo.Items.Add("");
                        listBoxInfo.Items.Add("Feat " + fnum);
                        listBoxInfo.Items.Add("------------");
                        listBoxInfo.Items.Add("Gini: " + FormUtama.listFeatGini[fnum-1].ToString());

                        // Tambahkan gain ke listbox
                        listBoxInfo.Items.Add("Gain: " + FormUtama.listGiniGain[fnum-1].ToString());
                    }

                    // Best Split
                    listBoxInfo.Items.Add("");
                    double bestSplit = FormUtama.listGiniGain.Max();
                    listBoxInfo.Items.Add("Best Split adalah Feat " + (FormUtama.listGiniGain.IndexOf(bestSplit) + 1).ToString() + " karena memiliki nilai gain terbesar diantara nilai gain atribut lainnya");

                    // Set supaya tidak ada perhitungan ulang
                    FormUtama.giniCalculated = true;

                    // Set supaya ga bisa spam button
                    calculated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

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
            //FormGINI frm = new FormGINI(); //Create Object
            //frm.Owner = this.Owner;
            //frm.Show();
            //this.Close();
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
