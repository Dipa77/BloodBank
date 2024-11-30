namespace BBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbTC = new CheckBox();
            btnLogin = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Script", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(191, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(386, 106);
            textBox1.TabIndex = 0;
            textBox1.Text = "Raktdaan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 132);
            label1.Name = "label1";
            label1.Size = new Size(281, 31);
            label1.TabIndex = 1;
            label1.Text = "Be a Donor, Be  a Saviour";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(312, 202);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 2;
            label2.Text = "Hi, there!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(191, 231);
            label3.Name = "label3";
            label3.Size = new Size(376, 29);
            label3.TabIndex = 3;
            label3.Text = "Please fill up the following details:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtUsername.Location = new Point(266, 297);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(281, 34);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtPassword.Location = new Point(266, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(284, 34);
            txtPassword.TabIndex = 5;
            // 
            // cbTC
            // 
            cbTC.AutoSize = true;
            cbTC.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTC.Location = new Point(279, 407);
            cbTC.Name = "cbTC";
            cbTC.Size = new Size(288, 24);
            cbTC.TabIndex = 6;
            cbTC.Text = "I agree to all terms and conditions.";
            cbTC.UseVisualStyleBackColor = true;
            cbTC.CheckedChanged += cbTC_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.LimeGreen;
            btnLogin.Location = new Point(571, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Go";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 10.2F);
            linkLabel2.Location = new Point(312, 461);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(145, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // linkLabel3
            // 
            linkLabel3.Font = new Font("Microsoft Sans Serif", 10.2F);
            linkLabel3.Location = new Point(307, 504);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(214, 20);
            linkLabel3.TabIndex = 10;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Terms and Conditions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(btnLogin);
            Controls.Add(cbTC);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox cbTC;
        private Button btnLogin;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
    }
}
