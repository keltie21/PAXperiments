namespace Graffiti
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
            this.txtftp_host = new System.Windows.Forms.TextBox();
            this.txtftp_name = new System.Windows.Forms.TextBox();
            this.txtftp_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrCopy = new System.Windows.Forms.Timer(this.components);
            this.copy = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtsrc1
            // 
            this.txtsrc1.Location = new System.Drawing.Point(86, 94);
            this.txtsrc1.Margin = new System.Windows.Forms.Padding(2);
            this.txtsrc1.Name = "txtsrc1";
            this.txtsrc1.Size = new System.Drawing.Size(267, 20);
            this.txtsrc1.TabIndex = 0;
            this.txtsrc1.TextChanged += new System.EventHandler(this.txtsrc1_TextChanged);
            // 
            // txtdest1
            // 
            this.txtdest1.Location = new System.Drawing.Point(86, 116);
            this.txtdest1.Margin = new System.Windows.Forms.Padding(2);
            this.txtdest1.Name = "txtdest1";
            this.txtdest1.Size = new System.Drawing.Size(267, 20);
            this.txtdest1.TabIndex = 3;
            this.txtdest1.TextChanged += new System.EventHandler(this.txtdest1_TextChanged);
            // 
            // txtftp_host
            // 
            this.txtftp_host.Location = new System.Drawing.Point(86, 9);
            this.txtftp_host.Margin = new System.Windows.Forms.Padding(2);
            this.txtftp_host.Name = "txtftp_host";
            this.txtftp_host.Size = new System.Drawing.Size(267, 20);
            this.txtftp_host.TabIndex = 9;
            this.txtftp_host.TextChanged += new System.EventHandler(this.txtftp_host_TextChanged);
            // 
            // txtftp_name
            // 
            this.txtftp_name.Location = new System.Drawing.Point(86, 33);
            this.txtftp_name.Margin = new System.Windows.Forms.Padding(2);
            this.txtftp_name.Name = "txtftp_name";
            this.txtftp_name.Size = new System.Drawing.Size(267, 20);
            this.txtftp_name.TabIndex = 11;
            this.txtftp_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtftp_pass
            // 
            this.txtftp_pass.Location = new System.Drawing.Point(86, 58);
            this.txtftp_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txtftp_pass.Name = "txtftp_pass";
            this.txtftp_pass.PasswordChar = '*';
            this.txtftp_pass.Size = new System.Drawing.Size(267, 20);
            this.txtftp_pass.TabIndex = 12;
            this.txtftp_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Backup Dir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tmrCopy
            // 
            this.tmrCopy.Enabled = true;
            this.tmrCopy.Interval = 1000;
            this.tmrCopy.Tick += new System.EventHandler(this.tmrCopy_Tick);
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Location = new System.Drawing.Point(287, 137);
            this.copy.Margin = new System.Windows.Forms.Padding(2);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(71, 17);
            this.copy.TabIndex = 8;
            this.copy.Text = "Activated";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.CheckedChanged += new System.EventHandler(this.copy_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "FTP Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "FTP Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "FTP Password";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(184, 137);
            this.chkStartup.Margin = new System.Windows.Forms.Padding(2);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(100, 17);
            this.chkStartup.TabIndex = 15;
            this.chkStartup.Text = "Run On Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // frmSynch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 162);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtftp_pass);
            this.Controls.Add(this.txtftp_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtftp_host);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdest1);
            this.Controls.Add(this.txtsrc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmSynch";
            this.ShowIcon = false;
            this.Text = "Graffiti FTP";
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
        private System.Windows.Forms.TextBox txtftp_host;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtftp_name;
        private System.Windows.Forms.TextBox txtftp_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStartup;
    }
}

