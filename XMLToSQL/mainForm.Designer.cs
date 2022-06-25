namespace XMLToSQL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lstBoxHeadkeys = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.errorProviderFileType = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFileTyeError = new System.Windows.Forms.Label();
            this.lblKeysFromFile = new System.Windows.Forms.Label();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstBoxSQLKeys = new System.Windows.Forms.ListBox();
            this.lblSQLKeys = new System.Windows.Forms.Label();
            this.dgvSQLTable = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFKTableREF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFKColumnRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSQLPreview = new System.Windows.Forms.Label();
            this.btnCreateSQL = new System.Windows.Forms.Button();
            this.dgvConfigTable = new System.Windows.Forms.DataGridView();
            this.columName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllowNulls = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnPrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnForeignKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnFKReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFKTableCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConfig = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.PictureBox();
            this.btnClearConfigTable = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClearPreview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.txtBoxTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.chkBoxAuto = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.FileName = "openFileDialogXML,";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnalyze.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalyze.Location = new System.Drawing.Point(50, 197);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(100, 33);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze File";
            this.toolTip1.SetToolTip(this.btnAnalyze, "Retrieve the head key nodes from the XML file");
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lstBoxHeadkeys
            // 
            this.lstBoxHeadkeys.FormattingEnabled = true;
            this.lstBoxHeadkeys.ItemHeight = 15;
            this.lstBoxHeadkeys.Location = new System.Drawing.Point(162, 197);
            this.lstBoxHeadkeys.Name = "lstBoxHeadkeys";
            this.lstBoxHeadkeys.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxHeadkeys.Size = new System.Drawing.Size(183, 229);
            this.lstBoxHeadkeys.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenFile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFile.Location = new System.Drawing.Point(50, 114);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(100, 33);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.toolTip1.SetToolTip(this.btnOpenFile, "Opens the seledcted XML file");
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxFileName.Location = new System.Drawing.Point(162, 118);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(566, 29);
            this.txtBoxFileName.TabIndex = 2;
            this.txtBoxFileName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFileName_Validating);
            // 
            // errorProviderFileType
            // 
            this.errorProviderFileType.ContainerControl = this;
            // 
            // lblFileTyeError
            // 
            this.lblFileTyeError.AutoSize = true;
            this.lblFileTyeError.ForeColor = System.Drawing.Color.Red;
            this.lblFileTyeError.Location = new System.Drawing.Point(162, 154);
            this.lblFileTyeError.Name = "lblFileTyeError";
            this.lblFileTyeError.Size = new System.Drawing.Size(0, 15);
            this.lblFileTyeError.TabIndex = 3;
            // 
            // lblKeysFromFile
            // 
            this.lblKeysFromFile.AutoSize = true;
            this.lblKeysFromFile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeysFromFile.ForeColor = System.Drawing.Color.Blue;
            this.lblKeysFromFile.Location = new System.Drawing.Point(161, 171);
            this.lblKeysFromFile.Name = "lblKeysFromFile";
            this.lblKeysFromFile.Size = new System.Drawing.Size(105, 20);
            this.lblKeysFromFile.TabIndex = 4;
            this.lblKeysFromFile.Text = "Keys From File:";
            // 
            // btnTo
            // 
            this.btnTo.Image = global::XMLToSQL.Properties.Resources.Right_Small;
            this.btnTo.Location = new System.Drawing.Point(367, 265);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(35, 29);
            this.btnTo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnTo, "Add selected key to the SQL keys list");
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::XMLToSQL.Properties.Resources.Left_Small;
            this.btnBack.Location = new System.Drawing.Point(367, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 29);
            this.btnBack.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnBack, "Remove the selected key from the SQL keys list");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstBoxSQLKeys
            // 
            this.lstBoxSQLKeys.FormattingEnabled = true;
            this.lstBoxSQLKeys.ItemHeight = 15;
            this.lstBoxSQLKeys.Location = new System.Drawing.Point(428, 197);
            this.lstBoxSQLKeys.Name = "lstBoxSQLKeys";
            this.lstBoxSQLKeys.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxSQLKeys.Size = new System.Drawing.Size(183, 229);
            this.lstBoxSQLKeys.TabIndex = 7;
            // 
            // lblSQLKeys
            // 
            this.lblSQLKeys.AutoSize = true;
            this.lblSQLKeys.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSQLKeys.ForeColor = System.Drawing.Color.Blue;
            this.lblSQLKeys.Location = new System.Drawing.Point(428, 171);
            this.lblSQLKeys.Name = "lblSQLKeys";
            this.lblSQLKeys.Size = new System.Drawing.Size(121, 20);
            this.lblSQLKeys.TabIndex = 8;
            this.lblSQLKeys.Text = "SQL Keys To Use:";
            // 
            // dgvSQLTable
            // 
            this.dgvSQLTable.AllowUserToAddRows = false;
            this.dgvSQLTable.AllowUserToDeleteRows = false;
            this.dgvSQLTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSQLTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSQLTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvSQLTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.columnPrimary,
            this.dataGridViewTextBoxColumn4,
            this.columnFKTableREF,
            this.columnFKColumnRef});
            this.dgvSQLTable.Location = new System.Drawing.Point(162, 528);
            this.dgvSQLTable.Name = "dgvSQLTable";
            this.dgvSQLTable.RowHeadersVisible = false;
            this.dgvSQLTable.RowTemplate.Height = 25;
            this.dgvSQLTable.Size = new System.Drawing.Size(1345, 327);
            this.dgvSQLTable.TabIndex = 9;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Column Name";
            this.columnName.Name = "columnName";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Data Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Allow Nulls";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // columnPrimary
            // 
            this.columnPrimary.HeaderText = "Primary Key";
            this.columnPrimary.Name = "columnPrimary";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Foreign Key";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // columnFKTableREF
            // 
            this.columnFKTableREF.HeaderText = "Foreign Key Table Ref";
            this.columnFKTableREF.Name = "columnFKTableREF";
            // 
            // columnFKColumnRef
            // 
            this.columnFKColumnRef.HeaderText = "Foreign Key Column Ref";
            this.columnFKColumnRef.Name = "columnFKColumnRef";
            // 
            // lblSQLPreview
            // 
            this.lblSQLPreview.AutoSize = true;
            this.lblSQLPreview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSQLPreview.ForeColor = System.Drawing.Color.Blue;
            this.lblSQLPreview.Location = new System.Drawing.Point(162, 495);
            this.lblSQLPreview.Name = "lblSQLPreview";
            this.lblSQLPreview.Size = new System.Drawing.Size(91, 20);
            this.lblSQLPreview.TabIndex = 10;
            this.lblSQLPreview.Text = "SQL Preview:";
            // 
            // btnCreateSQL
            // 
            this.btnCreateSQL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateSQL.Enabled = false;
            this.btnCreateSQL.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateSQL.Location = new System.Drawing.Point(1234, 885);
            this.btnCreateSQL.Name = "btnCreateSQL";
            this.btnCreateSQL.Size = new System.Drawing.Size(156, 33);
            this.btnCreateSQL.TabIndex = 11;
            this.btnCreateSQL.Text = "Create SQL Table";
            this.toolTip1.SetToolTip(this.btnCreateSQL, "Creates or modifies the selected database and table");
            this.btnCreateSQL.UseVisualStyleBackColor = false;
            this.btnCreateSQL.Click += new System.EventHandler(this.btnCreateSQL_Click);
            // 
            // dgvConfigTable
            // 
            this.dgvConfigTable.AllowUserToAddRows = false;
            this.dgvConfigTable.AllowUserToDeleteRows = false;
            this.dgvConfigTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfigTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvConfigTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columName,
            this.columnDataType,
            this.columnSize,
            this.columnAllowNulls,
            this.columnPrimaryKey,
            this.columnForeignKey,
            this.columnFKReference,
            this.columnFKTableCell});
            this.dgvConfigTable.Location = new System.Drawing.Point(631, 198);
            this.dgvConfigTable.Name = "dgvConfigTable";
            this.dgvConfigTable.RowHeadersVisible = false;
            this.dgvConfigTable.RowTemplate.Height = 25;
            this.dgvConfigTable.Size = new System.Drawing.Size(876, 228);
            this.dgvConfigTable.TabIndex = 12;
            // 
            // columName
            // 
            this.columName.HeaderText = "Column Name";
            this.columName.Name = "columName";
            // 
            // columnDataType
            // 
            this.columnDataType.HeaderText = "Data Type";
            this.columnDataType.Name = "columnDataType";
            this.columnDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnSize
            // 
            this.columnSize.HeaderText = "Size";
            this.columnSize.Name = "columnSize";
            // 
            // columnAllowNulls
            // 
            this.columnAllowNulls.HeaderText = "Allow Nulls";
            this.columnAllowNulls.Name = "columnAllowNulls";
            this.columnAllowNulls.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnAllowNulls.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnPrimaryKey
            // 
            this.columnPrimaryKey.HeaderText = "Primary Key";
            this.columnPrimaryKey.Name = "columnPrimaryKey";
            this.columnPrimaryKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnPrimaryKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnForeignKey
            // 
            this.columnForeignKey.HeaderText = "Foreign Key";
            this.columnForeignKey.Name = "columnForeignKey";
            this.columnForeignKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnForeignKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnFKReference
            // 
            this.columnFKReference.HeaderText = "Foreign Key Table Reference";
            this.columnFKReference.Name = "columnFKReference";
            // 
            // columnFKTableCell
            // 
            this.columnFKTableCell.HeaderText = "Foreign Key Table Column Reference ";
            this.columnFKTableCell.Name = "columnFKTableCell";
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfig.ForeColor = System.Drawing.Color.Blue;
            this.lblConfig.Location = new System.Drawing.Point(631, 171);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(106, 20);
            this.lblConfig.TabIndex = 13;
            this.lblConfig.Text = "SQL Table Data:";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(20, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(233, 44);
            this.title.TabIndex = 14;
            this.title.TabStop = false;
            // 
            // btnClearConfigTable
            // 
            this.btnClearConfigTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearConfigTable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearConfigTable.Location = new System.Drawing.Point(1407, 444);
            this.btnClearConfigTable.Name = "btnClearConfigTable";
            this.btnClearConfigTable.Size = new System.Drawing.Size(100, 33);
            this.btnClearConfigTable.TabIndex = 15;
            this.btnClearConfigTable.Text = "Clear Table";
            this.toolTip1.SetToolTip(this.btnClearConfigTable, "Clears the data from the table");
            this.btnClearConfigTable.UseVisualStyleBackColor = false;
            this.btnClearConfigTable.Click += new System.EventHandler(this.btnClearConfigTable_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreview.Location = new System.Drawing.Point(50, 528);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 33);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview Table";
            this.toolTip1.SetToolTip(this.btnPreview, "Displays the layout of the SQL file to create");
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClearPreview
            // 
            this.btnClearPreview.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearPreview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearPreview.Location = new System.Drawing.Point(50, 579);
            this.btnClearPreview.Name = "btnClearPreview";
            this.btnClearPreview.Size = new System.Drawing.Size(100, 33);
            this.btnClearPreview.TabIndex = 17;
            this.btnClearPreview.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClearPreview, "Clears the data from the table");
            this.btnClearPreview.UseVisualStyleBackColor = false;
            this.btnClearPreview.Click += new System.EventHandler(this.btnClearPreview_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1407, 885);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits the program");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatabaseName.Location = new System.Drawing.Point(162, 891);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(140, 20);
            this.lblDatabaseName.TabIndex = 19;
            this.lblDatabaseName.Text = "Enter database name:";
            this.toolTip1.SetToolTip(this.lblDatabaseName, "The name of database to create or modify");
            // 
            // txtBoxDatabaseName
            // 
            this.txtBoxDatabaseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDatabaseName.Location = new System.Drawing.Point(307, 888);
            this.txtBoxDatabaseName.Name = "txtBoxDatabaseName";
            this.txtBoxDatabaseName.Size = new System.Drawing.Size(363, 26);
            this.txtBoxDatabaseName.TabIndex = 20;
            this.txtBoxDatabaseName.TextChanged += new System.EventHandler(this.txtBoxDatabaseName_TextChanged);
            // 
            // txtBoxTableName
            // 
            this.txtBoxTableName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTableName.Location = new System.Drawing.Point(819, 888);
            this.txtBoxTableName.Name = "txtBoxTableName";
            this.txtBoxTableName.Size = new System.Drawing.Size(379, 26);
            this.txtBoxTableName.TabIndex = 22;
            this.txtBoxTableName.TextChanged += new System.EventHandler(this.txtBoxTableName_TextChanged);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableName.Location = new System.Drawing.Point(699, 891);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(114, 20);
            this.lblTableName.TabIndex = 21;
            this.lblTableName.Text = "Enter table name:";
            this.toolTip1.SetToolTip(this.lblTableName, "The name of the table to create or modify for the selected database");
            // 
            // chkBoxAuto
            // 
            this.chkBoxAuto.AutoSize = true;
            this.chkBoxAuto.Location = new System.Drawing.Point(634, 440);
            this.chkBoxAuto.Name = "chkBoxAuto";
            this.chkBoxAuto.Size = new System.Drawing.Size(184, 19);
            this.chkBoxAuto.TabIndex = 24;
            this.chkBoxAuto.Text = "Auto Incremental Primary Key";
            this.toolTip1.SetToolTip(this.chkBoxAuto, "Creates an ID  primary key that is auto incrementing");
            this.chkBoxAuto.UseVisualStyleBackColor = true;
            this.chkBoxAuto.CheckedChanged += new System.EventHandler(this.chkBoxAuto_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1545, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.testConnectionToolStripMenuItem.Text = "Test Connection";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLCredentialsToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // mySQLCredentialsToolStripMenuItem
            // 
            this.mySQLCredentialsToolStripMenuItem.Name = "mySQLCredentialsToolStripMenuItem";
            this.mySQLCredentialsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mySQLCredentialsToolStripMenuItem.Text = "MySQL Credentials";
            this.mySQLCredentialsToolStripMenuItem.Click += new System.EventHandler(this.mySQLCredentialsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1545, 932);
            this.Controls.Add(this.chkBoxAuto);
            this.Controls.Add(this.txtBoxTableName);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.txtBoxDatabaseName);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearPreview);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnClearConfigTable);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lstBoxHeadkeys);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.lblFileTyeError);
            this.Controls.Add(this.lblKeysFromFile);
            this.Controls.Add(this.lblSQLKeys);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstBoxSQLKeys);
            this.Controls.Add(this.dgvSQLTable);
            this.Controls.Add(this.lblSQLPreview);
            this.Controls.Add(this.btnCreateSQL);
            this.Controls.Add(this.dgvConfigTable);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML TO SQL CONVERTER";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ListBox lstBoxSQLKeys;
        private System.Windows.Forms.ListBox lstBoxHeadkeys;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.ErrorProvider errorProviderFileType;
        private System.Windows.Forms.Label lblFileTyeError;
        private System.Windows.Forms.Label lblKeysFromFile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Label lblSQLKeys;
        private System.Windows.Forms.Label lblSQLPreview;
        private System.Windows.Forms.DataGridView dgvSQLTable;
        private System.Windows.Forms.Button btnCreateSQL;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.DataGridView dgvConfigTable;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.Button btnClearConfigTable;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClearPreview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columName;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAllowNulls;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnPrimaryKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnForeignKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFKReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFKTableCell;
        private System.Windows.Forms.TextBox txtBoxTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtBoxDatabaseName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrimary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFKTableREF;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFKColumnRef;
        private System.Windows.Forms.CheckBox chkBoxAuto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

