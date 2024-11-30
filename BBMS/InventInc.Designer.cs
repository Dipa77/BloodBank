namespace BBMS
{
    partial class InventInc
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
            label2 = new Label();
            label3 = new Label();
            btnInc = new Button();
            btnIncExit = new Button();
            cbInc = new ComboBox();
            cbIncUnits = new ComboBox();
            dataGridView4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 18);
            label1.Name = "label1";
            label1.Size = new Size(402, 59);
            label1.TabIndex = 0;
            label1.Text = "Inventory Increment";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(361, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 1;
            label2.Text = "Units";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(44, 98);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 2;
            label3.Text = "Blood Group";
            // 
            // btnInc
            // 
            btnInc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInc.ForeColor = Color.LimeGreen;
            btnInc.Location = new Point(604, 98);
            btnInc.Name = "btnInc";
            btnInc.Size = new Size(94, 29);
            btnInc.TabIndex = 3;
            btnInc.Text = "Increment";
            btnInc.UseVisualStyleBackColor = true;
            btnInc.Click += btnInc_Click;
            // 
            // btnIncExit
            // 
            btnIncExit.Location = new Point(604, 479);
            btnIncExit.Name = "btnIncExit";
            btnIncExit.Size = new Size(94, 29);
            btnIncExit.TabIndex = 4;
            btnIncExit.Text = "Exit";
            btnIncExit.UseVisualStyleBackColor = true;
            btnIncExit.Click += btnIncExit_Click;
            // 
            // cbInc
            // 
            cbInc.FormattingEnabled = true;
            cbInc.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cbInc.Location = new Point(155, 95);
            cbInc.Name = "cbInc";
            cbInc.Size = new Size(151, 28);
            cbInc.TabIndex = 5;
            // 
            // cbIncUnits
            // 
            cbIncUnits.FormattingEnabled = true;
            cbIncUnits.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cbIncUnits.Location = new Point(429, 95);
            cbIncUnits.Name = "cbIncUnits";
            cbIncUnits.Size = new Size(151, 28);
            cbIncUnits.TabIndex = 6;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.LightGray;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(10, 146);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(688, 313);
            dataGridView4.TabIndex = 7;
            // 
            // InventInc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(dataGridView4);
            Controls.Add(cbIncUnits);
            Controls.Add(cbInc);
            Controls.Add(btnIncExit);
            Controls.Add(btnInc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventInc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventInc";
            Load += InventInc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInc;
        private Button btnIncExit;
        private ComboBox cbInc;
        private ComboBox cbIncUnits;
        private DataGridView dataGridView4;
    }
}