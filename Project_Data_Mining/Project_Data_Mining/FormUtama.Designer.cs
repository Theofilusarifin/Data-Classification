
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
            this.pictureBoxDev = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.buttonGetStarted = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDev
            // 
            this.pictureBoxDev.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDev.BackgroundImage = global::Project_Data_Mining.Properties.Resources.profile1;
            this.pictureBoxDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDev.Location = new System.Drawing.Point(927, 664);
            this.pictureBoxDev.Name = "pictureBoxDev";
            this.pictureBoxDev.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxDev.TabIndex = 13;
            this.pictureBoxDev.TabStop = false;
            this.pictureBoxDev.Click += new System.EventHandler(this.pictureBoxDev_Click);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHelp.BackgroundImage = global::Project_Data_Mining.Properties.Resources.help1;
            this.pictureBoxHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHelp.Location = new System.Drawing.Point(851, 660);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxHelp.TabIndex = 14;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBoxHelp_Click);
            // 
            // buttonGetStarted
            // 
            this.buttonGetStarted.AutoSize = true;
            this.buttonGetStarted.BackColor = System.Drawing.Color.White;
            this.buttonGetStarted.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Button_Leave;
            this.buttonGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetStarted.FlatAppearance.BorderSize = 0;
            this.buttonGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonGetStarted.ForeColor = System.Drawing.Color.White;
            this.buttonGetStarted.Location = new System.Drawing.Point(309, 394);
            this.buttonGetStarted.Name = "buttonGetStarted";
            this.buttonGetStarted.Size = new System.Drawing.Size(393, 45);
            this.buttonGetStarted.TabIndex = 15;
            this.buttonGetStarted.Text = "Get Started";
            this.buttonGetStarted.UseVisualStyleBackColor = false;
            this.buttonGetStarted.Click += new System.EventHandler(this.buttonGetStarted_Click);
            this.buttonGetStarted.MouseEnter += new System.EventHandler(this.buttonGetStarted_MouseEnter);
            this.buttonGetStarted.MouseLeave += new System.EventHandler(this.buttonGetStarted_MouseLeave);
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Form_Utama1;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.buttonGetStarted);
            this.panelBackground.Controls.Add(this.pictureBoxHelp);
            this.panelBackground.Controls.Add(this.pictureBoxDev);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1012, 722);
            this.panelBackground.TabIndex = 16;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Form_Utama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 722);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cluster Analysis";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDev;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.Button buttonGetStarted;
        private System.Windows.Forms.Panel panelBackground;
    }
}