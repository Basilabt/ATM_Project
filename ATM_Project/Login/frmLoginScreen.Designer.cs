namespace ATM_Project
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            pictureBox1 = new PictureBox();
            txtboxUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtboxPassword = new TextBox();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(550, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 398);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BorderStyle = BorderStyle.FixedSingle;
            txtboxUsername.Location = new Point(676, 107);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(255, 27);
            txtboxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(567, 103);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(567, 157);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtboxPassword
            // 
            txtboxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtboxPassword.Location = new Point(676, 157);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(255, 27);
            txtboxPassword.TabIndex = 4;
            txtboxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(837, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 247);
            label3.Name = "label3";
            label3.Size = new Size(120, 60);
            label3.TabIndex = 7;
            label3.Text = "ATM";
            // 
            // frmLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(980, 397);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox2);
            Controls.Add(txtboxPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLoginScreen";
            Text = "Login Screen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtboxUsername;
        private Label label1;
        private Label label2;
        private TextBox txtboxPassword;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Label label3;
    }
}