using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor addNewDonor = new AddNewDonor();
            addNewDonor.Show();
        }

        private void updateDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonor updateDonor = new UpdateDonor();
            updateDonor.Show();
        }

        private void viewDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.Show();
        }

        private void byLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchbyLocation searchbyLocation = new SearchbyLocation();
            searchbyLocation.Show();
        }

        private void byBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchbyBloodGrp searchbyBloodGrp = new SearchbyBloodGrp();
            searchbyBloodGrp.Show();
        }

        private void incrementStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventInc inventInc = new InventInc();
            inventInc.Show();
        }

        private void decreaseStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventDec inventDec = new InventDec();
            inventDec.Show();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInvent viewInvent = new ViewInvent();
            viewInvent.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor deleteDonor = new DeleteDonor();
            deleteDonor.Show();     
        }
    }
}
