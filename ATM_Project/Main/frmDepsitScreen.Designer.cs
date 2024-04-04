namespace ATM_Project.Main
{
    partial class frmDepsitScreen
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
            btnDeposit = new Button();
            txtboxAmount = new TextBox();
            lblAccountBalance = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(159, 86);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(80, 29);
            btnDeposit.TabIndex = 9;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtboxAmount
            // 
            txtboxAmount.Location = new Point(79, 57);
            txtboxAmount.Name = "txtboxAmount";
            txtboxAmount.Size = new Size(232, 23);
            txtboxAmount.TabIndex = 8;
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.BackColor = Color.Indigo;
            lblAccountBalance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountBalance.ForeColor = SystemColors.ControlLight;
            lblAccountBalance.Location = new Point(159, 208);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(51, 20);
            lblAccountBalance.TabIndex = 7;
            lblAccountBalance.Text = "??????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 207);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 6;
            label1.Text = "Account Balance:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Location = new Point(-6, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 54);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmDepsitScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 245);
            Controls.Add(btnDeposit);
            Controls.Add(txtboxAmount);
            Controls.Add(lblAccountBalance);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmDepsitScreen";
            Text = "frmDepsitScreen";
            Load += frmDepsitScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeposit;
        private TextBox txtboxAmount;
        private Label lblAccountBalance;
        private Label label1;
        private PictureBox pictureBox1;
    }
}