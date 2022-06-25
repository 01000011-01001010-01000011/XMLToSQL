/* Created by Chris Clarke June 2022*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLToSQL
{
    public partial class MainForm : Form
    {
        bool boolDatabaseName = false;

        bool boolTableName = false;

        bool boolAutoPrimaryKey = false;

        bool boolAccessCredentials = false;

        bool boolNeedSQLServerPassword = false;

        List<KeyValuePair<string, string>> XMLDataList = new List<KeyValuePair<string, string>>();

        List<string> listOfKeys = new List<string>();

        List<string> selectedFileKeys = new List<string>();

        List<string> selectedSQLKeys = new List<string>();

        string fileName = "";

        int intCallingProcess = 0; // 1 = Connect to SQL server, 2 = Test connection to SQL Server 

        int intSetupProcess = 0; //  1 = Load setup file, 2 = Check system file

        SQL.SQLAccess sqlAccessCredentials = new SQL.SQLAccess();

        loginForm newLoginForm;

        passwordForm newPasswordForm;

        setupForm newSetupForm;

        FileIO.FileOperations newFileIO = new FileIO.FileOperations();

        XML.XMLOperations xmlOperations = new XML.XMLOperations();

        public MainForm()
        {            
            CheckForSetupFolder();

            intSetupProcess = 1;

            CheckSetupFile();

            SetupDGVConfigTable();

            InitializeComponent();
        }

        /*** START OF BUTTONS ***/

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Gets the XML nodes from the selected file and displays them in the lstBoxHeadKeys list box

            AnalyzeFile();

            GetXMLFileData();           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Removes the selected keys from the lstBoxSQLKeys list box and returns them back to the lstBoxHeadkeys list box

            selectedSQLKeys = GetListOfSelectedItems(this.lstBoxSQLKeys);

            for (int i = 0; i < selectedSQLKeys.Count; i++)
            {
                lstBoxSQLKeys.Items.Remove(selectedSQLKeys[i]);

                lstBoxHeadkeys.Items.Add(selectedSQLKeys[i]);
            }

            if (lstBoxSQLKeys.Items.Count > 0)
            {
                LoadDGVConfigTable();
            }

        }

        private void btnClearConfigTable_Click(object sender, EventArgs e)
        {
            // Clears the dgvConfigTable datagridview and clears the contents from the lstSQLKeys list box

            if (dgvConfigTable.Rows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Warning this will clear the selected SQL keys list. Do you want to continue?", "Clear Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    if (dgvConfigTable.Rows.Count > 0)
                    {
                        ClearTable(dgvConfigTable);
                    }

                    List<string> allListBoxItems = GetAllListBoxItems(lstBoxSQLKeys);

                    if (allListBoxItems.Count > 0)
                    {

                        for (int i = 0; i < allListBoxItems.Count; i++)
                        {

                            lstBoxHeadkeys.Items.Add(allListBoxItems[i]);

                            lstBoxSQLKeys.Items.Remove(allListBoxItems[i]);

                        }

                    }

                }

            }

        }

        private void btnClearPreview_Click(object sender, EventArgs e)
        {
            // Clears the data from the SQL preview table

            ClearTable(dgvSQLTable);

        }

        private void btnCreateSQL_Click(object sender, EventArgs e)
        {
            // Creates the SQL database and table

            intCallingProcess = 1; // Connect to SQL Server

            if (boolNeedSQLServerPassword)
            {
                OpenPasswordForm();
            }
            else
            {

                if (boolAccessCredentials)
                {

                    CreateSQLDatabase();

                }
                else
                {
                    OpenLoginForm();

                }

            }

        }              
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            // Displays the layout of the MySQL Table

            // Check for valid table data
            bool goodData = CheckTableData();

            if (goodData)
            {
                List<SQL.SQLData> sqlDataList = GetTableData();

                LoadDataIntoPreviewTable(sqlDataList);

            }

        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            // Adds the selected keys to the lstBoxSQLKeys list box from the lstBoxHeadkeys list box

            selectedFileKeys = GetListOfSelectedItems(this.lstBoxHeadkeys);

            for (int i = 0; i < selectedFileKeys.Count; i++)
            {
                lstBoxSQLKeys.Items.Add(selectedFileKeys[i]);

                lstBoxHeadkeys.Items.Remove(selectedFileKeys[i]);
            }

            if (lstBoxSQLKeys.Items.Count > 0)
            {
                LoadDGVConfigTable();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            System.Windows.Forms.Application.Exit();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Opens an openfiledialog box for the user to select an XML file to analyze 

            newFileIO = new FileIO.FileOperations();

            fileName = newFileIO.OpenXMLFile();

            txtBoxFileName.Text = fileName;

            bool fileExists = newFileIO.CheckIfDatabaseExists(fileName);

            if (fileExists)
            {
               XMLDataList = xmlOperations.GetXMLDataList(fileName);
            }

        }

        private void btnTestSQLConnection_Click(object sender, EventArgs e)
        {
            CallTestSQLConnection();
        }

        /*** END OF BUTTONS ***/

        /*** START OF MENU STRIP ***/
        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallTestSQLConnection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mySQLCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates or edits the server setup file

            CheckSetupFile();
        }

        /*** END OF MENU STRIP ***/

        /*** START OF TEXT BOXES ***/
        private void chkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            boolAutoPrimaryKey = chkBoxAuto.Checked ? true : false;          
        }

        /*** START OF TEXT BOXES ***/

        private void txtBoxFileName_Validating(object sender, CancelEventArgs e)
        {
            // Checks the file name for the xml extension 

            if (txtBoxFileName.Text.ToLower().IndexOf(".xml") < 0)
            {
                errorProviderFileType.SetError(txtBoxFileName, "File selected is not an xml file");

                lblFileTyeError.Text = "Incorrect file type. Filename should end with the extension .xml";

                this.btnAnalyze.Enabled = false;
            }
            else
            {
                this.btnAnalyze.Enabled = true;
            }

        }

        private void txtBoxDatabaseName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxDatabaseName.Text != "" || txtBoxDatabaseName.TextLength > 0)
            {
                boolDatabaseName = true;
            }
            else
            {
                boolDatabaseName = false;
            }

            EnableCreateSQLButton();
        }


        private void txtBoxTableName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTableName.Text != "" || txtBoxTableName.TextLength > 0)
            {
                boolTableName = true;
            }
            else
            {
                boolTableName = false;
            }

            EnableCreateSQLButton();
        }

        /*** END OF TEXT BOXES ***/

        private List<string> AddComboBoxItems()
        {

            // Adds the data type values for the datagridview comboboxes

            List<string> listOfValues = new List<string>();    

            listOfValues.Add("CHAR");
            listOfValues.Add("VARCHAR");
            listOfValues.Add("BINARY");
            listOfValues.Add("VARBINARY");
            listOfValues.Add("TINYBLOB");
            listOfValues.Add("TINYTEXT");
            listOfValues.Add("TEXT");
            listOfValues.Add("BLOB");
            listOfValues.Add("MEDIUMTEXT");
            listOfValues.Add("MEDIUMBLOB");
            listOfValues.Add("LONGTEXT");
            listOfValues.Add("LONGBLOB");
            listOfValues.Add("BIT");
            listOfValues.Add("TINYINT");
            listOfValues.Add("BOOL");
            listOfValues.Add("BOOLEAN");
            listOfValues.Add("SMALLINT");
            listOfValues.Add("MEDIUMINT");
            listOfValues.Add("INT");
            listOfValues.Add("INTEGER");
            listOfValues.Add("BIGINT");
            listOfValues.Add("FLOAT");
            listOfValues.Add("DOUBLE");
            listOfValues.Add("DECIMAL");
            listOfValues.Add("DEC");
            listOfValues.Add("DATE");
            listOfValues.Add("DATETIME");
            listOfValues.Add("TIMESTAMP");
            listOfValues.Add("TIME");
            listOfValues.Add("YEAR");

            return listOfValues;

        }

        private void AnalyzeFile()
        {
            // Analyzes the file and adds the head keys to the head keys list box

            listOfKeys= xmlOperations.GetXMLKeys(fileName);

            if (listOfKeys.Count > 0)
            {
                for (int i = 0; i < listOfKeys.Count; i++)
                    lstBoxHeadkeys.Items.Add(listOfKeys[i]);
            }
        }


        private void CheckForSetupFolder()
        {
            // Checks for the program setup folder

            newFileIO = new FileIO.FileOperations();

            bool goodFolder = newFileIO.CheckForSetupFolder();
                       
            // If folder doesn't exist create the folder
            if(!goodFolder)
            {
                newFileIO.CreateSetupFolder();
            }

        }

        private void CheckSetupFile()
        {
            // Checks the setup file for data
                        
            // Check for the setup file
            // If it doesn't exist open the setup form
            bool fileExists = newFileIO.CheckForSetupFile();

            if (fileExists)
            {

                sqlAccessCredentials = newFileIO.GetSetupFileData();

                if (sqlAccessCredentials.serverName != null && sqlAccessCredentials.portNumber != "" && sqlAccessCredentials.userName != "")
                {

                    boolNeedSQLServerPassword = true;

                }

                if (intSetupProcess == 2)
                {

                    OpenSetupForm();

                }

            }

        }

        private bool CheckTableData()
        {
            // Checks the SQl table data for the required fields

            bool goodData = true;

            string message = "";

            if(dgvConfigTable.Rows.Count < 1)
            {
                goodData = false;
            }
            else
            {

                for(int i = 0; i < dgvConfigTable.Rows.Count; i++)
                {
                    if (dgvConfigTable.Rows[i].Cells[0].Value == null || dgvConfigTable.Rows[i].Cells[0].Value.ToString() == "")
                    { 

                        message = "Columns names cannot be blank.";

                        goodData = false;

                        break;
                    }

                    if(dgvConfigTable.Rows[i].Cells[1].Value == null || dgvConfigTable.Rows[i].Cells[1].Value.ToString() == "")                      
                    {
                        
                        message = "Data types cannot be blank.";

                        goodData = false;

                        break;

                    }                                                                             
                    
                    if ((bool)dgvConfigTable.Rows[i].Cells[5].Value)
                    {
                                              
                        if (dgvConfigTable.Rows[i].Cells[6].Value == null || dgvConfigTable.Rows[i].Cells[6].Value.ToString() == "")
                        {
                        
                            message = "Foreign keys need to reference the name of the foreign table.";

                            goodData = false;

                            break;
                        }

                        if(dgvConfigTable.Rows[i].Cells[7].Value == null || dgvConfigTable.Rows[i].Cells[7].Value.ToString() == "")
                        {

                            message = "Foreign keys need to reference the column name of the foreign table.";
                            
                            goodData = false;

                            break;

                        }

                    }

                }

                if (!goodData)
                {
                    MessageBox.Show(message, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return goodData;
        }


        private void ClearTable (DataGridView selectedDGV)
        {
            // Clears the dgvConfigTable datagridview
            selectedDGV.Rows.Clear();
            selectedDGV.DataSource = null;               
        }

        private void CreateSQLDatabase()
        {
            // Creates the SQL database and table            

            bool goodData = CheckTableData();

            if (goodData)
            {

                List<SQL.SQLData> sqlDataList = GetTableData();

                if (sqlDataList != null && sqlDataList.Count > 0)
                {

                    SQL.SQLOperations sqlOperations = new SQL.SQLOperations();

                    List<string> response = new List<string>();// Response string from the MySQL request

                    string databaseName = txtBoxDatabaseName.Text;

                    string tableName = txtBoxTableName.Text;

                    if (boolDatabaseName && boolTableName)
                    {

                        // Check to see if database already exists
                        bool boolFound = newFileIO.CheckIfDatabaseExists(databaseName);

                        // Create the database if it dosen't exist
                        if (!boolFound)
                        {

                            sqlOperations.CreateSQLDatabaseFile(databaseName, sqlAccessCredentials);

                            response.Clear();

                            response = sqlOperations.GetResponse();

                            ShowResponse(response);

                        }

                        response.Clear();

                        // Create or add table to the database
                        sqlOperations.AddTableToDatabase(sqlDataList, databaseName, tableName, boolAutoPrimaryKey, sqlAccessCredentials);
                                               
                        response = sqlOperations.GetResponse();

                        ShowResponse(response);

                        response.Clear();

                        // Add xml file data to the table
                        selectedSQLKeys = GetAllListBoxItems(lstBoxSQLKeys);

                        sqlOperations.AddDataToTable(sqlDataList, databaseName, tableName, selectedSQLKeys, XMLDataList, sqlAccessCredentials);
                                                
                        ShowResponse(response);

                    }
                    else
                    {
                        string message = "";

                        if (databaseName == "")
                        {
                            message = "Please enter the database name to create or modify.";

                        }
                        else
                        {
                            if (tableName == "")
                            {
                                message = "Please enter the table name to create or modify.";
                            }
                        }

                        MessageBox.Show(message, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

        }

        private void EnableCreateSQLButton()
        {
            // Enables the create SQL button when both the database name and table name fields have been entered
            if (boolDatabaseName && boolTableName)
            {
                btnCreateSQL.Enabled = true;
            }
            else
            {
                btnCreateSQL.Enabled = false;
            }

        }
               
        private List<string> GetAllListBoxItems(ListBox selectedListBox)
        {
            // Returns a list of all of the items from the selected list box

            List<string> lstBoxItems = new List<string>();

            foreach (var item in selectedListBox.Items)
            {
                lstBoxItems.Add(item.ToString());
            }

            return lstBoxItems;
        }

        private List<string> GetListOfSelectedItems(ListBox selectedListBox)
        {
            // Returns a list of selected items from the selected list box

            List<string> selectedItems = new List<string>();

            foreach (var item in selectedListBox.SelectedItems)
            {
                selectedItems.Add(item.ToString());
            }

            return selectedItems;
        }

        private List<SQL.SQLData> GetTableData()
        {
            // Gets the values from the dgvConfigTable datagridview

            SQL.SQLData newSQLData; 

            List<SQL.SQLData> sqlDataList = new List<SQL.SQLData>();
                      
            boolAutoPrimaryKey = chkBoxAuto.Checked ? true : false;

            for (int i = 0; i < dgvConfigTable.RowCount; i++)
            {
                newSQLData = new SQL.SQLData();

                newSQLData.name = dgvConfigTable.Rows[i].Cells[0].Value.ToString();
                newSQLData.dataType = dgvConfigTable.Rows[i].Cells[1].Value.ToString();

                if (dgvConfigTable.Rows[i].Cells[2].Value.ToString() != "")
                {
                    newSQLData.size = dgvConfigTable.Rows[i].Cells[2].Value.ToString();
                }

                newSQLData.allowNulls = dgvConfigTable.Rows[i].Cells[3].Value.ToString();

                if (boolAutoPrimaryKey)
                {
                    newSQLData.primaryKey = "false";
                }
                else 
                {
                    newSQLData.primaryKey = dgvConfigTable.Rows[i].Cells[4].Value.ToString();
                }

                newSQLData.foreignKey = dgvConfigTable.Rows[i].Cells[5].Value.ToString();
                newSQLData.foreignKeyTableRef = dgvConfigTable.Rows[i].Cells[6].Value.ToString();
                newSQLData.foreignKeyColumnRef = dgvConfigTable.Rows[i].Cells[7].Value.ToString();
                
                sqlDataList.Add(newSQLData);

            }

            return sqlDataList;

        }

        private void GetXMLFileData()
        {
            // Loads the XML file data into the XML data list

            bool fileExists = newFileIO.CheckIfFileExists(fileName);

            if (fileExists)
            {
                XMLDataList = xmlOperations.GetXMLDataList(fileName);                
            }

        }

        private void LoadDGVConfigTable()
        {

            // Clear table of existing data

            if (dgvConfigTable.Rows.Count > 0) 
            {
                ClearTable(dgvConfigTable);
            }
            
            List<string> cmbBoxValues = AddComboBoxItems();
                                            
            if (lstBoxSQLKeys.Items.Count > 0) {
                
                
                for (int i = 0; i < lstBoxSQLKeys.Items.Count; i++) {

                    int rowNum = dgvConfigTable.Rows.Add();
                                                                                                          
                    DataGridViewRow row = dgvConfigTable.Rows[rowNum];

                    row.Cells[0].Value = lstBoxSQLKeys.Items[i].ToString();

                    DataGridViewComboBoxCell cmbBoxCell = new DataGridViewComboBoxCell();

                    cmbBoxCell = (DataGridViewComboBoxCell)dgvConfigTable.Rows[rowNum].Cells["columnDataType"];

                    for (int j = 0; j < cmbBoxValues.Count; j++)
                    {
                        cmbBoxCell.Items.Add(cmbBoxValues[j]);
                    }

                    row.Cells[2].Value = "";
                    row.Cells[3].Value = false;
                    row.Cells[4].Value = false;
                    row.Cells[5].Value = false;
                    row.Cells[6].Value = "";
                    row.Cells[7].Value = "";
                                                                               
               }

            }
        
        }

        private void LoadDataIntoPreviewTable(List<SQL.SQLData> sqlDataList)
        {
            // Loads data into the preview table datagridview
            if (dgvSQLTable.Rows.Count > 0)
            {
                ClearTable(dgvSQLTable);
            }

            List<string> cmbBoxValues = AddComboBoxItems();

            if (sqlDataList.Count > 0)
            {

                for (int i = 0; i < sqlDataList.Count; i++)
                {

                    int rowNum = dgvSQLTable.Rows.Add();

                    DataGridViewRow row = dgvSQLTable.Rows[rowNum];

                    row.Cells[0].Value = sqlDataList[i].name;
                    row.Cells[1].Value = sqlDataList[i].dataType;
                    row.Cells[2].Value = sqlDataList[i].size;
                    row.Cells[3].Value = sqlDataList[i].allowNulls;
                    row.Cells[4].Value = sqlDataList[i].primaryKey;
                    row.Cells[5].Value = sqlDataList[i].foreignKey;
                    row.Cells[6].Value = sqlDataList[i].foreignKeyTableRef;
                    row.Cells[7].Value = sqlDataList[i].foreignKeyColumnRef;                                       

                }

            }

        }

        private void NewLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Gets the values from the MySQL login form

            boolAccessCredentials = newLoginForm.GetCredentials();
                     
            if (boolAccessCredentials)
            {
                sqlAccessCredentials = newLoginForm.GetAccessCredentials();

                switch (intCallingProcess)
                {

                    case 1:

                        newLoginForm.Hide();

                        CreateSQLDatabase();

                        break;

                    case 2:
                
                        newLoginForm.Hide();
                        TestSQLConnection();

                        break;
                }

            }

        }

        private void NewPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Gets the values from the MySQL login form

            boolAccessCredentials = newPasswordForm.GetCredentials();

            if (boolAccessCredentials)
            {
                sqlAccessCredentials = newPasswordForm.GetAccessCredentials();

                boolNeedSQLServerPassword = false;

                switch (intCallingProcess)
                {

                    case 1:

                        newPasswordForm.Hide();

                        CreateSQLDatabase();

                        break;

                    case 2:

                        newPasswordForm.Hide();

                        TestSQLConnection();

                        break;
                }

            }

        }

        private void NewSetupForm_Closing(object sender, FormClosingEventArgs e)
        {
            // Gets the values from the MySQL setup form

            boolAccessCredentials = newSetupForm.GetCredentials(); // Check for valid data

            if (boolAccessCredentials)
            {
                sqlAccessCredentials = newSetupForm.GetAccessCredentials();

                boolNeedSQLServerPassword = false;
            }

        }

        private void OpenLoginForm()
        {
            // Opens the MySQL login form
            newLoginForm = new loginForm();
            newLoginForm.Activate();
            newLoginForm.Show();

            newLoginForm.FormClosing += NewLoginForm_FormClosing;
        }

        private void OpenPasswordForm()
        {
            // Opens the MySQL password form
            newPasswordForm = new passwordForm(sqlAccessCredentials);
            newPasswordForm.Activate();
            newPasswordForm.Show();

            newPasswordForm.FormClosing += NewPasswordForm_FormClosing;

        }

        private void OpenSetupForm()
        {
            // Opens the MySQL setup form

            newSetupForm = new setupForm(sqlAccessCredentials);
            newSetupForm.Activate();
            newSetupForm.Show();

            newSetupForm.FormClosing += NewSetupForm_Closing;


        }

        private void SetupDGVConfigTable()
        {
            // Sets default paramaeters for the dgvConfigTable datagridview

            this.dgvConfigTable = new DataGridView();

            this.dgvConfigTable.AllowUserToAddRows = false;
            this.dgvConfigTable.AllowUserToDeleteRows = false;

        }

        private void ShowResponse(List<string> response)
        {
            // Displays the response from the SQL server

            if (response.Count > 0)
            {
                if (response[1] == "success")
                {

                    MessageBox.Show(response[0], "SQL OPERATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(response[0], "SQL OPERATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          
        /*** TEST SQL CONNECTION ***/

        private void CallTestSQLConnection()
        {
            // Calls the test connection function 

            intCallingProcess = 2;

            if (boolNeedSQLServerPassword)
            {
                OpenPasswordForm();
            }
            else
            {

                if (boolAccessCredentials)
                {
                    TestSQLConnection();
                }
                else
                {
                    OpenLoginForm();

                    if (boolAccessCredentials)
                    {
                        TestSQLConnection();
                    }

                }
            }
        }

        private void TestSQLConnection()
        {
            // Tests the connection to the MySQL server

            SQL.SQLOperations sqlOperations = new SQL.SQLOperations();

            sqlOperations.CheckSQLServerConnection(sqlAccessCredentials);

            List<string> response = sqlOperations.GetResponse();

            if (response[1] == "success")
            {
                MessageBox.Show(response[0], "Test SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response[0], "Test SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

}
