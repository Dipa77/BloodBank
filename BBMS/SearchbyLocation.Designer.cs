namespace BBMS
{
    partial class SearchbyLocation
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
            txtSearchbyLocation = new TextBox();
            dataGridView2 = new DataGridView();
            btnSearchbyLocExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 31);
            label1.Name = "label1";
            label1.Size = new Size(501, 57);
            label1.TabIndex = 0;
            label1.Text = "Search Donor by Location";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(171, 105);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 1;
            label2.Text = "Address";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchbyLocation
            // 
            txtSearchbyLocation.Location = new Point(291, 105);
            txtSearchbyLocation.Name = "txtSearchbyLocation";
            txtSearchbyLocation.Size = new Size(297, 27);
            txtSearchbyLocation.TabIndex = 2;
            txtSearchbyLocation.TextChanged += txtSearchbyLocation_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(30, 162);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(659, 293);
            dataGridView2.TabIndex = 3;
            // 
            // btnSearchbyLocExit
            // 
            btnSearchbyLocExit.Location = new Point(595, 479);
            btnSearchbyLocExit.Name = "btnSearchbyLocExit";
            btnSearchbyLocExit.Size = new Size(94, 29);
            btnSearchbyLocExit.TabIndex = 4;
            btnSearchbyLocExit.Text = "Exit";
            btnSearchbyLocExit.UseVisualStyleBackColor = true;
            btnSearchbyLocExit.Click += btnSearchbyLocExit_Click;
            // 
            // SearchbyLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(btnSearchbyLocExit);
            Controls.Add(dataGridView2);
            Controls.Add(txtSearchbyLocation);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchbyLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchbyLocation";
            Load += SearchbyLocation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchbyLocation;
        private DataGridView dataGridView2;
        private Button btnSearchbyLocExit;
    }
}