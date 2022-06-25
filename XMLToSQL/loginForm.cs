/* Created by Chris Clarke June 2022*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLToSQL
{
    public partial class loginForm : Form
    {

        bool boolGoodCredentials = false; // Flag to indicate if the credentials have been entered into the form
      
        public loginForm()
        {
            InitializeComponent();
        }

        /*** START OF BUTTONS ***/

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            boolGoodCredentials= CheckData();

            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            boolGoodCredentials = false;

            this.Close();

        }

        /*** END OF BUTTONS ***/

        /*** START OF TEXTBOXES ***/

        private void txtBoxServer_TextChanged(object sender, EventArgs e)
        {
            txtBoxServer.BackColor = Color.White;
        }

        private void txtBoxPort_TextChanged(object sender, EventArgs e)
        {
            txtBoxPort.BackColor = Color.White;
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            txtBoxUsername.BackColor = Color.White;
        }
    
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            txtBoxPassword.BackColor = Color.White;
        }


        /*** END OF TEXTBOXES ***/

        private bool CheckData()
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
           
            SQL.SQLAccess credentials = new SQL.SQLAccess();

            credentials.serverName = txtBoxServer.Text.Trim();
            credentials.portNumber = txtBoxPort.Text.Trim();
            credentials.userName = txtBoxUsername.Text.Trim();
            credentials.password = txtBoxPassword.Text.Trim();

            return credentials;

        }
              
    }
}