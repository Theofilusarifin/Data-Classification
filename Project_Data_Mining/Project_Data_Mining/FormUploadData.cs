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
using System.IO;
//using System.Data.SqlClient;

namespace Project_Data_Mining
{
    public partial class FormUploadData : Form
    {
        OleDbConnection theConnection;
        public FormUploadData()
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Select File";
                fdlg.FileName = textBoxFileName.Text;
                // filter jenis/format file
                // nama format file|format file|
                fdlg.Filter = "All Files|*.*|" +
                              "Excel 97-2003 Workbook (.xls)|*.xls";
                              //"Excel Workbook (.xlsx)|*.xlsx";
                fdlg.FilterIndex = 1;
                fdlg.RestoreDirectory = true;

                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileName.Text = fdlg.FileName;
                }
            
                //buat ngambil sheet name di excel
                List<string> sheetNames = GetExcelSheetNames(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + textBoxFileName.Text + "';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\"");

                comboBoxSheet.DataSource = sheetNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Browse. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        List<string> GetExcelSheetNames(string connectionString)
        {
            theConnection = new OleDbConnection(connectionString);
            theConnection.Open();
            DataTable TableData = new DataTable();
            TableData = theConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            theConnection.Close();
            List<string> sheetNames = new List<string>();
            foreach (DataRow row in TableData.Rows)
            {
                sheetNames.Add(row["TABLE_NAME"].ToString());
            }
            return sheetNames;
        }
        // To read the excel data into datagridview
        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                //string strcon;
                //if (Path.GetExtension(textBoxFileName.Text).ToLower().Equals(".xls"))
                //    strcon = @"provider=Microsoft.Jet.OLEDB.4.0;data source='" + textBoxFileName.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"";
                //else
                //    strcon = @"provider=Microsoft.ACE.OLEDB.12.0;data source='" + textBoxFileName.Text + "';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\"";

                //OleDbConnection theConnection = new OleDbConnection(strcon);

                //OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + textBoxFileName.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"");

                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("Select * from["+comboBoxSheet.Text+"]", theConnection);

                DataSet theSD = new DataSet();
                DataTable dt = new DataTable();
                theDataAdapter.Fill(dt);
                this.dataGridView.DataSource = dt.DefaultView;
                this.dataGridView.AllowUserToAddRows = false;
                this.dataGridView.ReadOnly = true;

                int i = 0;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (i == 0)
                    {
                        column.HeaderText = "Document ID"; 
                    }
                    else if (i == FormUtama.featNumber+1)
                    {
                        column.HeaderText = "Class";
                    }
                    else
                    {
                        column.HeaderText = "Feat " + i.ToString();
                    }
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    i++;
                }
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Import. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count != 0)
                {

                    // Melakukan iterasi sesuai banyaknya data
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        //Membuat data baru yang ada pada col 0
                        Data d = new Data(dataGridView.Rows[rows].Cells[0].Value.ToString());
                        //Menambahkan data ke database
                        Data.TambahData(d);

                        //Membuat class yang ada pada col terakhir
                        Class c = new Class(dataGridView.Rows[rows].Cells[FormUtama.featNumber + 1].Value.ToString());
                        // Check apakah class baru atau bukan
                        if (!FormUtama.listClass.Contains(c.Id))
                        {
                            //Tambah data class ke database
                            Class.TambahData(c);
                            //Tambah data class ke list
                            FormUtama.listClass.Add(c.Id);
                        }

                        // Melakukan iterasi di col 1-featnumber
                        for (int column = 1; column <= FormUtama.featNumber; column++)
                        {
                            // Membuat feat baru ke database
                            Feat f = new Feat(d, c, column, dataGridView.Rows[rows].Cells[column].Value.ToString());
                            // Menambahkan feat
                            Feat.TambahData(f);
                        }
                    }
                    FormLoading frm = new FormLoading(); //Create Object
                    frm.Owner = this;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Import data terlebih dahulu!", "Peringatan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
        private void buttonBrowse_MouseEnter(object sender, EventArgs e)
        {
            buttonBrowse.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonBrowse_MouseLeave(object sender, EventArgs e)
        {
            buttonBrowse.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonImport_MouseEnter(object sender, EventArgs e)
        {
            buttonImport.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonImport_MouseLeave(object sender, EventArgs e)
        {
            buttonImport.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
