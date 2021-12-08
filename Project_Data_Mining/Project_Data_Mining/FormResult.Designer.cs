
namespace Project_Data_Mining
{
    partial class FormResult
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.radioButtonManhattan = new System.Windows.Forms.RadioButton();
            this.radioButtonEuclidean = new System.Windows.Forms.RadioButton();
            this.radioButtonSupremum = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.approximityMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entropyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(34, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(619, 260);
            this.dataGridView.TabIndex = 0;
            // 
            // radioButtonManhattan
            // 
            this.radioButtonManhattan.AutoSize = true;
            this.radioButtonManhattan.Checked = true;
            this.radioButtonManhattan.Font = new System.Drawing.Font("Montserrat", 12F);
            this.radioButtonManhattan.Location = new System.Drawing.Point(78, 31);
            this.radioButtonManhattan.Name = "radioButtonManhattan";
            this.radioButtonManhattan.Size = new System.Drawing.Size(117, 26);
            this.radioButtonManhattan.TabIndex = 2;
            this.radioButtonManhattan.TabStop = true;
            this.radioButtonManhattan.Text = "Manhattan";
            this.radioButtonManhattan.UseVisualStyleBackColor = true;
            // 
            // radioButtonEuclidean
            // 
            this.radioButtonEuclidean.AutoSize = true;
            this.radioButtonEuclidean.Font = new System.Drawing.Font("Montserrat", 12F);
            this.radioButtonEuclidean.Location = new System.Drawing.Point(255, 31);
            this.radioButtonEuclidean.Name = "radioButtonEuclidean";
            this.radioButtonEuclidean.Size = new System.Drawing.Size(108, 26);
            this.radioButtonEuclidean.TabIndex = 3;
            this.radioButtonEuclidean.Text = "Euclidean";
            this.radioButtonEuclidean.UseVisualStyleBackColor = true;
            // 
            // radioButtonSupremum
            // 
            this.radioButtonSupremum.AutoSize = true;
            this.radioButtonSupremum.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSupremum.Location = new System.Drawing.Point(430, 31);
            this.radioButtonSupremum.Name = "radioButtonSupremum";
            this.radioButtonSupremum.Size = new System.Drawing.Size(121, 26);
            this.radioButtonSupremum.TabIndex = 4;
            this.radioButtonSupremum.Text = "Supremum";
            this.radioButtonSupremum.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approximityMatrixToolStripMenuItem,
            this.giniToolStripMenuItem,
            this.entropyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // approximityMatrixToolStripMenuItem
            // 
            this.approximityMatrixToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approximityMatrixToolStripMenuItem.Name = "approximityMatrixToolStripMenuItem";
            this.approximityMatrixToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.approximityMatrixToolStripMenuItem.Text = "Approximity Matrix";
            this.approximityMatrixToolStripMenuItem.Click += new System.EventHandler(this.approximityMatrixToolStripMenuItem_Click);
            // 
            // giniToolStripMenuItem
            // 
            this.giniToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.giniToolStripMenuItem.Name = "giniToolStripMenuItem";
            this.giniToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.giniToolStripMenuItem.Text = "Gini";
            this.giniToolStripMenuItem.Click += new System.EventHandler(this.giniToolStripMenuItem_Click);
            // 
            // entropyToolStripMenuItem
            // 
            this.entropyToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.entropyToolStripMenuItem.Name = "entropyToolStripMenuItem";
            this.entropyToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.entropyToolStripMenuItem.Text = "Entropy";
            this.entropyToolStripMenuItem.Click += new System.EventHandler(this.entropyToolStripMenuItem_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalculate.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Button_Leave;
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(264, 160);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(160, 37);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            this.buttonCalculate.MouseEnter += new System.EventHandler(this.buttonCalculate_MouseEnter);
            this.buttonCalculate.MouseLeave += new System.EventHandler(this.buttonCalculate_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonManhattan);
            this.groupBox1.Controls.Add(this.radioButtonEuclidean);
            this.groupBox1.Controls.Add(this.radioButtonSupremum);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.groupBox1.Location = new System.Drawing.Point(34, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 82);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResult";
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton radioButtonManhattan;
        private System.Windows.Forms.RadioButton radioButtonEuclidean;
        private System.Windows.Forms.RadioButton radioButtonSupremum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approximityMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entropyToolStripMenuItem;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}