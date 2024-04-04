namespace ATM_Project.Main
{
    partial class frmWithdrawScreen
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
            label1 = new Label();
            lblAccountBalance = new Label();
            txtboxAmount = new TextBox();
            btnWithdraw = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Location = new Point(-1, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-1, 226);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Account Balance:";
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.BackColor = Color.Indigo;
            lblAccountBalance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountBalance.ForeColor = SystemColors.ControlLight;
            lblAccountBalance.Location = new Point(146, 227);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(51, 20);
            lblAccountBalance.TabIndex = 2;
            lblAccountBalance.Text = "??????";
            // 
            // txtboxAmount
            // 
            txtboxAmount.Location = new Point(81, 76);
            txtboxAmount.Name = "txtboxAmount";
            txtboxAmount.Size = new Size(232, 23);
            txtboxAmount.TabIndex = 3;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(147, 105);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(80, 29);
            btnWithdraw.TabIndex = 4;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // frmWithdrawScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 262);
            Controls.Add(btnWithdraw);
            Controls.Add(txtboxAmount);
            Controls.Add(lblAccountBalance);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MinimizeBox = false;
            Name = "frmWithdrawScreen";
            Text = "Withdraw";
            Load += frmWithdrawScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblAccountBalance;
        private TextBox txtboxAmount;
        private Button btnWithdraw;
    }
}