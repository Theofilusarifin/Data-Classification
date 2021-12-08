﻿
namespace Project_Data_Mining
{
    partial class FormGINI
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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.approximityMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entropyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 18;
            this.listBoxInfo.Location = new System.Drawing.Point(38, 61);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(611, 364);
            this.listBoxInfo.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalculate.BackgroundImage = global::Project_Data_Mining.Properties.Resources.Button_Leave;
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(489, 451);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(160, 37);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            this.buttonCalculate.MouseEnter += new System.EventHandler(this.buttonCalculate_MouseEnter);
            this.buttonCalculate.MouseLeave += new System.EventHandler(this.buttonCalculate_MouseLeave);
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
            this.menuStrip1.TabIndex = 10;
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
            // FormGINI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.listBoxInfo);
            this.Name = "FormGINI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGINI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approximityMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entropyToolStripMenuItem;
    }
}