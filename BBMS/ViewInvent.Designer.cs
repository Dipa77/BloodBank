namespace BBMS
{
    partial class ViewInvent
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
            dataGridView6 = new DataGridView();
            btnViewInventExit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToOrderColumns = true;
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.BackgroundColor = Color.LightGray;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(16, 110);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(688, 354);
            dataGridView6.TabIndex = 23;
            // 
            // btnViewInventExit
            // 
            btnViewInventExit.Location = new Point(610, 484);
            btnViewInventExit.Name = "btnViewInventExit";
            btnViewInventExit.Size = new Size(94, 29);
            btnViewInventExit.TabIndex = 20;
            btnViewInventExit.Text = "Exit";
            btnViewInventExit.UseVisualStyleBackColor = true;
            btnViewInventExit.Click += btnViewInventExit_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 20);
            label1.Name = "label1";
            label1.Size = new Size(353, 59);
            label1.TabIndex = 16;
            label1.Text = "Inventory Details";
            // 
            // ViewInvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(720, 533);
            Controls.Add(dataGridView6);
            Controls.Add(btnViewInventExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInvent";
            Text = "ViewInvent";
            Load += ViewInvent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView6;
        private Button btnViewInventExit;
        private Label label1;
    }
}