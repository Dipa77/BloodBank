namespace BBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user" && txtPassword.Text == "pass")
            {
                MessageBox.Show("Login successful!");

                //to navigate to the Dashboard
                Dashboard form = new Dashboard();
                form.Show();
                Visible = false;
            }
            else
            {
                if (MessageBox.Show("Incorrect username or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }

            }

        }

        private void cbTC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTC.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
