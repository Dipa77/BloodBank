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
    public partial class SearchbyLocation : Form
    {
        Function func = new Function();
        public SearchbyLocation()
        {
            InitializeComponent();
        }

        private void btnSearchbyLocExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchbyLocation_Load(object sender, EventArgs e)
        {
            String query = "select * from addNewDonor";
            DataSet data = func.getData(query);
            dataGridView2.DataSource = data.Tables[0];

        }

        private void txtSearchbyLocation_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchbyLocation.Text != "")
            {
                String query = "select * from addNewDonor where newAddr like '%" + txtSearchbyLocation.Text + "%'";

                DataSet data = func.getData(query);
                dataGridView2.DataSource = data.Tables[0]; 
            }
            else
            {
                String query = "select * from addNewDonor";
                DataSet data = func.getData(query);
                dataGridView2.DataSource= data.Tables[0]; 
            }
        }
    }
}
