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
    public partial class UpdateDonor : Form
    {
        Function func = new Function();
        public UpdateDonor()
        {
            InitializeComponent();
        }

        private void btnSearchtoUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUpdateID.Text.ToString());
            String query = "select * from addNewDonor where newDonorID = " + id + " ";
            DataSet data = func.getData(query);

            if (data.Tables[0].Rows.Count != 0)
            {
                txtUpdateDonor.Text = data.Tables[0].Rows[0][1].ToString();
                txtUpdateGender.Text = data.Tables[0].Rows[0][2].ToString();
                txtUpdateDOB.Text = data.Tables[0].Rows[0][3].ToString();
                txtUpdateBloodGrp.Text = data.Tables[0].Rows[0][4].ToString();
                txtUpdateAddr.Text = data.Tables[0].Rows[0][5].ToString();
                txtUpdateCont.Text = data.Tables[0].Rows[0][6].ToString();
                txtUpdateEmail.Text = data.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUpdateID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateID == null)
            {
                txtUpdateDonor.Clear();
                txtUpdateGender.ResetText();
                txtUpdateDOB.ResetText();
                txtUpdateBloodGrp.ResetText();
                txtUpdateAddr.Clear();
                txtUpdateCont.Clear();
                txtUpdateEmail.Clear();

            }
        }

        private void btnUpdateReset_Click(object sender, EventArgs e)
        {
            txtUpdateID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String query = "update addNewDonor set newDonorName = '" + txtUpdateDonor + "' , newGender = '" + txtUpdateGender + "' , newDob = '" + txtUpdateDOB + "' , newBloodGrp = '" + txtUpdateBloodGrp + "' , newAddr = '" + txtUpdateAddr + "' , newContact = '" + txtUpdateCont + "' , newEmail= '" + txtUpdateEmail + "' where newDonorID = " + txtUpdateID.Text; 
            func.setData(query);
            UpdateDonor_Load(this, null); 

        }

        private void UpdateDonor_Load(object sender, EventArgs e)
        {
            txtUpdateID.Clear(); 
        }
    }
}
