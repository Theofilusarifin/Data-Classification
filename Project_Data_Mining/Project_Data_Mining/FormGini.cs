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
        List<string> listClass = FormUtama.listClass;
        List<Data> listData = Data.BacaData();

        #region Method
        public static double CountGiniFString(List<string> Feat, List<string> parent, List<string> listFeats, List<string> listClass, int curFeat)
        {
            int count = 0;
            double probabilityNow, GINI = 0;
            double probabilityCum = 0;
            for (int x = 0; x < Feat.Count; x += 2)
            {
                //looping class yang mungkin
                for (int y = 0; y < parent.Count; y++)
                {
                    //looping semua data yang ada
                    for (int z = 0; z < listFeats.Count; z++)
                    {
                        //cek apakah data ini sama dengan feat yang dicari
                        if (listFeats[z] == Feat[x])
                        {
                            //cek apakah sesuai dengan parent
                            if (listClass[z] == parent[y])
                            {
                                count++;
                            }
                        }
                    }
                    //dapat probability tiap opsi sesuai class
                    probabilityNow = (double)(count) / double.Parse(Feat[x + 1]);
                    //bersihkan nilai count
                    count = 0;
                    //hitung probabilitas kuadratnya ->kumulatif
                    probabilityCum += Math.Pow(probabilityNow, 2);
                }
                //hitung GINI opsi
                double GINIOpt = 1 - probabilityCum;//sudah benar hasilnya;
                GINI += double.Parse(Feat[x + 1]) / listFeats.Count * GINIOpt;
                //bersihkan probalitycum
                probabilityCum = 0;
            }
            return Math.Round(GINI, 2);
        }
        public static double CountGiniFNum(List<string> Feat, List<string> parent, List<string> listFeats, List<string> listClass , int curFeat)
        {
            int min = 0;
            int max = 0;
            int median = 0;
            List<int> featNum = new List<int>(); //opsi feat 1
                                                 //kalau benar, cari nilai tengahnya
            for (int x = 0; x < Feat.Count; x += 2)
            {
                //cek sekarang iterasi ke berapa, jgn lanjutkan proses bila sdh n-2
                if (x < Feat.Count - 2)
                {
                    median = (int)(double.Parse(Feat[x]) + double.Parse(Feat[x + 2])) / 2;
                    featNum.Add(median);
                    for (int y = 0; y < listFeats.Count; y++)
                    {
                        if (curFeat == y)
                        {
                            if (int.Parse(listFeats[y]) < median)
                                min++;
                            else
                                max++;
                        }
                    }
                    //store nilai min dan max ke list
                    featNum.Add(min);
                    featNum.Add(max);
                    //bersihkan nilai min dan max
                    min = 0; max = 0;
                }
            }
            int DataMin = 0;
            int DataMax = 0;
            double ProbDataMinNow, ProbDataMaxNow;
            double ProbCumMin, ProbCumMax, gini, OPTGiniMin, OPTGiniMax;
            double finGini = 1;
            ProbDataMinNow = ProbDataMaxNow = ProbCumMin = ProbCumMax = gini = OPTGiniMin = OPTGiniMax = 0;
            for (int x = 0; x < featNum.Count; x += 3)
            {
                //untuk melooping class yang memungkinkan   
                for (int y = 0; y < parent.Count; y++)
                {
                    //untuk melooping data yang tersedia
                    for (int z = 0; z < listFeats.Count; z++)
                    {
                        if (listClass[z] == parent[y])
                        {
                            //ketika memanggil method f1 check jika parentnya sudah sesuai
                            if (curFeat == z)
                            {
                                if (int.Parse(listFeats[z]) < featNum[x])
                                    //menambahkan jika sudah cocok semua
                                    DataMin++;
                                else
                                    DataMax++;
                            }
                        }
                    }
                    //untuk mendapatkan prob tiap opsi sesuai class
                    ProbDataMinNow = (double)(DataMin) / (double)(featNum[x + 1]);
                    ProbDataMaxNow = (double)(DataMax) / (double)(featNum[x + 2]);
                    DataMax = 0;
                    DataMin = 0;
                    //menghitung prob pangkat 2nya ->kumulatif
                    ProbCumMin += Math.Pow(ProbDataMinNow, 2);
                    ProbCumMax += Math.Pow(ProbDataMaxNow, 2);
                }
                //hitung opsi Gini
                OPTGiniMax = 1 - ProbCumMax;
                OPTGiniMin = 1 - ProbCumMin;
                gini = (double)(featNum[x + 1]) / listFeats.Count * OPTGiniMin + (double)(featNum[x + 2]) / listFeats.Count * OPTGiniMax;
                //check apakah bernilai terkecil
                if (gini < finGini)
                {
                    finGini = gini;
                }
                ProbCumMin = 0;
                ProbCumMax = 0;
            }
            return Math.Round(finGini, 2);
        }

        #endregion

        public FormGINI()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            #region class
            var parent = listClass.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
            List<string> listDocClass = new List<string>();
            double ginTotal = 0;
            foreach (var x in parent)
            {
                //Melakukan penghitungan class;
                listDocClass.Add(x.Value);
                ginTotal += Math.Pow((double)(x.Count) / (double)(listData.Count), 2);
            }
            double giniFinal = Math.Round(1 - ginTotal, 3);
            listBoxInfo.Items.Add("Gini Parent = " + ginTotal.ToString());
            #endregion

            #region Feats
            double gini = 0;
            var feat = listClass.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
            List<string> listfeat = new List<string>();
            List<string> listFeats = FormUtama.listClass;
            foreach (var x in feat)
            {
                listfeat.Add(x.Value.ToString());
                listfeat.Add(x.Count.ToString());
            }
            for (int i = 0; i < listData.Count; i++)
            {
                if (double.TryParse(listData[i].ListFeat.ToString(), out double check) == true)
                {
                    gini = CountGiniFNum(listfeat, listDocClass, listFeats, listClass,i);
                }
                else
                {
                    gini = CountGiniFString(listfeat, listDocClass, listFeats, listClass,i);
                }
                listBoxInfo.Items.Add("GINI Feat " + (i + 1) + " : " + gini);
            }
            #endregion

            #region BestGain
            double gain = 0;
            double marking = 0;
            double bestGain = 0;
            for (int i = 0; i < listData.Count; i++)
            {
                if (double.TryParse(listData[i].ListFeat.ToString(), out double check) == true)
                {
                    gini = CountGiniFNum(listfeat, listDocClass, listFeats, listClass, i);
                }
                else
                {
                    gini = CountGiniFString(listfeat, listDocClass, listFeats, listClass,i);
                }
                marking = i;
                gain = 1 - gini;
                bestGain = gain;
                if (gain > bestGain)
                    bestGain = gain;
            }
            for (int z = 0; z < listfeat.Count; z++)
            {
                if (z == marking)
                {
                    listBoxInfo.Items.Add("Feat " + (z + 1) + " is the best split. Use it");
                }
            }
            #endregion
        }

        #region MenuStrip
        private void approximityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResult frm = new FormResult(); //Create Object
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
