﻿namespace Calculator_2270
{
    partial class frmHasilPerhitungan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.lsbHasilPerhitungan = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbHasilPerhitungan);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(18, 414);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(591, 23);
            this.btnHitung.TabIndex = 0;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // lsbHasilPerhitungan
            // 
            this.lsbHasilPerhitungan.FormattingEnabled = true;
            this.lsbHasilPerhitungan.Location = new System.Drawing.Point(6, 18);
            this.lsbHasilPerhitungan.Name = "lsbHasilPerhitungan";
            this.lsbHasilPerhitungan.Size = new System.Drawing.Size(591, 355);
            this.lsbHasilPerhitungan.TabIndex = 0;
            this.lsbHasilPerhitungan.SelectedIndexChanged += new System.EventHandler(this.lsbHasilPerhitungan_SelectedIndexChanged);
            // 
            // frmHasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHasilPerhitungan";
            this.Text = "HasilPerhitungan";
            this.Load += new System.EventHandler(this.FrmHasilPerhitungan_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ListBox lsbHasilPerhitungan;
    }
}

