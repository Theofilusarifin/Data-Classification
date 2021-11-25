
namespace Project_Data_Mining
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumOfFeat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFeat2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFeat3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFeat4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFeat5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFeat1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonProximityMatrix = new System.Windows.Forms.Button();
            this.buttonGINI = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownNumOfDocs = new System.Windows.Forms.NumericUpDown();
            this.textBoxData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feat :";
            // 
            // numericUpDownNumOfFeat
            // 
            this.numericUpDownNumOfFeat.Location = new System.Drawing.Point(60, 10);
            this.numericUpDownNumOfFeat.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumOfFeat.Name = "numericUpDownNumOfFeat";
            this.numericUpDownNumOfFeat.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownNumOfFeat.TabIndex = 1;
            this.numericUpDownNumOfFeat.ValueChanged += new System.EventHandler(this.numericUpDownNumOfFeat_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doc Index";
            // 
            // textBoxFeat2
            // 
            this.textBoxFeat2.Enabled = false;
            this.textBoxFeat2.Location = new System.Drawing.Point(204, 63);
            this.textBoxFeat2.Name = "textBoxFeat2";
            this.textBoxFeat2.Size = new System.Drawing.Size(80, 20);
            this.textBoxFeat2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feat 2";
            // 
            // textBoxFeat3
            // 
            this.textBoxFeat3.Enabled = false;
            this.textBoxFeat3.Location = new System.Drawing.Point(306, 63);
            this.textBoxFeat3.Name = "textBoxFeat3";
            this.textBoxFeat3.Size = new System.Drawing.Size(80, 20);
            this.textBoxFeat3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Feat 3";
            // 
            // textBoxFeat4
            // 
            this.textBoxFeat4.Enabled = false;
            this.textBoxFeat4.Location = new System.Drawing.Point(412, 63);
            this.textBoxFeat4.Name = "textBoxFeat4";
            this.textBoxFeat4.Size = new System.Drawing.Size(80, 20);
            this.textBoxFeat4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Feat 4";
            // 
            // textBoxFeat5
            // 
            this.textBoxFeat5.Enabled = false;
            this.textBoxFeat5.Location = new System.Drawing.Point(518, 63);
            this.textBoxFeat5.Name = "textBoxFeat5";
            this.textBoxFeat5.Size = new System.Drawing.Size(80, 20);
            this.textBoxFeat5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Feat 5";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Enabled = false;
            this.textBoxClass.Location = new System.Drawing.Point(615, 63);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(80, 20);
            this.textBoxClass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Class";
            // 
            // textBoxFeat1
            // 
            this.textBoxFeat1.Enabled = false;
            this.textBoxFeat1.Location = new System.Drawing.Point(108, 63);
            this.textBoxFeat1.Name = "textBoxFeat1";
            this.textBoxFeat1.Size = new System.Drawing.Size(80, 20);
            this.textBoxFeat1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Feat 1";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Location = new System.Drawing.Point(11, 100);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 16;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonProximityMatrix
            // 
            this.buttonProximityMatrix.Enabled = false;
            this.buttonProximityMatrix.Location = new System.Drawing.Point(107, 100);
            this.buttonProximityMatrix.Name = "buttonProximityMatrix";
            this.buttonProximityMatrix.Size = new System.Drawing.Size(89, 23);
            this.buttonProximityMatrix.TabIndex = 17;
            this.buttonProximityMatrix.Text = "Proximity Matrix";
            this.buttonProximityMatrix.UseVisualStyleBackColor = true;
            this.buttonProximityMatrix.Click += new System.EventHandler(this.buttonProximityMatrix_Click);
            // 
            // buttonGINI
            // 
            this.buttonGINI.Enabled = false;
            this.buttonGINI.Location = new System.Drawing.Point(220, 100);
            this.buttonGINI.Name = "buttonGINI";
            this.buttonGINI.Size = new System.Drawing.Size(89, 23);
            this.buttonGINI.TabIndex = 18;
            this.buttonGINI.Text = "GINI";
            this.buttonGINI.UseVisualStyleBackColor = true;
            this.buttonGINI.Click += new System.EventHandler(this.buttonGINI_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(708, 63);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 23);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownNumOfDocs
            // 
            this.numericUpDownNumOfDocs.Enabled = false;
            this.numericUpDownNumOfDocs.Location = new System.Drawing.Point(14, 65);
            this.numericUpDownNumOfDocs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumOfDocs.Name = "numericUpDownNumOfDocs";
            this.numericUpDownNumOfDocs.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownNumOfDocs.TabIndex = 21;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(11, 141);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(786, 218);
            this.textBoxData.TabIndex = 22;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 371);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.numericUpDownNumOfDocs);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonGINI);
            this.Controls.Add(this.buttonProximityMatrix);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.textBoxFeat1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFeat5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFeat4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFeat3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFeat2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNumOfFeat);
            this.Controls.Add(this.label1);
            this.Name = "FormUtama";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfFeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFeat2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFeat3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFeat4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFeat5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFeat1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonProximityMatrix;
        private System.Windows.Forms.Button buttonGINI;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfDocs;
        private System.Windows.Forms.TextBox textBoxData;
    }
}

