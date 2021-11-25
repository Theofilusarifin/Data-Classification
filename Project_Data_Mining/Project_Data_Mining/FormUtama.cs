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
    public partial class FormUtama : Form
    {
        List<Dataset> listDataSet = new List<Dataset>(); //class kita menggunakan "Dataset" bukan "DataSet"
        int docs = 0;
        object feat1, feat2, feat3, feat4, feat5;
        string classes;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void buttonProximityMatrix_Click(object sender, EventArgs e)
        {
            #region Manhattan
            textBoxData.AppendText("Manhattan");
            textBoxData.AppendText("\r\n"); //pindah baris baru
            double manhattan, distance = 0;
            for (int i = 0; i < listDataSet.Count; i++)
            {
                for (int k = 0; k < listDataSet.Count; k++)
                {
                    if (feat1 != null)
                    {
                        distance = Math.Abs(Convert.ToDouble(listDataSet[i].Feat1)) - Convert.ToDouble(listDataSet[k].Feat1);
                    }
                    else if (feat2 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[i].Feat2)) - Convert.ToDouble(listDataSet[k].Feat2);
                    }
                    else if (feat3 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[i].Feat3)) - Convert.ToDouble(listDataSet[k].Feat3);
                    }
                    else if (feat4 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[i].Feat4)) - Convert.ToDouble(listDataSet[k].Feat4);
                    }
                    else if (feat5 != null)
                    {
                        distance += Math.Abs(Convert.ToDouble(listDataSet[i].Feat5)) - Convert.ToDouble(listDataSet[k].Feat5);
                    }
                    manhattan = Math.Round(distance, 2);
                    textBoxData.AppendText(manhattan.ToString().PadRight(5,' ')+" ");
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
                    else if (feat2 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat2) - Convert.ToDouble(listDataSet[k].Feat2), 2);
                    }
                    else if (feat3 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat3) - Convert.ToDouble(listDataSet[k].Feat3), 2);
                    }
                    else if (feat4 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat4) - Convert.ToDouble(listDataSet[k].Feat4), 2);
                    }
                    else if (feat5 != null)
                    {
                        distance2 += Math.Pow(Convert.ToDouble(listDataSet[i].Feat5) - Convert.ToDouble(listDataSet[k].Feat5),2);
                    }
                    euclidean = Math.Round(Math.Sqrt(distance2), 2);
                    textBoxData.AppendText(euclidean.ToString().PadRight(5, ' ') + " ");
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
                        f1 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat1)) - Convert.ToDouble(listDataSet[k].Feat1);
                        distance3 = f1;
                    }
                    if (feat2 != null)
                    {
                        f2 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat2)) - Convert.ToDouble(listDataSet[k].Feat2);
                        if (distance3<f2)
                        {
                            distance3 = f2;
                        }
                    }
                    if (feat3 != null)
                    {
                        f3 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat3)) - Convert.ToDouble(listDataSet[k].Feat3);
                        if (distance3 < f3)
                        {
                            distance3 = f3;
                        }
                    }
                    if (feat4 != null)
                    {
                        f4 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat4)) - Convert.ToDouble(listDataSet[k].Feat4);
                        if (distance3 < f4)
                        {
                            distance3 = f4;
                        }
                    }
                    if (feat5 != null)
                    {
                        f5 = Math.Abs(Convert.ToDouble(listDataSet[i].Feat5)) - Convert.ToDouble(listDataSet[k].Feat5);
                        if (distance3 < f5)
                        {
                            distance3 = f5;
                        }
                    }
                    supreme = distance3;
                    textBoxData.AppendText(supreme.ToString().PadRight(5, ' ') + " ");
                }
                textBoxData.AppendText("\r\n"); //pindah baris baru
            }
            #endregion
        }

        private void buttonGINI_Click(object sender, EventArgs e)
        {

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
            numericUpDownNumOfDocs.Enabled = true;
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
            numericUpDownNumOfDocs.Enabled = false;
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
            else if (textBoxFeat2.Enabled)
            {
                feat2 = textBoxFeat1.Text;
            }
            else if (textBoxFeat3.Enabled)
            {
                feat3 = textBoxFeat1.Text;
            }
            else if (textBoxFeat4.Enabled)
            {
                feat4 = textBoxFeat1.Text;
            }
            else if (textBoxFeat5.Enabled)
            {
                feat5 = textBoxFeat1.Text;
            }
            else
            {
                MessageBox.Show("There'is no feat.");
            }
            Dataset ds = new Dataset(docs,feat1,feat2,feat3,feat4,feat5,classes);
            listDataSet.Add(ds);
            textBoxData.AppendText(
                "Docs : " + listDataSet[docs].Docs +
                "Feat 1 : " + listDataSet[docs].Feat1 +
                "Feat 2 : " + listDataSet[docs].Feat2 +
                "Feat 3 : " + listDataSet[docs].Feat3 +
                "Feat 4 : " + listDataSet[docs].Feat4 +
                "Feat 5 : " + listDataSet[docs].Feat5 +
                "Class : " + listDataSet[docs].Classes);
            textBoxData.AppendText("\r\n");

            docs++;
            numericUpDownNumOfDocs.Value = docs;
        }
    }
}
