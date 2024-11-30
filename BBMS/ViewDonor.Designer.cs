namespace BBMS
{
    partial class ViewDonor
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
            btnListExit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(249, 22);
            label1.Name = "label1";
            label1.Size = new Size(241, 57);
            label1.TabIndex = 0;
            label1.Text = "Donors' List";
            // 
            // btnListExit
            // 
            btnListExit.Location = new Point(600, 482);
            btnListExit.Name = "btnListExit";
            btnListExit.Size = new Size(94, 29);
            btnListExit.TabIndex = 1;
            btnListExit.Text = "Exit";
            btnListExit.UseVisualStyleBackColor = true;
            btnListExit.Click += btnListExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(668, 371);
            dataGridView1.TabIndex = 2;
            // 
            // ViewDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(dataGridView1);
            Controls.Add(btnListExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDonor";
            Load += ViewDonor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnListExit;
        private DataGridView dataGridView1;
    }
}