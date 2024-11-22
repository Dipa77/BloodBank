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
    public partial class AddNewDonor : Form
    {
        Function func = new Function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(newDonorID) from addNewDonor";
            DataSet data = func.getData(query);
            int count = int.Parse(data.Tables[0].Rows[0][0].ToString());
            lblNewId.Text = (count + 1).ToString();

        }

        private void btnNewExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            if (txtNewDonor.Text != "" && txtNewCont.Text != "" && txtNewAddr.Text != "")
            {
                String newDonorName = txtNewDonor.Text;
                String newContact = txtNewCont.Text;
                String newAddr = txtNewAddr.Text;

                String query = "Insert into addNewDonor (newDonorName, newContact, newAddr) values('" + newDonorName + "', '" + newContact + "', '" + newAddr + "')";
                func.setData(query);
            }
            else
            {
                MessageBox.Show("Fill the required fields.");
            }
        }

        private void btnNewReset_Click(object sender, EventArgs e)
        {
            txtNewDonor.Clear();
            txtNewCont.Clear();
            txtNewAddr.Clear(); 
            txtNewEmail.Clear();    
           

        }
    }
}
