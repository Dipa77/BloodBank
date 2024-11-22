namespace BBMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addNewDonorToolStripMenuItem = new ToolStripMenuItem();
            updateDonorDetailsToolStripMenuItem = new ToolStripMenuItem();
            viewDonorsToolStripMenuItem = new ToolStripMenuItem();
            searchBloodDonorToolStripMenuItem = new ToolStripMenuItem();
            byLocationToolStripMenuItem = new ToolStripMenuItem();
            byBloodGroupToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            incrementStockToolStripMenuItem = new ToolStripMenuItem();
            decreaseStockToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutOurCommunityToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.IndianRed;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchBloodDonorToolStripMenuItem, inventoryToolStripMenuItem, deleteDonorToolStripMenuItem, logOutToolStripMenuItem, helpToolStripMenuItem, aboutOurCommunityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1394, 80);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonorToolStripMenuItem, updateDonorDetailsToolStripMenuItem, viewDonorsToolStripMenuItem });
            donorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Size = new Size(105, 76);
            donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonorToolStripMenuItem
            // 
            addNewDonorToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonorToolStripMenuItem.Image");
            addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            addNewDonorToolStripMenuItem.Size = new Size(303, 32);
            addNewDonorToolStripMenuItem.Text = "Add New Donor";
            addNewDonorToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            addNewDonorToolStripMenuItem.Click += addNewDonorToolStripMenuItem_Click;
            // 
            // updateDonorDetailsToolStripMenuItem
            // 
            updateDonorDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDonorDetailsToolStripMenuItem.Image");
            updateDonorDetailsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            updateDonorDetailsToolStripMenuItem.Name = "updateDonorDetailsToolStripMenuItem";
            updateDonorDetailsToolStripMenuItem.Size = new Size(303, 32);
            updateDonorDetailsToolStripMenuItem.Text = "Update Donor Details";
            // 
            // viewDonorsToolStripMenuItem
            // 
            viewDonorsToolStripMenuItem.Image = (Image)resources.GetObject("viewDonorsToolStripMenuItem.Image");
            viewDonorsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            viewDonorsToolStripMenuItem.Name = "viewDonorsToolStripMenuItem";
            viewDonorsToolStripMenuItem.Size = new Size(303, 32);
            viewDonorsToolStripMenuItem.Text = "View Donors";
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { byLocationToolStripMenuItem, byBloodGroupToolStripMenuItem });
            searchBloodDonorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBloodDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchBloodDonorToolStripMenuItem.Image");
            searchBloodDonorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            searchBloodDonorToolStripMenuItem.Size = new Size(235, 76);
            searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // byLocationToolStripMenuItem
            // 
            byLocationToolStripMenuItem.Image = (Image)resources.GetObject("byLocationToolStripMenuItem.Image");
            byLocationToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            byLocationToolStripMenuItem.Name = "byLocationToolStripMenuItem";
            byLocationToolStripMenuItem.Size = new Size(247, 32);
            byLocationToolStripMenuItem.Text = "By Location";
            // 
            // byBloodGroupToolStripMenuItem
            // 
            byBloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("byBloodGroupToolStripMenuItem.Image");
            byBloodGroupToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            byBloodGroupToolStripMenuItem.Name = "byBloodGroupToolStripMenuItem";
            byBloodGroupToolStripMenuItem.Size = new Size(247, 32);
            byBloodGroupToolStripMenuItem.Text = "By Blood Group";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incrementStockToolStripMenuItem, decreaseStockToolStripMenuItem });
            inventoryToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryToolStripMenuItem.Image = (Image)resources.GetObject("inventoryToolStripMenuItem.Image");
            inventoryToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(138, 76);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // incrementStockToolStripMenuItem
            // 
            incrementStockToolStripMenuItem.Image = (Image)resources.GetObject("incrementStockToolStripMenuItem.Image");
            incrementStockToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            incrementStockToolStripMenuItem.Name = "incrementStockToolStripMenuItem";
            incrementStockToolStripMenuItem.Size = new Size(252, 32);
            incrementStockToolStripMenuItem.Text = "Increment Stock";
            // 
            // decreaseStockToolStripMenuItem
            // 
            decreaseStockToolStripMenuItem.Image = (Image)resources.GetObject("decreaseStockToolStripMenuItem.Image");
            decreaseStockToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            decreaseStockToolStripMenuItem.Name = "decreaseStockToolStripMenuItem";
            decreaseStockToolStripMenuItem.Size = new Size(252, 32);
            decreaseStockToolStripMenuItem.Text = "Decrease Stock";
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(173, 76);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(121, 76);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.Image = (Image)resources.GetObject("helpToolStripMenuItem.Image");
            helpToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(90, 76);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutOurCommunityToolStripMenuItem
            // 
            aboutOurCommunityToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutOurCommunityToolStripMenuItem.Image = (Image)resources.GetObject("aboutOurCommunityToolStripMenuItem.Image");
            aboutOurCommunityToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            aboutOurCommunityToolStripMenuItem.Name = "aboutOurCommunityToolStripMenuItem";
            aboutOurCommunityToolStripMenuItem.Size = new Size(260, 76);
            aboutOurCommunityToolStripMenuItem.Text = "About Our Community";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(481, 389);
            label1.Name = "label1";
            label1.Size = new Size(1187, 258);
            label1.TabIndex = 1;
            label1.Text = "Donate Blood, Stay Iconic – Real Heroes Bleed Generosity.";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1394, 543);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem addNewDonorToolStripMenuItem;
        private ToolStripMenuItem updateDonorDetailsToolStripMenuItem;
        private ToolStripMenuItem viewDonorsToolStripMenuItem;
        private ToolStripMenuItem byLocationToolStripMenuItem;
        private ToolStripMenuItem byBloodGroupToolStripMenuItem;
        private ToolStripMenuItem incrementStockToolStripMenuItem;
        private ToolStripMenuItem decreaseStockToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutOurCommunityToolStripMenuItem;
        private Label label1;
    }
}