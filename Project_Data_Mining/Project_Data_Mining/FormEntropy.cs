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
        List<Class> listDistinctClass = new List<Class>();
        List<Class> listClass = new List<Class>();

        public FormEntropy()
        {
            InitializeComponent();
        }

        #region Method

        #endregion

        private void FormEntropy_Load(object sender, EventArgs e)
        {
            //listDistinctClass = Class.BacaData();

            //foreach(Class kelas in listDistinctClass)
            //{
            //    listClass = Class.BacaData(kelas.Id);
            //}
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

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
