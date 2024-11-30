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
    public partial class InventDec : Form
    {
        Function func = new Function();
        public InventDec()
        {
            InitializeComponent();
        }

        private void btnDecExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventDec_Load(object sender, EventArgs e)
        {
            String query = "select bloodGroup, units from inventory ";
            DataSet data = func.getData(query);
            dataGridView5.DataSource = data.Tables[0];
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            String query = "update Inventory set units = units + " + cbDecUnits.Text + " where bloodGroup = '" + cbDec.Text + "' ";
            func.setData(query);
            InventDec_Load(this, null);
        }
    }
}
