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
    
    public partial class ViewInvent : Form
    {
        Function func = new Function();
        public ViewInvent()
        {
            InitializeComponent();
        }

        private void btnViewInventExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewInvent_Load(object sender, EventArgs e)
        {
            String query = "select * from Inventory ";
            DataSet data = func.getData(query);
            dataGridView6 .DataSource = data.Tables[0];
        }
    }
}
