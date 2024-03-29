﻿using System;
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
        public static int classNumber;

        public static List<string> listClass = new List<string>();
        public static int totalParent = 0;

        // Untuk Aproximity Matrix
        public static List<Data> listData = new List<Data>();
        public static bool dataReaded = false;

        // Untuk Gini
        public static List<double> listFeatGini = new List<double>();
        public static List<double> listGiniGain = new List<double>();
        public static List<double> listFeatGiniCon = new List<double>();
        public static List<double> listGiniConGain = new List<double>();
        public static bool giniCalculated = false;
        public static double giniParent = 0;

        // untuk Entropy
        public static List<double> listFeatEntropy = new List<double>();
        public static List<double> listEntropyGain = new List<double>();
        public static List<double> listFeatEntropyCon = new List<double>();
        public static List<double> listEntropyConGain = new List<double>();
        public static bool entropyCalculated = false;
        public static double entropyParent = 0;

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

        #region FormLoad
        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;
            pictureBoxDev.Parent = panelBackground;
            pictureBoxHelp.Parent = panelBackground;
            this.BackgroundImage = Properties.Resources.Form_Utama;
        }
        #endregion

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

        #region Button
        private void buttonGetStarted_Click(object sender, EventArgs e)
        {
            try
            {
                //Ambil nilai di db setting
                koneksi = new Koneksi();

                // Reset Variabel

                // Global
                featNumber = 0;
                classNumber = 0;
                listClass.Clear();
                totalParent = 0;

                // Untuk Aproximity Matrix
                listData.Clear();
                dataReaded = false;

                // Untuk Gini
                listFeatGini.Clear();
                listGiniGain.Clear();
                listFeatGiniCon.Clear();
                listGiniConGain.Clear();                
                giniCalculated = false;
                giniParent = 0;

                // Untuk Entropy
                listFeatEntropy.Clear();
                listEntropyGain.Clear();
                listFeatEntropyCon.Clear();
                listEntropyConGain.Clear();
                entropyCalculated = false;
                entropyParent = 0;

                //Melakuan drop dan membuat kembali table pada database agar data kembali kosong
                Koneksi.JalankanPerintahDML("DROP TABLE IF EXISTS feats;");
                Koneksi.JalankanPerintahDML("DROP TABLE IF EXISTS datas;");
                Koneksi.JalankanPerintahDML("DROP TABLE IF EXISTS classes;");
                Koneksi.JalankanPerintahDML("CREATE TABLE datas (document_id VARCHAR(50) NOT NULL, PRIMARY KEY (document_id));");
                Koneksi.JalankanPerintahDML("CREATE TABLE classes (id VARCHAR(50) NOT NULL, PRIMARY KEY (id))");
                Koneksi.JalankanPerintahDML("CREATE TABLE feats (id INT UNSIGNED NOT NULL AUTO_INCREMENT, document_id VARCHAR(50) NOT NULL, class_id VARCHAR(50) NOT NULL, feat_id INT NULL, nilai VARCHAR(50) NULL, PRIMARY KEY (id), INDEX fk_feats_datas_idx (document_id ASC), INDEX fk_feats_classes1_idx (class_id ASC), CONSTRAINT fk_feats_datas FOREIGN KEY (document_id) REFERENCES datas (document_id) ON DELETE NO ACTION ON UPDATE NO ACTION, CONSTRAINT fk_feats_classes1 FOREIGN KEY (class_id) REFERENCES classes (id) ON DELETE NO ACTION ON UPDATE NO ACTION)");

                //Buka Form
                Form form = Application.OpenForms["FormInputFeatNumber"];

                if (form == null) //Jika Form ini belum di-create sebelumnya
                {
                    FormInputFeatNumber frm = new FormInputFeatNumber(); //Create Object FormInputFeatNumber
                    frm.Owner = this; //Set form utama menjadi parent dari objek form yang dibuat
                    frm.ShowDialog(); //Tampilkan form
                                      // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
                    frm.BringToFront(); //Agar form tampil di depan
                }
                else
                {
                    form.Show();
                    form.BringToFront(); //Agar form tampil di depan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan Kesalahan : " + ex.Message);
            }
        }
        #endregion

        #region PictureBox
        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            //Buka Form
            Form form = Application.OpenForms["FormHelp"];

            if (form == null) //Jika Form ini belum di-create sebelumnya
            {
                FormHelp frm = new FormHelp(); //Create Object
                frm.Owner = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.ShowDialog(); //Tampilkan form
                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
                frm.BringToFront(); //Agar form tampil di depan
            }
            else
            {
                form.Show();
                form.BringToFront(); //Agar form tampil di depan
            }
        }

        private void pictureBoxDev_Click(object sender, EventArgs e)
        {
            //Buka Form
            Form form = Application.OpenForms["FormDeveloper"];

            if (form == null) //Jika Form ini belum di-create sebelumnya
            {
                FormDeveloper frm = new FormDeveloper(); //Create Object
                frm.Owner = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.ShowDialog(); //Tampilkan form
                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
                frm.BringToFront(); //Agar form tampil di depan
            }
            else
            {
                form.Show();
                form.BringToFront(); //Agar form tampil di depan
            }
        }
        #endregion
    }
}
