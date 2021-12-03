
namespace Project_Data_Mining
{
    partial class FormInputFeatNumber
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownFeatNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClassNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Button_Leave;
            this.buttonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(34, 137);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(310, 37);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            this.buttonSubmit.MouseEnter += new System.EventHandler(this.buttonSubmit_MouseEnter);
            this.buttonSubmit.MouseLeave += new System.EventHandler(this.buttonSubmit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input Feat Number :";
            // 
            // numericUpDownFeatNumber
            // 
            this.numericUpDownFeatNumber.Location = new System.Drawing.Point(243, 48);
            this.numericUpDownFeatNumber.Name = "numericUpDownFeatNumber";
            this.numericUpDownFeatNumber.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownFeatNumber.TabIndex = 12;
            // 
            // numericUpDownClassNumber
            // 
            this.numericUpDownClassNumber.Location = new System.Drawing.Point(243, 89);
            this.numericUpDownClassNumber.Name = "numericUpDownClassNumber";
            this.numericUpDownClassNumber.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownClassNumber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input Class Number :";
            // 
            // FormInputFeatNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.numericUpDownClassNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownFeatNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInputFeatNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputFeatNumber";
            this.Load += new System.EventHandler(this.FormInputFeatNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFeatNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownClassNumber;
        private System.Windows.Forms.Label label2;
    }
}