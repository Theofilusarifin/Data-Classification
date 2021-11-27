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

        private void FormUtama_Load(object sender, EventArgs e)
        {
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
    }
}
