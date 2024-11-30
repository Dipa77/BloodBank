namespace BBMS
{
    partial class UpdateDonor
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
            lblUpdateID = new Label();
            btnUpdateExit = new Button();
            btnUpdateReset = new Button();
            btnUpdate = new Button();
            txtUpdateBloodGrp = new ComboBox();
            txtUpdateGender = new ComboBox();
            txtUpdateDOB = new DateTimePicker();
            txtUpdateEmail = new TextBox();
            txtUpdateCont = new TextBox();
            txtUpdateAddr = new TextBox();
            txtUpdateDonor = new TextBox();
            lblUpdateEmail = new Label();
            lblUpdateCont = new Label();
            lblUpdateAddr = new Label();
            lblUpdateBloodGrp = new Label();
            lblUpdateDOB = new Label();
            lblUpdateGender = new Label();
            lblUpdateDonor = new Label();
            txtUpdateID = new TextBox();
            btnSearchtoUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(421, 57);
            label1.TabIndex = 0;
            label1.Text = "Update Donor Details";
            // 
            // lblUpdateID
            // 
            lblUpdateID.BackColor = Color.White;
            lblUpdateID.Location = new Point(3, 125);
            lblUpdateID.Name = "lblUpdateID";
            lblUpdateID.Size = new Size(100, 25);
            lblUpdateID.TabIndex = 38;
            lblUpdateID.Text = "Donor ID";
            // 
            // btnUpdateExit
            // 
            btnUpdateExit.Location = new Point(596, 431);
            btnUpdateExit.Name = "btnUpdateExit";
            btnUpdateExit.Size = new Size(94, 29);
            btnUpdateExit.TabIndex = 37;
            btnUpdateExit.Text = "Exit";
            btnUpdateExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdateReset
            // 
            btnUpdateReset.Location = new Point(478, 431);
            btnUpdateReset.Name = "btnUpdateReset";
            btnUpdateReset.Size = new Size(94, 29);
            btnUpdateReset.TabIndex = 36;
            btnUpdateReset.Text = "Reset";
            btnUpdateReset.UseVisualStyleBackColor = true;
            btnUpdateReset.Click += btnUpdateReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(361, 431);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUpdateBloodGrp
            // 
            txtUpdateBloodGrp.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUpdateBloodGrp.FormattingEnabled = true;
            txtUpdateBloodGrp.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtUpdateBloodGrp.Location = new Point(487, 122);
            txtUpdateBloodGrp.Name = "txtUpdateBloodGrp";
            txtUpdateBloodGrp.Size = new Size(184, 28);
            txtUpdateBloodGrp.TabIndex = 34;
            // 
            // txtUpdateGender
            // 
            txtUpdateGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUpdateGender.FormattingEnabled = true;
            txtUpdateGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtUpdateGender.Location = new Point(133, 235);
            txtUpdateGender.Name = "txtUpdateGender";
            txtUpdateGender.Size = new Size(184, 28);
            txtUpdateGender.TabIndex = 33;
            // 
            // txtUpdateDOB
            // 
            txtUpdateDOB.Location = new Point(133, 293);
            txtUpdateDOB.Name = "txtUpdateDOB";
            txtUpdateDOB.Size = new Size(184, 27);
            txtUpdateDOB.TabIndex = 32;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(487, 291);
            txtUpdateEmail.Multiline = true;
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(184, 27);
            txtUpdateEmail.TabIndex = 31;
            txtUpdateEmail.Text = "                                                                                         ";
            // 
            // txtUpdateCont
            // 
            txtUpdateCont.Location = new Point(487, 238);
            txtUpdateCont.Multiline = true;
            txtUpdateCont.Name = "txtUpdateCont";
            txtUpdateCont.Size = new Size(184, 25);
            txtUpdateCont.TabIndex = 30;
            txtUpdateCont.Text = "   ";
            // 
            // txtUpdateAddr
            // 
            txtUpdateAddr.Location = new Point(487, 179);
            txtUpdateAddr.Multiline = true;
            txtUpdateAddr.Name = "txtUpdateAddr";
            txtUpdateAddr.Size = new Size(184, 25);
            txtUpdateAddr.TabIndex = 29;
            txtUpdateAddr.Text = "     ";
            // 
            // txtUpdateDonor
            // 
            txtUpdateDonor.Location = new Point(133, 179);
            txtUpdateDonor.Multiline = true;
            txtUpdateDonor.Name = "txtUpdateDonor";
            txtUpdateDonor.Size = new Size(184, 25);
            txtUpdateDonor.TabIndex = 28;
            // 
            // lblUpdateEmail
            // 
            lblUpdateEmail.BackColor = Color.White;
            lblUpdateEmail.Location = new Point(361, 291);
            lblUpdateEmail.Name = "lblUpdateEmail";
            lblUpdateEmail.Size = new Size(90, 27);
            lblUpdateEmail.TabIndex = 27;
            lblUpdateEmail.Text = "Email";
            // 
            // lblUpdateCont
            // 
            lblUpdateCont.BackColor = Color.White;
            lblUpdateCont.Location = new Point(361, 235);
            lblUpdateCont.Name = "lblUpdateCont";
            lblUpdateCont.Size = new Size(90, 25);
            lblUpdateCont.TabIndex = 26;
            lblUpdateCont.Text = "Contact No.";
            // 
            // lblUpdateAddr
            // 
            lblUpdateAddr.BackColor = Color.White;
            lblUpdateAddr.Location = new Point(361, 182);
            lblUpdateAddr.Name = "lblUpdateAddr";
            lblUpdateAddr.Size = new Size(90, 25);
            lblUpdateAddr.TabIndex = 25;
            lblUpdateAddr.Text = "Address";
            // 
            // lblUpdateBloodGrp
            // 
            lblUpdateBloodGrp.BackColor = Color.White;
            lblUpdateBloodGrp.Location = new Point(361, 125);
            lblUpdateBloodGrp.Name = "lblUpdateBloodGrp";
            lblUpdateBloodGrp.Size = new Size(100, 20);
            lblUpdateBloodGrp.TabIndex = 24;
            lblUpdateBloodGrp.Text = "Blood Group";
            // 
            // lblUpdateDOB
            // 
            lblUpdateDOB.BackColor = Color.White;
            lblUpdateDOB.Location = new Point(3, 298);
            lblUpdateDOB.Name = "lblUpdateDOB";
            lblUpdateDOB.Size = new Size(100, 20);
            lblUpdateDOB.TabIndex = 23;
            lblUpdateDOB.Text = "Date of Birth";
            // 
            // lblUpdateGender
            // 
            lblUpdateGender.BackColor = Color.White;
            lblUpdateGender.Location = new Point(3, 243);
            lblUpdateGender.Name = "lblUpdateGender";
            lblUpdateGender.Size = new Size(100, 20);
            lblUpdateGender.TabIndex = 22;
            lblUpdateGender.Text = "Gender";
            // 
            // lblUpdateDonor
            // 
            lblUpdateDonor.BackColor = Color.White;
            lblUpdateDonor.Location = new Point(3, 179);
            lblUpdateDonor.Name = "lblUpdateDonor";
            lblUpdateDonor.Size = new Size(100, 25);
            lblUpdateDonor.TabIndex = 21;
            lblUpdateDonor.Text = "Name";
            // 
            // txtUpdateID
            // 
            txtUpdateID.Location = new Point(133, 122);
            txtUpdateID.Name = "txtUpdateID";
            txtUpdateID.Size = new Size(109, 27);
            txtUpdateID.TabIndex = 39;
            txtUpdateID.TextChanged += txtUpdateID_TextChanged;
            // 
            // btnSearchtoUpdate
            // 
            btnSearchtoUpdate.BackColor = Color.LightGray;
            btnSearchtoUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchtoUpdate.Location = new Point(248, 120);
            btnSearchtoUpdate.Name = "btnSearchtoUpdate";
            btnSearchtoUpdate.Size = new Size(69, 30);
            btnSearchtoUpdate.TabIndex = 40;
            btnSearchtoUpdate.Text = "Search";
            btnSearchtoUpdate.UseVisualStyleBackColor = false;
            btnSearchtoUpdate.Click += btnSearchtoUpdate_Click;
            // 
            // UpdateDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(702, 486);
            Controls.Add(btnSearchtoUpdate);
            Controls.Add(txtUpdateID);
            Controls.Add(lblUpdateID);
            Controls.Add(btnUpdateExit);
            Controls.Add(btnUpdateReset);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdateBloodGrp);
            Controls.Add(txtUpdateGender);
            Controls.Add(txtUpdateDOB);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdateCont);
            Controls.Add(txtUpdateAddr);
            Controls.Add(txtUpdateDonor);
            Controls.Add(lblUpdateEmail);
            Controls.Add(lblUpdateCont);
            Controls.Add(lblUpdateAddr);
            Controls.Add(lblUpdateBloodGrp);
            Controls.Add(lblUpdateDOB);
            Controls.Add(lblUpdateGender);
            Controls.Add(lblUpdateDonor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDonor";
            Load += UpdateDonor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUpdateID;
        private Button btnUpdateExit;
        private Button btnUpdateReset;
        private Button btnUpdate;
        private ComboBox txtUpdateBloodGrp;
        private ComboBox txtUpdateGender;
        private DateTimePicker txtUpdateDOB;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdateCont;
        private TextBox txtUpdateAddr;
        private TextBox txtUpdateDonor;
        private Label lblUpdateEmail;
        private Label lblUpdateCont;
        private Label lblUpdateAddr;
        private Label lblUpdateBloodGrp;
        private Label lblUpdateDOB;
        private Label lblUpdateGender;
        private Label lblUpdateDonor;
        private TextBox txtUpdateID;
        private Button btnSearchtoUpdate;
    }
}