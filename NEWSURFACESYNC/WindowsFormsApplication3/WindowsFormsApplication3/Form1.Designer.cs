namespace SurfaceSync
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
            this.txtdest1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrCopy = new System.Windows.Forms.Timer(this.components);
            this.copy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtsrc1
            // 
            this.txtsrc1.Location = new System.Drawing.Point(99, 21);
            this.txtsrc1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsrc1.Name = "txtsrc1";
            this.txtsrc1.Size = new System.Drawing.Size(244, 20);
            this.txtsrc1.TabIndex = 0;
            this.txtsrc1.Text = "c:/test";
            // 
            // txtdest1
            // 
            this.txtdest1.Location = new System.Drawing.Point(99, 53);
            this.txtdest1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdest1.Name = "txtdest1";
            this.txtdest1.Size = new System.Drawing.Size(244, 20);
            this.txtdest1.TabIndex = 3;
            this.txtdest1.Text = "c:/temp/images/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.copy.Location = new System.Drawing.Point(293, 89);
            this.copy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(50, 17);
            this.copy.TabIndex = 8;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.CheckedChanged += new System.EventHandler(this.copy_CheckedChanged);
            // 
            // frmSynch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 125);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdest1);
            this.Controls.Add(this.txtsrc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmSynch";
            this.Text = "SurfaceSync";
            this.Icon = SurfaceSync.Properties.Resources.Icon;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSynch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsrc1;
        private System.Windows.Forms.TextBox txtdest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrCopy;
        private System.Windows.Forms.CheckBox copy;
    }
}

