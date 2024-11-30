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
    public partial class InventInc : Form
    {
        Function func = new Function();
        public InventInc()
        {
            InitializeComponent();
        }

        private void btnIncExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventInc_Load(object sender, EventArgs e)
        {
            String query = "select bloodGroup, units from inventory ";
            DataSet data = func.getData(query);
            dataGridView4.DataSource = data.Tables[0];
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            String query = "update Inventory set units = units + " + cbIncUnits.Text + " where bloodGroup = '" + cbInc.Text + "' "; 
            func.setData(query);
            InventInc_Load(this, null);
        }
    }
}
