
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
            this.buttonGetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(280, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to";
            // 
            // buttonGetStarted
            // 
            this.buttonGetStarted.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetStarted.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Button_Leave;
            this.buttonGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonGetStarted.ForeColor = System.Drawing.Color.White;
            this.buttonGetStarted.Location = new System.Drawing.Point(309, 267);
            this.buttonGetStarted.Name = "buttonGetStarted";
            this.buttonGetStarted.Size = new System.Drawing.Size(160, 37);
            this.buttonGetStarted.TabIndex = 12;
            this.buttonGetStarted.Text = "Get Started";
            this.buttonGetStarted.UseVisualStyleBackColor = false;
            this.buttonGetStarted.Click += new System.EventHandler(this.buttonGetStarted_Click);
            this.buttonGetStarted.MouseEnter += new System.EventHandler(this.buttonGetStarted_MouseEnter);
            this.buttonGetStarted.MouseLeave += new System.EventHandler(this.buttonGetStarted_MouseLeave);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetStarted);
            this.Controls.Add(this.label1);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetStarted;
    }
}