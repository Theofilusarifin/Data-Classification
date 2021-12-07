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
    }
}
