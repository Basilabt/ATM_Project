namespace ATM_Project.Main
{
    partial class frmMainScreen
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblClientName = new Label();
            lblCurrentDate = new Label();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            brnWithdrawHistory = new Button();
            btnDepositHistory = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Location = new Point(-4, 333);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Indigo;
            pictureBox2.Location = new Point(10, 344);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 23);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 344);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 2;
            label1.Text = "Welcome,";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.BackColor = Color.Indigo;
            lblClientName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClientName.ForeColor = Color.White;
            lblClientName.Location = new Point(176, 344);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(21, 25);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "?";
            lblClientName.Click += lblClientName_Click;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.BackColor = Color.Indigo;
            lblCurrentDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrentDate.ForeColor = Color.LightGray;
            lblCurrentDate.Location = new Point(405, 348);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(72, 19);
            lblCurrentDate.TabIndex = 4;
            lblCurrentDate.Text = "Welcome,";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(47, 26);
            btnWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(206, 109);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(47, 189);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(206, 109);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // brnWithdrawHistory
            // 
            brnWithdrawHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnWithdrawHistory.Location = new Point(366, 26);
            brnWithdrawHistory.Margin = new Padding(3, 2, 3, 2);
            brnWithdrawHistory.Name = "brnWithdrawHistory";
            brnWithdrawHistory.Size = new Size(206, 109);
            brnWithdrawHistory.TabIndex = 7;
            brnWithdrawHistory.Text = "Withdraw History";
            brnWithdrawHistory.UseVisualStyleBackColor = true;
            brnWithdrawHistory.Click += brnWithdrawHistory_Click;
            // 
            // btnDepositHistory
            // 
            btnDepositHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositHistory.Location = new Point(366, 189);
            btnDepositHistory.Margin = new Padding(3, 2, 3, 2);
            btnDepositHistory.Name = "btnDepositHistory";
            btnDepositHistory.Size = new Size(206, 109);
            btnDepositHistory.TabIndex = 8;
            btnDepositHistory.Text = "Deposit History";
            btnDepositHistory.UseVisualStyleBackColor = true;
            btnDepositHistory.Click += btnDepositHistory_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(555, 344);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 377);
            Controls.Add(btnExit);
            Controls.Add(btnDepositHistory);
            Controls.Add(brnWithdrawHistory);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(lblCurrentDate);
            Controls.Add(lblClientName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.DarkViolet;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            Load += frmMainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblClientName;
        private Label lblCurrentDate;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button brnWithdrawHistory;
        private Button btnDepositHistory;
        private Button btnExit;
    }
}