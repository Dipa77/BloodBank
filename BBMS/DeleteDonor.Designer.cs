namespace BBMS
{
    partial class DeleteDonor
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
            btnSearchtoDelete = new Button();
            txtDeleteID = new TextBox();
            lblDeleteID = new Label();
            btnDeleteExit = new Button();
            btnDeleteReset = new Button();
            btnDelete = new Button();
            txtDeleteBloodGrp = new ComboBox();
            txtDeleteGender = new ComboBox();
            txtDeleteDOB = new DateTimePicker();
            txtDeleteEmail = new TextBox();
            txtDeleteCont = new TextBox();
            txtDeleteAddr = new TextBox();
            txtDeleteDonor = new TextBox();
            lblDeleteEmail = new Label();
            lblDeleteCont = new Label();
            lblDeleteAddr = new Label();
            lblDeleteBloodGrp = new Label();
            lblDeleteDOB = new Label();
            lblDeleteGender = new Label();
            lblDeleteDonor = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSearchtoDelete
            // 
            btnSearchtoDelete.BackColor = Color.LightGray;
            btnSearchtoDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchtoDelete.Location = new Point(262, 144);
            btnSearchtoDelete.Name = "btnSearchtoDelete";
            btnSearchtoDelete.Size = new Size(69, 30);
            btnSearchtoDelete.TabIndex = 61;
            btnSearchtoDelete.Text = "Search";
            btnSearchtoDelete.UseVisualStyleBackColor = false;
            btnSearchtoDelete.Click += btnSearchtoDelete_Click;
            // 
            // txtDeleteID
            // 
            txtDeleteID.Location = new Point(147, 146);
            txtDeleteID.Name = "txtDeleteID";
            txtDeleteID.Size = new Size(109, 27);
            txtDeleteID.TabIndex = 60;
            txtDeleteID.TextChanged += txtDeleteID_TextChanged;
            // 
            // lblDeleteID
            // 
            lblDeleteID.BackColor = Color.White;
            lblDeleteID.Location = new Point(17, 149);
            lblDeleteID.Name = "lblDeleteID";
            lblDeleteID.Size = new Size(100, 25);
            lblDeleteID.TabIndex = 59;
            lblDeleteID.Text = "Donor ID";
            // 
            // btnDeleteExit
            // 
            btnDeleteExit.Location = new Point(610, 455);
            btnDeleteExit.Name = "btnDeleteExit";
            btnDeleteExit.Size = new Size(94, 29);
            btnDeleteExit.TabIndex = 58;
            btnDeleteExit.Text = "Exit";
            btnDeleteExit.UseVisualStyleBackColor = true;
            btnDeleteExit.Click += btnDeleteExit_Click;
            // 
            // btnDeleteReset
            // 
            btnDeleteReset.Location = new Point(492, 455);
            btnDeleteReset.Name = "btnDeleteReset";
            btnDeleteReset.Size = new Size(94, 29);
            btnDeleteReset.TabIndex = 57;
            btnDeleteReset.Text = "Reset";
            btnDeleteReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(375, 455);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDeleteBloodGrp
            // 
            txtDeleteBloodGrp.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDeleteBloodGrp.FormattingEnabled = true;
            txtDeleteBloodGrp.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtDeleteBloodGrp.Location = new Point(501, 146);
            txtDeleteBloodGrp.Name = "txtDeleteBloodGrp";
            txtDeleteBloodGrp.Size = new Size(184, 28);
            txtDeleteBloodGrp.TabIndex = 55;
            // 
            // txtDeleteGender
            // 
            txtDeleteGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDeleteGender.FormattingEnabled = true;
            txtDeleteGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtDeleteGender.Location = new Point(147, 259);
            txtDeleteGender.Name = "txtDeleteGender";
            txtDeleteGender.Size = new Size(184, 28);
            txtDeleteGender.TabIndex = 54;
            // 
            // txtDeleteDOB
            // 
            txtDeleteDOB.Location = new Point(147, 317);
            txtDeleteDOB.Name = "txtDeleteDOB";
            txtDeleteDOB.Size = new Size(184, 27);
            txtDeleteDOB.TabIndex = 53;
            // 
            // txtDeleteEmail
            // 
            txtDeleteEmail.Location = new Point(501, 315);
            txtDeleteEmail.Multiline = true;
            txtDeleteEmail.Name = "txtDeleteEmail";
            txtDeleteEmail.Size = new Size(184, 27);
            txtDeleteEmail.TabIndex = 52;
            txtDeleteEmail.Text = "                                                                                         ";
            // 
            // txtDeleteCont
            // 
            txtDeleteCont.Location = new Point(501, 262);
            txtDeleteCont.Multiline = true;
            txtDeleteCont.Name = "txtDeleteCont";
            txtDeleteCont.Size = new Size(184, 25);
            txtDeleteCont.TabIndex = 51;
            txtDeleteCont.Text = "   ";
            // 
            // txtDeleteAddr
            // 
            txtDeleteAddr.Location = new Point(501, 203);
            txtDeleteAddr.Multiline = true;
            txtDeleteAddr.Name = "txtDeleteAddr";
            txtDeleteAddr.Size = new Size(184, 25);
            txtDeleteAddr.TabIndex = 50;
            txtDeleteAddr.Text = "     ";
            // 
            // txtDeleteDonor
            // 
            txtDeleteDonor.Location = new Point(147, 203);
            txtDeleteDonor.Multiline = true;
            txtDeleteDonor.Name = "txtDeleteDonor";
            txtDeleteDonor.Size = new Size(184, 25);
            txtDeleteDonor.TabIndex = 49;
            // 
            // lblDeleteEmail
            // 
            lblDeleteEmail.BackColor = Color.White;
            lblDeleteEmail.Location = new Point(375, 315);
            lblDeleteEmail.Name = "lblDeleteEmail";
            lblDeleteEmail.Size = new Size(90, 27);
            lblDeleteEmail.TabIndex = 48;
            lblDeleteEmail.Text = "Email";
            // 
            // lblDeleteCont
            // 
            lblDeleteCont.BackColor = Color.White;
            lblDeleteCont.Location = new Point(375, 259);
            lblDeleteCont.Name = "lblDeleteCont";
            lblDeleteCont.Size = new Size(90, 25);
            lblDeleteCont.TabIndex = 47;
            lblDeleteCont.Text = "Contact No.";
            // 
            // lblDeleteAddr
            // 
            lblDeleteAddr.BackColor = Color.White;
            lblDeleteAddr.Location = new Point(375, 206);
            lblDeleteAddr.Name = "lblDeleteAddr";
            lblDeleteAddr.Size = new Size(90, 25);
            lblDeleteAddr.TabIndex = 46;
            lblDeleteAddr.Text = "Address";
            // 
            // lblDeleteBloodGrp
            // 
            lblDeleteBloodGrp.BackColor = Color.White;
            lblDeleteBloodGrp.Location = new Point(375, 149);
            lblDeleteBloodGrp.Name = "lblDeleteBloodGrp";
            lblDeleteBloodGrp.Size = new Size(100, 20);
            lblDeleteBloodGrp.TabIndex = 45;
            lblDeleteBloodGrp.Text = "Blood Group";
            // 
            // lblDeleteDOB
            // 
            lblDeleteDOB.BackColor = Color.White;
            lblDeleteDOB.Location = new Point(17, 322);
            lblDeleteDOB.Name = "lblDeleteDOB";
            lblDeleteDOB.Size = new Size(100, 20);
            lblDeleteDOB.TabIndex = 44;
            lblDeleteDOB.Text = "Date of Birth";
            // 
            // lblDeleteGender
            // 
            lblDeleteGender.BackColor = Color.White;
            lblDeleteGender.Location = new Point(17, 267);
            lblDeleteGender.Name = "lblDeleteGender";
            lblDeleteGender.Size = new Size(100, 20);
            lblDeleteGender.TabIndex = 43;
            lblDeleteGender.Text = "Gender";
            // 
            // lblDeleteDonor
            // 
            lblDeleteDonor.BackColor = Color.White;
            lblDeleteDonor.Location = new Point(17, 203);
            lblDeleteDonor.Name = "lblDeleteDonor";
            lblDeleteDonor.Size = new Size(100, 25);
            lblDeleteDonor.TabIndex = 42;
            lblDeleteDonor.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 23);
            label1.Name = "label1";
            label1.Size = new Size(265, 57);
            label1.TabIndex = 41;
            label1.Text = "Delete Donor";
            // 
            // DeleteDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(btnSearchtoDelete);
            Controls.Add(txtDeleteID);
            Controls.Add(lblDeleteID);
            Controls.Add(btnDeleteExit);
            Controls.Add(btnDeleteReset);
            Controls.Add(btnDelete);
            Controls.Add(txtDeleteBloodGrp);
            Controls.Add(txtDeleteGender);
            Controls.Add(txtDeleteDOB);
            Controls.Add(txtDeleteEmail);
            Controls.Add(txtDeleteCont);
            Controls.Add(txtDeleteAddr);
            Controls.Add(txtDeleteDonor);
            Controls.Add(lblDeleteEmail);
            Controls.Add(lblDeleteCont);
            Controls.Add(lblDeleteAddr);
            Controls.Add(lblDeleteBloodGrp);
            Controls.Add(lblDeleteDOB);
            Controls.Add(lblDeleteGender);
            Controls.Add(lblDeleteDonor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteDonor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchtoDelete;
        private TextBox txtDeleteID;
        private Label lblDeleteID;
        private Button btnDeleteExit;
        private Button btnDeleteReset;
        private Button btnDelete;
        private ComboBox txtDeleteBloodGrp;
        private ComboBox txtDeleteGender;
        private DateTimePicker txtDeleteDOB;
        private TextBox txtDeleteEmail;
        private TextBox txtDeleteCont;
        private TextBox txtDeleteAddr;
        private TextBox txtDeleteDonor;
        private Label lblDeleteEmail;
        private Label lblDeleteCont;
        private Label lblDeleteAddr;
        private Label lblDeleteBloodGrp;
        private Label lblDeleteDOB;
        private Label lblDeleteGender;
        private Label lblDeleteDonor;
        private Label label1;
    }
}