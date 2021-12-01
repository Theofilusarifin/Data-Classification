
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.radioButtonManhattan = new System.Windows.Forms.RadioButton();
            this.radioButtonEuclidean = new System.Windows.Forms.RadioButton();
            this.radioButtonSupreme = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(90, 135);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(600, 239);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(344, 92);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // radioButtonManhattan
            // 
            this.radioButtonManhattan.AutoSize = true;
            this.radioButtonManhattan.Checked = true;
            this.radioButtonManhattan.Location = new System.Drawing.Point(208, 51);
            this.radioButtonManhattan.Name = "radioButtonManhattan";
            this.radioButtonManhattan.Size = new System.Drawing.Size(76, 17);
            this.radioButtonManhattan.TabIndex = 2;
            this.radioButtonManhattan.TabStop = true;
            this.radioButtonManhattan.Text = "Manhattan";
            this.radioButtonManhattan.UseVisualStyleBackColor = true;
            this.radioButtonManhattan.Click += new System.EventHandler(this.radioButtonManhattan_Click);
            // 
            // radioButtonEuclidean
            // 
            this.radioButtonEuclidean.AutoSize = true;
            this.radioButtonEuclidean.Location = new System.Drawing.Point(344, 51);
            this.radioButtonEuclidean.Name = "radioButtonEuclidean";
            this.radioButtonEuclidean.Size = new System.Drawing.Size(72, 17);
            this.radioButtonEuclidean.TabIndex = 3;
            this.radioButtonEuclidean.Text = "Euclidean";
            this.radioButtonEuclidean.UseVisualStyleBackColor = true;
            this.radioButtonEuclidean.Click += new System.EventHandler(this.radioButtonEuclidean_Click);
            // 
            // radioButtonSupreme
            // 
            this.radioButtonSupreme.AutoSize = true;
            this.radioButtonSupreme.Location = new System.Drawing.Point(478, 51);
            this.radioButtonSupreme.Name = "radioButtonSupreme";
            this.radioButtonSupreme.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSupreme.TabIndex = 4;
            this.radioButtonSupreme.Text = "Supreme";
            this.radioButtonSupreme.UseVisualStyleBackColor = true;
            this.radioButtonSupreme.Click += new System.EventHandler(this.radioButtonSupreme_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonSupreme);
            this.Controls.Add(this.radioButtonEuclidean);
            this.Controls.Add(this.radioButtonManhattan);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton radioButtonManhattan;
        private System.Windows.Forms.RadioButton radioButtonEuclidean;
        private System.Windows.Forms.RadioButton radioButtonSupreme;
    }
}