using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace XMLToSQL
{
    public partial class passwordForm : Form
    {

        bool boolGoodCredentials = false; // Flag to indicate if the credentials have been entered into the form

        SQL.SQLAccess updatedCredentials = new SQL.SQLAccess();

        public passwordForm(SQL.SQLAccess savedCredentials)
        {           
            updatedCredentials = savedCredentials;

            InitializeComponent();

            loadUserName(savedCredentials.userName);

            this.ActiveControl = txtBoxPassword;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            boolGoodCredentials = checkData();

            this.Close();
        }


        private void loadUserName(string userName)
        {
            // Loads the username into the form
            txtBoxUsername.Text = userName;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Closes the form

            this.Close();
        }

        private bool checkData()
        {
            // Checks the form for valid input

            bool boolCheck = true;

            foreach (TextBox txtBox in this.Controls.OfType<TextBox>().ToList())
            {
                if (txtBox.Text == "")
                {
                    txtBox.BackColor = Color.Yellow;
                    MessageBox.Show("Required field cannot be blank", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    boolCheck = false;

                    break;
                }

            }

            return boolCheck;

        }

        public bool GetCredentials()
        {
            // Returns boolGoodCredentials 
            return boolGoodCredentials;
        }

        public SQL.SQLAccess GetAccessCredentials()
        {
            // Gets the access credentials from the form
                                             
            updatedCredentials.userName = txtBoxUsername.Text.Trim();
            updatedCredentials.password = txtBoxPassword.Text.Trim();

            return updatedCredentials;

        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            boolGoodCredentials = checkData();

            this.Close();
        }
    }
}
