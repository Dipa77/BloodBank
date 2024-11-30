namespace BBMS
{
    partial class InventDec
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
            dataGridView5 = new DataGridView();
            cbDecUnits = new ComboBox();
            cbDec = new ComboBox();
            btnDecExit = new Button();
            btnDec = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView5
            // 
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.BackgroundColor = Color.LightGray;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(16, 149);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(688, 313);
            dataGridView5.TabIndex = 15;
            // 
            // cbDecUnits
            // 
            cbDecUnits.FormattingEnabled = true;
            cbDecUnits.Items.AddRange(new object[] { "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10", "-11", "-12", "-13", "-14", "-15" });
            cbDecUnits.Location = new Point(435, 98);
            cbDecUnits.Name = "cbDecUnits";
            cbDecUnits.Size = new Size(151, 28);
            cbDecUnits.TabIndex = 14;
            // 
            // cbDec
            // 
            cbDec.FormattingEnabled = true;
            cbDec.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cbDec.Location = new Point(161, 98);
            cbDec.Name = "cbDec";
            cbDec.Size = new Size(151, 28);
            cbDec.TabIndex = 13;
            // 
            // btnDecExit
            // 
            btnDecExit.Location = new Point(610, 482);
            btnDecExit.Name = "btnDecExit";
            btnDecExit.Size = new Size(94, 29);
            btnDecExit.TabIndex = 12;
            btnDecExit.Text = "Exit";
            btnDecExit.UseVisualStyleBackColor = true;
            btnDecExit.Click += btnDecExit_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDec.ForeColor = Color.LimeGreen;
            btnDec.Location = new Point(610, 101);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(94, 29);
            btnDec.TabIndex = 11;
            btnDec.Text = "Decrement";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnDec_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(50, 101);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 10;
            label3.Text = "Blood Group";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(367, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 9;
            label2.Text = "Units";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 18);
            label1.Name = "label1";
            label1.Size = new Size(411, 59);
            label1.TabIndex = 8;
            label1.Text = "Inventory Decrement";
            // 
            // InventDec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(dataGridView5);
            Controls.Add(cbDecUnits);
            Controls.Add(cbDec);
            Controls.Add(btnDecExit);
            Controls.Add(btnDec);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventDec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventDec";
            Load += InventDec_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView5;
        private ComboBox cbDecUnits;
        private ComboBox cbDec;
        private Button btnDecExit;
        private Button btnDec;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}