namespace IDM_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gBoxIdm = new System.Windows.Forms.GroupBox();
            this.labelIdm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.gBoxBackup = new System.Windows.Forms.GroupBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBoxIdm.SuspendLayout();
            this.grupBox2.SuspendLayout();
            this.gBoxBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIdm
            // 
            this.gBoxIdm.Controls.Add(this.labelIdm);
            this.gBoxIdm.Controls.Add(this.label6);
            this.gBoxIdm.Controls.Add(this.labelData);
            this.gBoxIdm.Controls.Add(this.labelSetting);
            this.gBoxIdm.Controls.Add(this.label2);
            this.gBoxIdm.Controls.Add(this.label1);
            this.gBoxIdm.Location = new System.Drawing.Point(12, 12);
            this.gBoxIdm.Name = "gBoxIdm";
            this.gBoxIdm.Size = new System.Drawing.Size(218, 83);
            this.gBoxIdm.TabIndex = 0;
            this.gBoxIdm.TabStop = false;
            this.gBoxIdm.Text = "Internet Download Manager";
            // 
            // labelIdm
            // 
            this.labelIdm.AutoSize = true;
            this.labelIdm.Location = new System.Drawing.Point(54, 21);
            this.labelIdm.Name = "labelIdm";
            this.labelIdm.Size = new System.Drawing.Size(16, 13);
            this.labelIdm.TabIndex = 6;
            this.labelIdm.Text = ": -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IDM";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(54, 59);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(16, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = ": -";
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(54, 40);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(16, 13);
            this.labelSetting.TabIndex = 3;
            this.labelSetting.Text = ": -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(54, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(16, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = ": -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // grupBox2
            // 
            this.grupBox2.Controls.Add(this.btnRestore);
            this.grupBox2.Controls.Add(this.btnBackup);
            this.grupBox2.Location = new System.Drawing.Point(12, 176);
            this.grupBox2.Name = "grupBox2";
            this.grupBox2.Size = new System.Drawing.Size(218, 75);
            this.grupBox2.TabIndex = 1;
            this.grupBox2.TabStop = false;
            this.grupBox2.Text = "Options";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(112, 19);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(94, 44);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(12, 19);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(94, 44);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // gBoxBackup
            // 
            this.gBoxBackup.Controls.Add(this.labelSize);
            this.gBoxBackup.Controls.Add(this.label5);
            this.gBoxBackup.Controls.Add(this.labelDate);
            this.gBoxBackup.Controls.Add(this.label3);
            this.gBoxBackup.Location = new System.Drawing.Point(12, 101);
            this.gBoxBackup.Name = "gBoxBackup";
            this.gBoxBackup.Size = new System.Drawing.Size(218, 65);
            this.gBoxBackup.TabIndex = 5;
            this.gBoxBackup.TabStop = false;
            this.gBoxBackup.Text = "Backup File";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(54, 41);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(16, 13);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = ": -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Size";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 263);
            this.Controls.Add(this.gBoxBackup);
            this.Controls.Add(this.grupBox2);
            this.Controls.Add(this.gBoxIdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM Manager";
            this.gBoxIdm.ResumeLayout(false);
            this.gBoxIdm.PerformLayout();
            this.grupBox2.ResumeLayout(false);
            this.gBoxBackup.ResumeLayout(false);
            this.gBoxBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIdm;
        private System.Windows.Forms.GroupBox grupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.GroupBox gBoxBackup;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIdm;
        private System.Windows.Forms.Label label6;
    }
}

