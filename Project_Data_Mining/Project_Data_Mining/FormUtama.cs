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
        public static Koneksi koneksi;
        public static int featNumber;

        public FormUtama()
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

        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;

            try
            {
                //Ambil nilai di db setting
                koneksi = new Koneksi();
                //MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            }
        }

        #region DesainButton
        private void buttonGetStarted_MouseEnter(object sender, EventArgs e)
        {
            buttonGetStarted.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonGetStarted_MouseLeave(object sender, EventArgs e)
        {
            buttonGetStarted.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

        private void buttonGetStarted_Click(object sender, EventArgs e)
        {
            //Buka Form
            Form form = Application.OpenForms["FormInputDeatNumber"];

            if (form == null) //Jika Form ini belum di-create sebelumnya
            {
                FormInputFeatNumber frm = new FormInputFeatNumber(); //Create Object FormInputFeatNumber
                frm.MdiParent = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.Show(); //Tampilkan form
                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
            }
            else
            {
                form.Show();
                form.BringToFront(); //Agar form tampil di depan
            }
        }
    }
}
