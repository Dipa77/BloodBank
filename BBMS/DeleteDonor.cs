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
    public partial class DeleteDonor : Form
    {
        Function func = new Function();
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void btnDeleteExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchtoDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteID.Text != "")
            {
                String query = "select * from addNewDonor where newDonorID = " + txtDeleteID.Text + "";
                DataSet data = func.getData(query);

                if (data.Tables[0].Rows.Count != 0)
                {
                    txtDeleteDonor.Text = data.Tables[0].Rows[0][1].ToString();

                    txtDeleteGender.Text = data.Tables[0].Rows[0][2].ToString();
                    txtDeleteDOB.Text = data.Tables[0].Rows[0][3].ToString();
                    txtDeleteBloodGrp.Text = data.Tables[0].Rows[0][4].ToString();
                    txtDeleteAddr.Text = data.Tables[0].Rows[0][5].ToString();
                    txtDeleteCont.Text = data.Tables[0].Rows[0][6].ToString();
                    txtDeleteEmail.Text = data.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDeleteID.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete it?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String query = "delete from addNewDonor where newDonorID = " + txtDeleteID.Text + " ";
                func.setData(query);
            }
        }

        private void txtDeleteID_TextChanged(object sender, EventArgs e)
        {
            if(txtDeleteID.Text == "")
            { txtDeleteDonor.Clear();
                txtDeleteGender.ResetText();
                txtDeleteDOB.ResetText();
                txtDeleteBloodGrp.ResetText();
                txtDeleteAddr.Clear();
                txtDeleteCont.Clear();
                txtDeleteEmail.Clear();

            }
        }
    }
}
