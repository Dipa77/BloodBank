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
    public partial class ViewDonor : Form
    {
        Function func = new Function();
        public ViewDonor()
        {
            InitializeComponent();
        }

        private void btnListExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDonor_Load(object sender, EventArgs e)
        {
            String query = "select * from addNewDonor ";
            DataSet data = func.getData(query);
            dataGridView1.DataSource = data.Tables[0]; 
        }
    }
}
