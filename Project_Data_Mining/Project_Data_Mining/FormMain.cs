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
    public partial class FormMain : Form
    {
        List<Dataset> listDataSet = new List<Dataset>(); //class kita menggunakan "Dataset" bukan "DataSet"
        int docs = 0;
        object feat1, feat2, feat3, feat4, feat5;
        string classes;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonProximityMatrix_Click(object sender, EventArgs e)
        {
            #region Manhattan
            textBoxData.AppendText("Manhattan");
            textBoxData.AppendText("\r\n"); //pindah baris baru
            double manhattan, distance = 0;
            for (int x = 0; x < listDataSet.Count; x++)
            {
                for (int y = 0; y < listDataSet.Count; y++)
                {
                    if (feat1 != null)
                    {
                        distance = Math.Abs(Convert.ToDouble(listDataSet[x].Feat1) - Convert.ToDouble(listDataSet[y].Feat1));
                    }
                    if (feat2 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[x].Feat2) - Convert.ToDouble(listDataSet[y].Feat2));
                    }
                    if (feat3 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[x].Feat3) - Convert.ToDouble(listDataSet[y].Feat3));
                    }
                    if (feat4 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[x].Feat4) - Convert.ToDouble(listDataSet[y].Feat4));
                    }
                    if (feat5 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[x].Feat5) - Convert.ToDouble(listDataSet[y].Feat5));
                    }
                    manhattan = Math.Round(distance, 2);
                    textBoxData.AppendText(manhattan.ToString().PadRight(10,' ')+" ");
                }
                textBoxData.AppendText("\r\n"); //pindah baris baru
            }
            #endregion

            #region Euclidean
            textBoxData.AppendText("Euclidean");
            textBoxData.AppendText("\r\n"); //pindah baris baru
            double euclidean, distance2 = 0;
            for (int i = 0; i < listDataSet.Count; i++)
            {
                for (int k = 0; k < listDataSet.Count; k++)
                {
                    if (feat1 != null)
                    {
                        distance2 = Math.Pow(Convert.ToDouble(listDataSet[i].Feat1) - Convert.ToDouble(listDataSet[k].Feat1), 2);
                    }
                    if (feat2 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat2) - Convert.ToDouble(listDataSet[k].Feat2), 2);
                    }
                    if(feat3 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat3) - Convert.ToDouble(listDataSet[k].Feat3), 2);
                    }
                    if (feat4 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat4) - Convert.ToDouble(listDataSet[k].Feat4), 2);
                    }
                    if (feat5 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat5) - Convert.ToDouble(listDataSet[k].Feat5),2);
                    }
                    euclidean = Math.Round(Math.Sqrt(distance2), 2);
                    textBoxData.AppendText(euclidean.ToString().PadRight(10, ' ') + " ");
                }
                textBoxData.AppendText("\r\n"); //pindah baris baru
            }
            #endregion

            #region Supreme
            textBoxData.AppendText("Supreme");
            textBoxData.AppendText("\r\n"); //pindah baris baru
            double supreme, distance3 = 0;
            double f1, f2, f3, f4, f5;
            for (int i = 0; i < listDataSet.Count; i++)
            {
                for (int k = 0; k < listDataSet.Count; k++)
                {
                    if (feat1 != null)
                    {
                        f1 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat1) - Convert.ToDouble(listDataSet[k].Feat1));
                        distance3 = f1;
                    }
                    if (feat2 != null)
                    {
                        f2 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat2) - Convert.ToDouble(listDataSet[k].Feat2));
                        if (distance3<f2)
                        {
                            distance3 = f2;
                        }
                    }
                    if (feat3 != null)
                    {
                        f3 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat3) - Convert.ToDouble(listDataSet[k].Feat3));
                        if (distance3 < f3)
                        {
                            distance3 = f3;
                        }
                    }
                    if (feat4 != null)
                    {
                        f4 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat4) - Convert.ToDouble(listDataSet[k].Feat4));
                        if (distance3 < f4)
                        {
                            distance3 = f4;
                        }
                    }
                    if (feat5 != null)
                    {
                        f5 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat5) - Convert.ToDouble(listDataSet[k].Feat5));
                        if (distance3 < f5)
                        {
                            distance3 = f5;
                        }
                    }
                    supreme = distance3;
                    textBoxData.AppendText(supreme.ToString().PadRight(10, ' ') + " ");
                }
                textBoxData.AppendText("\r\n"); //pindah baris baru
            }
            #endregion
        }

        private void buttonGINI_Click(object sender, EventArgs e)
        {
            textBoxData.AppendText("GINI");
            textBoxData.AppendText("\r\n");
            double gain1, gain2, gain3, gain4, gain5, gini1, gini2, gini3, gini4, gini5;
            gini1 = gini2 = gini3 = gini4 = gini5 = 0;

            #region Class
            var parent = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
            List<string> listClassDocs = new List<string>();
            double giniTotal = 0;
            foreach (var x in parent)
            {
                //Melakukan penghitungan class;
                listClassDocs.Add(x.Value);
                giniTotal += Math.Pow((double)(x.Count) / (double)(listDataSet.Count), 2);
            }
            double giniFinal = Math.Round(1 - giniTotal,3);
            textBoxData.AppendText("GINI Parent : " + giniFinal.ToString());
            textBoxData.AppendText("\r\n");
            #endregion

            #region Feat1
            //.GroupBy untuk mengelompokkan value berdasarkan kategori tertentu
            //(misalnya ditemukan "id", dapat dipanggil dengan cara x.nationally)
            //pengelompokkan data berdasar nationally
            var f1 = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Count);

            //Mencari semua kemungkinan value
            List<string> listf1 = new List<string>();
            foreach (var i in f1)
            {
                listf1.Add(i.Value.ToString());
                listf1.Add(i.Count.ToString());
            }

            //melakukan checking data angka atau string
            double check = 0;
            if (double.TryParse(listDataSet[0].Feat1.ToString(),out check) == true)
            {
                gini1 = CountGiniFNum(listf1, listClassDocs, listDataSet, 1);
            }
            else
            {
                gini1 = CountGiniFString(listf1, listClassDocs, listDataSet, 1);
            }
            textBoxData.AppendText("GINI Feat 1 = " + gini1.ToString() + "\r\n");
            #endregion

            #region Feat2
            //melakukan hal yang sama seperti f1
            var f2 = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Count);

            //Mencari semua kemungkinan value
            List<string> listf2 = new List<string>();
            foreach (var i in f2)
            {
                listf2.Add(i.Value.ToString());
                listf2.Add(i.Count.ToString());
            }

            //melakukan checking data angka atau string
            double check1 = 0;
            if (double.TryParse(listDataSet[1].Feat2.ToString(), out check1) == true)
            {
                gini2 = CountGiniFNum(listf2, listClassDocs, listDataSet, 2);
            }
            else
            {
                gini2 = CountGiniFString(listf2, listClassDocs, listDataSet, 2);
            }
            textBoxData.AppendText("GINI Feat 2 = " + gini2.ToString() + "\r\n");
            #endregion

            #region Feat3
            //melakukan hal yang sama seperti f1
            var f3 = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Count);

            //Mencari semua kemungkinan value
            List<string> listf3 = new List<string>();
            foreach (var i in f3)
            {
                listf3.Add(i.Value.ToString());
                listf3.Add(i.Count.ToString());
            }

            //melakukan checking data angka atau string
            double check2 = 0;
            if (double.TryParse(listDataSet[2].Feat3.ToString(), out check2) == true)
            {
                gini3 = CountGiniFNum(listf3, listClassDocs, listDataSet, 3);
            }
            else
            {
                gini3 = CountGiniFString(listf3, listClassDocs, listDataSet, 3);
            }
            textBoxData.AppendText("GINI Feat 3 = " + gini3.ToString() + "\r\n");
            #endregion

            #region Feat4
            //melakukan hal yang sama seperti f1
            var f4 = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Count);

            //Mencari semua kemungkinan value
            List<string> listf4 = new List<string>();
            foreach (var i in f4)
            {
                listf4.Add(i.Value.ToString());
                listf4.Add(i.Count.ToString());
            }

            //melakukan checking data angka atau string
            double check3 = 0;
            if (double.TryParse(listDataSet[3].Feat4.ToString(), out check3) == true)
            {
                gini4 = CountGiniFNum(listf4, listClassDocs, listDataSet, 3);
            }
            else
            {
                gini4 = CountGiniFString(listf4, listClassDocs, listDataSet, 3);
            }
            textBoxData.AppendText("GINI Feat 4 = " + gini4.ToString() + "\r\n");
            #endregion

            #region Feat5 
            //melakukan hal yang sama seperti f1
            var f5 = listDataSet.GroupBy(x => x.Classes).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Count);

            //Mencari semua kemungkinan value
            List<string> listf5 = new List<string>();
            foreach (var i in f5)
            {
                listf5.Add(i.Value.ToString());
                listf5.Add(i.Count.ToString());
            }

            //melakukan checking data angka atau string
            double check4 = 0;
            if (double.TryParse(listDataSet[4].Feat5.ToString(), out check4) == true)
            {
                gini5 = CountGiniFNum(listf5, listClassDocs, listDataSet, 5);
            }
            else
            {
                gini5 = CountGiniFString(listf5, listClassDocs, listDataSet, 5);
            }
            textBoxData.AppendText("GINI Feat 5 = " + gini5.ToString() + "\r\n");
            #endregion

            #region FindBestGain
            int marking;
            double bestGain;
            if (feat1 != null)
            {
                gain1 = 1 - gini1;
                bestGain = gain1;
                marking = 1;
                textBoxData.AppendText("Gain Feat 1 = " + gain1 + "\r\n");
                if (feat2 != null)
                {
                    gain2 = 1 - gini2;
                    marking = 2;
                    textBoxData.AppendText("Gain Feat 2 = " + gain2 + "\r\n");
                    if (gain2 > bestGain)
                    {
                        bestGain = gain2;
                    }
                    if (feat3 != null)
                    {
                        gain3 = 1 - gini3;
                        textBoxData.AppendText("Gain Feat 3 = " + gain3 + "\r\n");
                        if (gain3 > bestGain)
                        {
                            bestGain = gain3;
                        }
                        marking = 3;
                        if (feat4 != null)
                        {
                            gain4 = 1 - gini4;
                            textBoxData.AppendText("Gain Feat 4 = " + gain4 + "\r\n");
                            if (gain4>bestGain)
                            {
                                bestGain = gain4;
                                marking = 4;
                            }
                            if (feat5!=null)
                            {
                                gain5 = 1 - gini5;
                                textBoxData.AppendText("Gain Feat 5 = " + gain4 + "\r\n");
                                if (gain5 > bestGain)
                                {
                                    bestGain = gain5;
                                }
                            }
                        }
                    }
                }
                if (marking == 1)
                {
                    textBoxData.AppendText("Feat 1 is the best split. Use it");
                }
                if (marking == 2)
                {
                    textBoxData.AppendText("Feat 2 is the best split. Use it");
                }
                if (marking == 3)
                {
                    textBoxData.AppendText("Feat 3 is the best split. Use it");
                }
                if (marking == 4)
                {
                    textBoxData.AppendText("Feat 4 is the best split. Use it");
                }
                if (marking == 5)
                {
                    textBoxData.AppendText("Feat 5 is the best split. Use it");
                }
            }
            #endregion
        }
        #region Method
        public static double CountGiniFString(List<string>Feat,List<string>parent,List<Dataset>dataSet,int curFeat)
        {
            int count = 0;
            double probabilityNow, GINI = 0;
            double probabilityCum = 0;
            for (int x = 0; x < Feat.Count; x+=2)
            {
                //looping class yang mungkin
                for (int y = 0; y < parent.Count; y++)
                {
                    //looping semua data yang ada
                    for (int z = 0; z < dataSet.Count; z++)
                    {
                        //ketika method dipanggil di region feat1
                        if (curFeat == 1)
                        {
                            //cek apakah data ini sama dengan feat yang dicari
                            if (dataSet[z].Feat1.ToString()==Feat[x])
                            {
                                //cek apakah sesuai dengan parent
                                if (dataSet[z].Classes == parent[y])
                                {
                                    count++;
                                }
                            }
                        }
                        if (curFeat == 2)
                        {
                            //cek apakah data ini sama dengan feat yang dicari
                            if (dataSet[z].Feat2.ToString() == Feat[x])
                            {
                                //cek apakah sesuai dengan parent
                                if (dataSet[z].Classes == parent[y])
                                {
                                    count++;
                                }
                            }
                        }
                        if (curFeat == 3)
                        {
                            //cek apakah data ini sama dengan feat yang dicari
                            if (dataSet[z].Feat3.ToString() == Feat[x])
                            {
                                //cek apakah sesuai dengan parent
                                if (dataSet[z].Classes == parent[y])
                                {
                                    count++;
                                }
                            }
                        }
                        if (curFeat == 4)
                        {
                            //cek apakah data ini sama dengan feat yang dicari
                            if (dataSet[z].Feat4.ToString() == Feat[x])
                            {
                                //cek apakah sesuai dengan parent
                                if (dataSet[z].Classes == parent[y])
                                {
                                    count++;
                                }
                            }
                        }
                        if (curFeat == 5)
                        {
                            //cek apakah data ini sama dengan feat yang dicari
                            if (dataSet[z].Feat5.ToString() == Feat[x])
                            {
                                //cek apakah sesuai dengan parent
                                if (dataSet[z].Classes == parent[y])
                                {
                                    count++;
                                }
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
                GINI += double.Parse(Feat[x + 1]) / dataSet.Count * GINIOpt;
                //bersihkan probalitycum
                probabilityCum = 0;
            }
            return Math.Round(GINI, 2);
        }
        public static double CountGiniFNum(List<string> Feat, List<string> parent, List<Dataset> dataSet, int curFeat)
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
                    for (int y = 0; y < dataSet.Count; y++)
                    {
                        if (curFeat == 1)
                        {
                            if (int.Parse(dataSet[y].Feat1.ToString())<median)
                                min++;
                            else
                                max++;
                        }
                        if (curFeat == 2)
                        {
                            if (int.Parse(dataSet[y].Feat2.ToString()) < median)
                                min++;
                            else
                                max++;
                        }
                        if (curFeat == 3)
                        {
                            if (int.Parse(dataSet[y].Feat3.ToString()) < median)
                                min++;
                            else
                                max++;
                        }
                        if (curFeat == 4)
                        {
                            if (int.Parse(dataSet[y].Feat4.ToString()) < median)
                                min++;
                            else
                                max++;
                        }
                        if (curFeat == 5)
                        {
                            if (int.Parse(dataSet[y].Feat5.ToString()) < median)
                                min++;
                            else
                                max++;
                        }   
                    }
                    //store nilai min dan max ke list
                    featNum.Add(min);
                    featNum.Add(max);
                    //bersihkan nilai min dan max
                    min = 0;max = 0;
                }
            }
            int DataMin = 0;
            int DataMax = 0;
            double ProbDataMinNow, ProbDataMaxNow;
            double ProbCumMin, ProbCumMax, gini, OPTGiniMin, OPTGiniMax;
            double finGini = 1;
            ProbDataMinNow = ProbDataMaxNow = ProbCumMin = ProbCumMax = gini = OPTGiniMin = OPTGiniMax = 0;
            for (int x = 0; x < featNum.Count; x+=3)
            {
                //untuk melooping class yang memungkinkan   
                for (int y = 0; y < parent.Count; y++)
                {
                    //untuk melooping data yang tersedia
                    for (int z = 0; z < dataSet.Count; z++)
                    {
                        if (dataSet[z].Classes == parent[y])
                        {
                            //ketika memanggil method f1 check jika parentnya sudah sesuai
                            if (curFeat == 1)
                            {
                                if (int.Parse(dataSet[z].Feat1.ToString()) < featNum[x])
                                    //menambahkan jika sudah cocok semua
                                    DataMin++;
                                else
                                    DataMax++;
                            }
                            if (curFeat == 2)
                            {
                                if (int.Parse(dataSet[z].Feat2.ToString()) < featNum[x])
                                    //menambahkan jika sudah cocok semua
                                    DataMin++;
                                else
                                    DataMax++;
                            }
                            if (curFeat == 3)
                            {
                                if (int.Parse(dataSet[z].Feat3.ToString()) < featNum[x])
                                    //menambahkan jika sudah cocok semua
                                    DataMin++;
                                else
                                    DataMax++;
                            }
                            if (curFeat == 4)
                            {
                                if (int.Parse(dataSet[z].Feat4.ToString()) < featNum[x])
                                    //menambahkan jika sudah cocok semua
                                    DataMin++;
                                else
                                    DataMax++;
                            }
                            if (curFeat == 5)
                            {
                                if (int.Parse(dataSet[z].Feat5.ToString()) < featNum[x])
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
                gini = (double)(featNum[x + 1]) / dataSet.Count * OPTGiniMin + (double)(featNum[x + 2]) / dataSet.Count * OPTGiniMax;
                //check apakah bernilai terkecil
                if (gini<finGini)
                {
                    finGini = gini;
                }
                ProbCumMin = 0;
                ProbCumMax = 0;
            }
            return Math.Round(finGini, 2);
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            numericUpDownNumOfFeat.Value = 1;
            numericUpDownNumOfDocs.Value = docs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownNumOfFeat.Value = 1;
            numericUpDownNumOfDocs.Value = docs;
        }

        private void numericUpDownNumOfFeat_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNumOfFeat.Value == 1)
            {
                textBoxFeat1.Enabled = true;
                textBoxFeat2.Enabled = false;
                textBoxFeat3.Enabled = false;
                textBoxFeat4.Enabled = false;
                textBoxFeat5.Enabled = false;
            }
            else if (numericUpDownNumOfFeat.Value == 2)
            {
                textBoxFeat1.Enabled = true;
                textBoxFeat2.Enabled = true;
                textBoxFeat3.Enabled = false;
                textBoxFeat4.Enabled = false;
                textBoxFeat5.Enabled = false;
            }
            else if (numericUpDownNumOfFeat.Value == 3)
            {
                textBoxFeat1.Enabled = true;
                textBoxFeat2.Enabled = true;
                textBoxFeat3.Enabled = true;
                textBoxFeat4.Enabled = false;
                textBoxFeat5.Enabled = false;
            }
            else if (numericUpDownNumOfFeat.Value == 4)
            {
                textBoxFeat1.Enabled = true;
                textBoxFeat2.Enabled = true;
                textBoxFeat3.Enabled = true;
                textBoxFeat4.Enabled = true;
                textBoxFeat5.Enabled = false;
            }
            else if (numericUpDownNumOfFeat.Value == 5)
            {
                textBoxFeat1.Enabled = true;
                textBoxFeat2.Enabled = true;
                textBoxFeat3.Enabled = true;
                textBoxFeat4.Enabled = true;
                textBoxFeat5.Enabled = true;
            }
            else
            {
                textBoxFeat1.Enabled = false;
                textBoxFeat2.Enabled = false;
                textBoxFeat3.Enabled = false;
                textBoxFeat4.Enabled = false;
                textBoxFeat5.Enabled = false;
            }
            textBoxClass.Enabled = true;
            buttonGINI.Enabled = true;
            buttonProximityMatrix.Enabled = true;
            buttonAdd.Enabled = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            textBoxFeat1.Text = "";
            textBoxFeat2.Text = "";
            textBoxFeat3.Text = "";
            textBoxFeat4.Text = "";
            textBoxFeat5.Text = "";
            textBoxClass.Text = "";
            numericUpDownNumOfDocs.Value = 0;
            numericUpDownNumOfFeat.Value = 0;
            textBoxFeat1.Enabled = false;
            textBoxFeat2.Enabled = false;
            textBoxFeat3.Enabled = false;
            textBoxFeat4.Enabled = false;
            textBoxFeat5.Enabled = false;
            textBoxClass.Enabled = false;
            buttonAdd.Enabled = false;
            buttonGINI.Enabled = false;
            buttonProximityMatrix.Enabled = false;

            listDataSet.Clear();
            textBoxData.Clear();
            docs = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonRestart.Enabled = true;
            if (textBoxClass.Text == null) 
            { 
                textBoxClass.Text = ""; 
            }
            classes = textBoxClass.Text;
            if (textBoxFeat1.Enabled)
            {
                feat1 = textBoxFeat1.Text;
            }
            if (textBoxFeat2.Enabled)
            {
                feat2 = textBoxFeat2.Text;
            }
            if (textBoxFeat3.Enabled)
            {
                feat3 = textBoxFeat3.Text;
            }
            if (textBoxFeat4.Enabled)
            {
                feat4 = textBoxFeat4.Text;
            }
            if (textBoxFeat5.Enabled)
            {
                feat5 = textBoxFeat5.Text;
            }
            Dataset ds = new Dataset(docs,feat1,feat2,feat3,feat4,feat5,classes);
            listDataSet.Add(ds);
            textBoxData.AppendText(
                "Docs : " + listDataSet[docs].Docs +
                " Feat 1 : " + listDataSet[docs].Feat1 +
                " Feat 2 : " + listDataSet[docs].Feat2 +
                " Feat 3 : " + listDataSet[docs].Feat3 +
                " Feat 4 : " + listDataSet[docs].Feat4 +
                " Feat 5 : " + listDataSet[docs].Feat5 +
                " Class : " + listDataSet[docs].Classes);
            textBoxData.AppendText("\r\n");

            docs++;
            numericUpDownNumOfDocs.Value = docs;
        }
    }
}
