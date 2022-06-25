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
    public partial class setupForm : Form
    {

        bool boolGoodCredentials = false; // Flag to indicate if the credentials have been entered into the form

        SQL.SQLAccess credentials = new SQL.SQLAccess();

        public setupForm(SQL.SQLAccess savedCredentials)
        {

            if (savedCredentials.serverName != "" && savedCredentials.portNumber != "" && savedCredentials.userName != "")
            {

                credentials.serverName = savedCredentials.serverName;
                credentials.portNumber = savedCredentials.portNumber;
                credentials.userName = savedCredentials.userName;
                credentials.password = savedCredentials.password;

            }

            InitializeComponent();
        }

        private void setupFrm_Load(object sender, EventArgs e)
        {

            if (credentials.serverName != "" && credentials.portNumber != "" && credentials.userName != "")
            {

                txtBoxServer.Text = credentials.serverName;

                txtBoxPort.Text = credentials.portNumber;

                txtBoxUsername.Text = credentials.userName;

                txtBoxPassword.Text = credentials.password;

            }            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Saves the setup file

            FileIO.FileOperations newFileIO = new FileIO.FileOperations();

            boolGoodCredentials = CheckData();

            if (boolGoodCredentials)
            {

                credentials = GetAccessCredentials();

                newFileIO.SaveSetupFile(credentials);

                this.Close();

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
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
