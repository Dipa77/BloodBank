namespace BBMS
{
    partial class AddNewDonor
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
            label1 = new Label();
            lblNewDonor = new Label();
            lblNewGender = new Label();
            lblNewDOB = new Label();
            lblNewBloodGrp = new Label();
            lblNewAddr = new Label();
            lblNewCont = new Label();
            lblNewEmail = new Label();
            txtNewDonor = new TextBox();
            txtNewAddr = new TextBox();
            txtNewCont = new TextBox();
            txtNewEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnNewSave = new Button();
            btnNewReset = new Button();
            btnNewExit = new Button();
            label2 = new Label();
            lblNewId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 22);
            label1.Name = "label1";
            label1.Size = new Size(318, 57);
            label1.TabIndex = 0;
            label1.Text = "Add New Donor";
            // 
            // lblNewDonor
            // 
            lblNewDonor.BackColor = Color.White;
            lblNewDonor.Location = new Point(12, 168);
            lblNewDonor.Name = "lblNewDonor";
            lblNewDonor.Size = new Size(100, 25);
            lblNewDonor.TabIndex = 1;
            lblNewDonor.Text = "Name";
            // 
            // lblNewGender
            // 
            lblNewGender.BackColor = Color.White;
            lblNewGender.Location = new Point(12, 227);
            lblNewGender.Name = "lblNewGender";
            lblNewGender.Size = new Size(100, 20);
            lblNewGender.TabIndex = 2;
            lblNewGender.Text = "Gender";
            // 
            // lblNewDOB
            // 
            lblNewDOB.BackColor = Color.White;
            lblNewDOB.Location = new Point(12, 279);
            lblNewDOB.Name = "lblNewDOB";
            lblNewDOB.Size = new Size(100, 20);
            lblNewDOB.TabIndex = 3;
            lblNewDOB.Text = "Date of Birth";
            // 
            // lblNewBloodGrp
            // 
            lblNewBloodGrp.BackColor = Color.White;
            lblNewBloodGrp.Location = new Point(383, 128);
            lblNewBloodGrp.Name = "lblNewBloodGrp";
            lblNewBloodGrp.Size = new Size(100, 20);
            lblNewBloodGrp.TabIndex = 4;
            lblNewBloodGrp.Text = "Blood Group";
            // 
            // lblNewAddr
            // 
            lblNewAddr.BackColor = Color.White;
            lblNewAddr.Location = new Point(383, 171);
            lblNewAddr.Name = "lblNewAddr";
            lblNewAddr.Size = new Size(90, 25);
            lblNewAddr.TabIndex = 5;
            lblNewAddr.Text = "Address";
            // 
            // lblNewCont
            // 
            lblNewCont.BackColor = Color.White;
            lblNewCont.Location = new Point(383, 220);
            lblNewCont.Name = "lblNewCont";
            lblNewCont.Size = new Size(90, 25);
            lblNewCont.TabIndex = 6;
            lblNewCont.Text = "Contact No.";
            // 
            // lblNewEmail
            // 
            lblNewEmail.BackColor = Color.White;
            lblNewEmail.Location = new Point(383, 272);
            lblNewEmail.Name = "lblNewEmail";
            lblNewEmail.Size = new Size(90, 27);
            lblNewEmail.TabIndex = 7;
            lblNewEmail.Text = "Email";
            // 
            // txtNewDonor
            // 
            txtNewDonor.Location = new Point(142, 171);
            txtNewDonor.Multiline = true;
            txtNewDonor.Name = "txtNewDonor";
            txtNewDonor.ReadOnly = true;
            txtNewDonor.Size = new Size(184, 25);
            txtNewDonor.TabIndex = 8;
            // 
            // txtNewAddr
            // 
            txtNewAddr.Location = new Point(524, 168);
            txtNewAddr.Multiline = true;
            txtNewAddr.Name = "txtNewAddr";
            txtNewAddr.ReadOnly = true;
            txtNewAddr.Size = new Size(184, 25);
            txtNewAddr.TabIndex = 9;
            txtNewAddr.Text = "     ";
            // 
            // txtNewCont
            // 
            txtNewCont.Location = new Point(524, 222);
            txtNewCont.Multiline = true;
            txtNewCont.Name = "txtNewCont";
            txtNewCont.ReadOnly = true;
            txtNewCont.Size = new Size(184, 25);
            txtNewCont.TabIndex = 10;
            txtNewCont.Text = "   ";
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(524, 272);
            txtNewEmail.Multiline = true;
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.ReadOnly = true;
            txtNewEmail.Size = new Size(184, 27);
            txtNewEmail.TabIndex = 11;
            txtNewEmail.Text = "                                                                                         ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox1.Location = new Point(142, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 28);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(524, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 28);
            comboBox2.TabIndex = 14;
            // 
            // btnNewSave
            // 
            btnNewSave.Location = new Point(389, 470);
            btnNewSave.Name = "btnNewSave";
            btnNewSave.Size = new Size(94, 29);
            btnNewSave.TabIndex = 15;
            btnNewSave.Text = "Save";
            btnNewSave.UseVisualStyleBackColor = true;
            btnNewSave.Click += btnNewSave_Click;
            // 
            // btnNewReset
            // 
            btnNewReset.Location = new Point(502, 470);
            btnNewReset.Name = "btnNewReset";
            btnNewReset.Size = new Size(94, 29);
            btnNewReset.TabIndex = 16;
            btnNewReset.Text = "Reset";
            btnNewReset.UseVisualStyleBackColor = true;
            btnNewReset.Click += btnNewReset_Click;
            // 
            // btnNewExit
            // 
            btnNewExit.Location = new Point(614, 470);
            btnNewExit.Name = "btnNewExit";
            btnNewExit.Size = new Size(94, 29);
            btnNewExit.TabIndex = 17;
            btnNewExit.Text = "Exit";
            btnNewExit.UseVisualStyleBackColor = true;
            btnNewExit.Click += btnNewExit_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 18;
            label2.Text = "Donor ID";
            // 
            // lblNewId
            // 
            lblNewId.BackColor = Color.White;
            lblNewId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewId.ForeColor = Color.Black;
            lblNewId.Location = new Point(146, 125);
            lblNewId.Name = "lblNewId";
            lblNewId.Size = new Size(42, 30);
            lblNewId.TabIndex = 19;
            lblNewId.Text = "1";
            // 
            // AddNewDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(lblNewId);
            Controls.Add(label2);
            Controls.Add(btnNewExit);
            Controls.Add(btnNewReset);
            Controls.Add(btnNewSave);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNewEmail);
            Controls.Add(txtNewCont);
            Controls.Add(txtNewAddr);
            Controls.Add(txtNewDonor);
            Controls.Add(lblNewEmail);
            Controls.Add(lblNewCont);
            Controls.Add(lblNewAddr);
            Controls.Add(lblNewBloodGrp);
            Controls.Add(lblNewDOB);
            Controls.Add(lblNewGender);
            Controls.Add(lblNewDonor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewDonor";
            Load += AddNewDonor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNewDonor;
        private Label lblNewGender;
        private Label lblNewDOB;
        private Label lblNewBloodGrp;
        private Label lblNewAddr;
        private Label lblNewCont;
        private Label lblNewEmail;
        private TextBox txtNewDonor;
        private TextBox txtNewAddr;
        private TextBox txtNewCont;
        private TextBox txtNewEmail;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnNewSave;
        private Button btnNewReset;
        private Button btnNewExit;
        private Label label2;
        private Label lblNewId;
    }
}