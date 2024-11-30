using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class SearchbyBloodGrp : Form
    {
        Function func = new Function();
        public SearchbyBloodGrp()
        {
            InitializeComponent();
        }

        private void SearchbyBloodGrp_Load(object sender, EventArgs e)
        {
            String query = "select * from addNewDonor";
            DataSet data = func.getData(query);
            dataGridView3.DataSource = data.Tables[0];
        }

        private void txtSearchbyLocation_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchbyBloodGrp.Text !="")
            {
                String query = "SELECT * FROM addNewDonor WHERE newBloodGrp LIKE '%" + txtSearchbyBloodGrp.Text + "%'";

                DataSet data = func.getData(query);
                dataGridView3.DataSource= data.Tables[0];

            }
            else
            {
                String query = "select * from addNewDonor";
                DataSet data = func.getData(query);
                dataGridView3.DataSource = data.Tables[0];
            }
        }
    }
}
