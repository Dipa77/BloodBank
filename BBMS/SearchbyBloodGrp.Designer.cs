namespace BBMS
{
    partial class SearchbyBloodGrp
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
            txtSearchbyBloodGrp = new TextBox();
            dataGridView3 = new DataGridView();
            btnSearchbyBGExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(574, 64);
            label1.TabIndex = 0;
            label1.Text = "Search Donor by Blood Group";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(172, 96);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            // 
            // txtSearchbyBloodGrp
            // 
            txtSearchbyBloodGrp.Location = new Point(303, 96);
            txtSearchbyBloodGrp.Name = "txtSearchbyBloodGrp";
            txtSearchbyBloodGrp.Size = new Size(313, 27);
            txtSearchbyBloodGrp.TabIndex = 2;
            txtSearchbyBloodGrp.TextChanged += txtSearchbyLocation_TextChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.LightGray;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(19, 154);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(674, 303);
            dataGridView3.TabIndex = 3;
            // 
            // btnSearchbyBGExit
            // 
            btnSearchbyBGExit.Location = new Point(599, 477);
            btnSearchbyBGExit.Name = "btnSearchbyBGExit";
            btnSearchbyBGExit.Size = new Size(94, 29);
            btnSearchbyBGExit.TabIndex = 4;
            btnSearchbyBGExit.Text = "Exit";
            btnSearchbyBGExit.UseVisualStyleBackColor = true;
            // 
            // SearchbyBloodGrp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(btnSearchbyBGExit);
            Controls.Add(dataGridView3);
            Controls.Add(txtSearchbyBloodGrp);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchbyBloodGrp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchbyBloodGrp";
            Load += SearchbyBloodGrp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchbyBloodGrp;
        private DataGridView dataGridView3;
        private Button btnSearchbyBGExit;
    }
}