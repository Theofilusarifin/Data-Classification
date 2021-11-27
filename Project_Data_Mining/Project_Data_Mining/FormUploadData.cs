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
using System.Data.OleDb;
//using System.Data.SqlClient;

namespace Project_Data_Mining
{
    public partial class FormUploadData : Form
    {
        public FormUploadData()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select File";
            fdlg.FileName = textBoxFileName.Text;
            fdlg.Filter = "All Files(*.*)|*.*|Excel Sheet (*.xls)|*.xls";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = fdlg.FileName;
            }
        }

        // To read the excel data into datagridview
        private void buttonImport_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + textBoxFileName.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"");
            
            theConnection.Open();

            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", theConnection);

            DataSet theSD = new DataSet();
            DataTable dt = new DataTable();
            theDataAdapter.Fill(dt);
            this.dataGridView.DataSource = dt.DefaultView;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dataGridView.Rows.Count-1; x++)
            {
                string sql = "insert into data values(";
                for (int y = 0; y < FormUtama.featNumber; y++)
                {
                    sql += "'" + dataGridView.Rows[x].Cells[y].Value + "', ";
                }
                sql += "'" + dataGridView.Rows[x].Cells[FormUtama.featNumber].Value + "')";
                MessageBox.Show(sql);
                Koneksi.JalankanPerintahDML(sql);
            }
        }
    }
}
