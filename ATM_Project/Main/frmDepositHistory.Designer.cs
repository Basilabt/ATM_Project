﻿namespace ATM_Project.Main
{
    partial class frmDepositHistory
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
            dgvDeposits = new DataGridView();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDeposits
            // 
            dgvDeposits.BackgroundColor = Color.White;
            dgvDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeposits.Location = new Point(10, 70);
            dgvDeposits.Name = "dgvDeposits";
            dgvDeposits.Size = new Size(776, 315);
            dgvDeposits.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Location = new Point(711, 407);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 33);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Location = new Point(-4, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmDepositHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDeposits);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Name = "frmDepositHistory";
            Text = "frmDepositHistory";
            Load += frmDepositHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeposits;
        private Button btnClose;
        private PictureBox pictureBox1;
    }
}