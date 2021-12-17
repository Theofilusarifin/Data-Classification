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
    public partial class FormInputFeatNumber : Form
    {
        public FormInputFeatNumber()
        {
            InitializeComponent();
        }

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        // membuat tabel data
        //private string sql = "CREATE TABLE data(document_id VARCHAR(50) NOT NULL, ";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDownFeatNumber.Value > 1 && numericUpDownFeatNumber.Value < 6)
                {
                    FormUtama.featNumber = (int)numericUpDownFeatNumber.Value;
                    FormUtama.classNumber = (int)numericUpDownClassNumber.Value;
                    MessageBox.Show("Data telah berhasil disimpan", "Informasi");

                    FormUploadData frm = new FormUploadData(); //Create Object
                    frm.Owner = this.Owner;
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data harus mempunyai lebih dari 1 dan kurang dari 6 feat");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region DesainButton
        private void buttonSubmit_MouseEnter(object sender, EventArgs e)
        {
            buttonSubmit.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonSubmit_MouseLeave(object sender, EventArgs e)
        {
            buttonSubmit.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
