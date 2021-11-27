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
    public partial class FormInputFeatNumber : Form
    {
        public FormInputFeatNumber()
        {
            InitializeComponent();
        }

        private string sql = "CREATE TABLE data(document_id VARCHAR(50) NOT NULL, ";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            Koneksi.JalankanPerintahDML("DROP TABLE IF EXISTS data;");

            FormUtama.featNumber = int.Parse(textBoxFeatNumber.Text);

            for (int i=1; i<=FormUtama.featNumber; i++)
            {
                sql += "feat"+ i +" INT, ";
            }
            sql += " PRIMARY KEY(document_id));";

            Koneksi.JalankanPerintahDML(sql);

            MessageBox.Show("Table telah berhasil di generate pada database", "Informasi");

            FormUploadData frm = new FormUploadData(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}