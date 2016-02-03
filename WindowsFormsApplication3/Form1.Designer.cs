﻿namespace WindowsFormsApplication3
{
    partial class frmSynch
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
            this.components = new System.ComponentModel.Container();
            this.txtsrc1 = new System.Windows.Forms.TextBox();
            this.txtsrc2 = new System.Windows.Forms.TextBox();
            this.txtsrc3 = new System.Windows.Forms.TextBox();
            this.txtdest1 = new System.Windows.Forms.TextBox();
            this.txtdest2 = new System.Windows.Forms.TextBox();
            this.txtdest3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrCopy = new System.Windows.Forms.Timer(this.components);
            this.copy = new System.Windows.Forms.CheckBox();
            this.txtbrowserdst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsrc1
            // 
            this.txtsrc1.Location = new System.Drawing.Point(102, 26);
            this.txtsrc1.Name = "txtsrc1";
            this.txtsrc1.Size = new System.Drawing.Size(355, 22);
            this.txtsrc1.TabIndex = 0;
            this.txtsrc1.Text = "images/";
            // 
            // txtsrc2
            // 
            this.txtsrc2.Location = new System.Drawing.Point(102, 54);
            this.txtsrc2.Name = "txtsrc2";
            this.txtsrc2.Size = new System.Drawing.Size(355, 22);
            this.txtsrc2.TabIndex = 1;
            this.txtsrc2.Text = "csv/";
            // 
            // txtsrc3
            // 
            this.txtsrc3.Location = new System.Drawing.Point(102, 85);
            this.txtsrc3.Name = "txtsrc3";
            this.txtsrc3.Size = new System.Drawing.Size(355, 22);
            this.txtsrc3.TabIndex = 2;
            // 
            // txtdest1
            // 
            this.txtdest1.Location = new System.Drawing.Point(102, 149);
            this.txtdest1.Name = "txtdest1";
            this.txtdest1.Size = new System.Drawing.Size(355, 22);
            this.txtdest1.TabIndex = 3;
            this.txtdest1.Text = "c:/temp/images/";
            // 
            // txtdest2
            // 
            this.txtdest2.Location = new System.Drawing.Point(102, 177);
            this.txtdest2.Name = "txtdest2";
            this.txtdest2.Size = new System.Drawing.Size(355, 22);
            this.txtdest2.TabIndex = 4;
            this.txtdest2.Text = "c:/temp/csv/";
            // 
            // txtdest3
            // 
            this.txtdest3.Location = new System.Drawing.Point(102, 205);
            this.txtdest3.Name = "txtdest3";
            this.txtdest3.Size = new System.Drawing.Size(355, 22);
            this.txtdest3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sources";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destinations";
            // 
            // tmrCopy
            // 
            this.tmrCopy.Enabled = true;
            this.tmrCopy.Interval = 30000;
            this.tmrCopy.Tick += new System.EventHandler(this.tmrCopy_Tick);
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Checked = true;
            this.copy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copy.Location = new System.Drawing.Point(10, 3);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(62, 21);
            this.copy.TabIndex = 8;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            // 
            // txtbrowserdst
            // 
            this.txtbrowserdst.Location = new System.Drawing.Point(102, 256);
            this.txtbrowserdst.Name = "txtbrowserdst";
            this.txtbrowserdst.Size = new System.Drawing.Size(355, 22);
            this.txtbrowserdst.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Browser Dest";
            // 
            // frmSynch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbrowserdst);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdest3);
            this.Controls.Add(this.txtdest2);
            this.Controls.Add(this.txtdest1);
            this.Controls.Add(this.txtsrc3);
            this.Controls.Add(this.txtsrc2);
            this.Controls.Add(this.txtsrc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSynch";
            this.Text = "File Synchronizer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSynch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsrc1;
        private System.Windows.Forms.TextBox txtsrc2;
        private System.Windows.Forms.TextBox txtsrc3;
        private System.Windows.Forms.TextBox txtdest1;
        private System.Windows.Forms.TextBox txtdest2;
        private System.Windows.Forms.TextBox txtdest3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrCopy;
        private System.Windows.Forms.CheckBox copy;
        private System.Windows.Forms.TextBox txtbrowserdst;
        private System.Windows.Forms.Label label3;
    }
}
