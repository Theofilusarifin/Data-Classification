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

        private void FormResult_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double manhattan, euclidean, supreme;
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
                for (int x = 0; x < DataClass.DataMemberCount; x++)
                {
                    for (int y = 0; y < DataClass.DataMemberCount; y++)
                    {
                        euclidean =
                        Math.Pow(Convert.ToDouble(Feat1[x]) - Convert.ToDouble(Feat1[y]), 2) +
                        Math.Pow(Convert.ToDouble(Feat2[x]) - Convert.ToDouble(Feat2[y]), 2);

                        euclidean = Math.Round(Math.Sqrt(euclidean), 2);
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
