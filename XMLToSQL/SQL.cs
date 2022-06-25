/* Created by Chris Clarke June 2022*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace XMLToSQL
{
    public class SQL
    {
        public class SQLData
        {
            public string name;
            public string dataType;
            public string size;
            public string allowNulls;
            public string primaryKey;
            public string foreignKey;
            public string foreignKeyTableRef;
            public string foreignKeyColumnRef;           
        }

        public class SQLAccess 
        {
            public string serverName;
            public string portNumber;
            public string userName;
            public string password; 
        }

        public class SQLOperations
        {
            // List of response strings to display to user after an MySQLCommand is executed
            public List<string> response = new  List<string>();

            int intCallingNum = -1; // 0 = Use database, 1 = Create database, 2 = Create table, 3 = Add data to table

            public void AddDataToTable(List<SQLData> dataTypes, string databaseName, string tableName, List<string> columnNames, List<KeyValuePair<string, string>> xmlDataList, SQLAccess sqlAccess)
            {
                // Adds the XML data to the selected table
                string[,] valuesToAdd = GetDatabaseValues(dataTypes, xmlDataList, columnNames);

                intCallingNum = 3; //  Add XML file data to table                                                         
               
                int totalRows = valuesToAdd.GetLength(0);

                // Add values to the table in the selected column
                if (totalRows > 0)
                {

                    string useDatabase = "USE " + databaseName + ";";

                    string insert = "INSERT INTO `" + tableName + "` (";

                    for (int columns = 0; columns < columnNames.Count; columns++)
                    {

                        insert += "`" + columnNames[columns] + "`";

                        if(columns < columnNames.Count - 1)
                        {
                            insert += ", ";
                        }

                    }

                    insert += ") ";

                    for (int i = 0; i < totalRows; i++)
                    {
                                                                                             
                        string values = " VALUES(";
                                                                        
                        for (int j = 0; j < columnNames.Count; j++)
                        {

                            string valueToAdd = CheckValue(valuesToAdd[i, j].ToString());

                            string type = dataTypes[j].dataType.ToUpper();

                            if(type.Contains("CHAR") || type.Contains("TEXT") || type.Contains("DATE") || type.Contains("TIME"))
                            {
                                values += "'" + valueToAdd + "'";
                            }
                            else
                            {
                                values += valueToAdd;
                            }                                                   
                                                        
                            if(j < columnNames.Count - 1)
                            {
                                values += ", ";
                            }

                        }

                        values += ")";

                        string mySQLCommand = useDatabase + " " + insert + values;

                        ExecuteSQLCommand(mySQLCommand, sqlAccess);

                    }

                }
                               
                // SELECTED COLUMNS
                //INSERT INTO table_name (column1, column2, column3, ...)
                //VALUES(value1, value2, value3, ...);

                // ALL COLUMNS
                //INSERT INTO table_name
                //VALUES(value1, value2, value3, ...);



            }

            public void AddTableToDatabase(List<SQLData> dataList, string databaseName, string tableName, bool boolAutoPrimaryKey, SQLAccess sqlAccess)
            {
                // Adds the table to the selected database

                string commandString = ""; // Command string for MySqlCommands

                string primaryString = ""; // Primary key string

                // Check the data list for primary key if the auto primary key is not selected
                bool hasPrimaryKey = CheckForPrimaryKey(dataList);

                // Build an non auto incremental primary key string
                if (!boolAutoPrimaryKey)
                {

                    if (!hasPrimaryKey)
                    {
                        boolAutoPrimaryKey = true;
                    }
                    else
                    {
                        // List for primary keys
                        List<string> primaryKeys = GetPrimaryKeys(dataList);

                        if (primaryKeys.Count > 0 && primaryKeys != null)
                        {
                            primaryString = BuildPrimaryKeyString(primaryKeys, databaseName);
                        }
                        else
                        {
                            boolAutoPrimaryKey = true;
                        }
                    }

                }

                // Build an auto incremental primary key string
                if (boolAutoPrimaryKey)
                {
                    primaryString = BuildAutoIncrementalPrimaryKeyString();
                }

                // Create table                                                            
                intCallingNum = 2; // Create Table

                string useDatabase = "USE " + databaseName + ";";

                commandString = useDatabase + " CREATE TABLE IF NOT EXISTS " + "`" + tableName + "`" + " (";

                for (int i = 0; i < dataList.Count; i++)
                {
                    commandString += "`" + dataList[i].name + "`" + " " + dataList[i].dataType;

                    if (dataList[i].size != null && dataList[i].size != "")
                    {
                        commandString += "(" + dataList[i].size + ") ";
                    }

                    if (dataList[i].allowNulls != "" && dataList[i].allowNulls == "true")
                    {
                        commandString += "NOT NULL ";
                    }

                    if (dataList[i].foreignKey == "true" && dataList[i].foreignKeyTableRef != "" && dataList[i].foreignKeyColumnRef != "")
                    {
                        commandString += "CONSTRAINT FK_" + databaseName + " FOREIGN KEY(" + dataList[i].foreignKeyColumnRef + ") REFERENCES " + dataList[i].foreignKeyTableRef + "(" + dataList[i].foreignKeyColumnRef + ")";
                    }

                    // Add comma to the end of the current SQL command line
                    commandString += ",";
                    
                }

                // Add the primary key to the command string
                commandString += primaryString + ");";

                MessageBox.Show(commandString);

                ExecuteSQLCommand(commandString, sqlAccess);

            }

            private string BuildAutoIncrementalPrimaryKeyString()
            {
                // Constructs the primary key string for an auto incremental primary key
                string primaryString = "ID int NOT NULL AUTO_INCREMENT,";

                primaryString += "PRIMARY KEY (ID)";

                return primaryString;

            }

            private string BuildPrimaryKeyString(List<string> primaryKeys, string databaseName)
            {
                // Constructs the primary string 
                // CONSTRAINT PK_Person PRIMARY KEY (ID,LastName)

                string primaryString = "";

                if (primaryKeys.Count > 1)
                {

                    primaryString = "CONSTRAINT PK_" + databaseName + " PRIMARY KEY (";


                    for (int i = 0; i < primaryKeys.Count; i++)
                    {

                        primaryString += primaryKeys[i];

                        // Add comma for subsquent keys
                        if (i < primaryKeys.Count - 1)
                        {
                            primaryString += ",";
                        }

                    }

                    primaryString += ")";

                }
                else
                {
                    primaryString = "PRIMARY KEY (" + primaryKeys[0] + ")";

                }

                return primaryString;

            }

            public bool CheckForPrimaryKey(List<SQLData> listOfFields)
            {
                // Checks the list of database fields for a primary key

                bool found = false;

                for (int i = 0; i < listOfFields.Count; i++)
                {

                    if (listOfFields[i].primaryKey == "true")
                    {
                        found = true;

                        break;
                    }

                }

                return found;

            }

            public void CheckSQLServerConnection(SQLAccess sqlAccess)
            {
                // Tests the connection to the SQL server

                try
                {

                    MySql.Data.MySqlClient.MySqlConnection myConn = new MySqlConnection($"server={sqlAccess.serverName};username={sqlAccess.userName};password={sqlAccess.password};port={sqlAccess.portNumber}");

                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        // MessageBox.Show("Connection Successful.");

                        response.Add("Connection Successful.");
                        response.Add("success");
                    }

                    myConn.Close();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);

                    response.Add(ex.ToString());
                    response.Add("error");

                }

            }

            private string CheckValue(string valueToCheck)
            {
                // Checks the value for special characters

                string checkedValue = "";

                if (!valueToCheck.Contains("..."))
                {
                    if (valueToCheck.Contains('.'))
                    {
                        valueToCheck = valueToCheck.Replace('.', '-');
                    }
                }

                return checkedValue = valueToCheck;

            }

            public void CreateSQLDatabaseFile(string databaseName, SQLAccess sqlAccess)
            {
                // Creates the SQL database file

                int intCallingNum = 1; // Create Database

                string commandStr = "CREATE DATABASE IF NOT EXISTS " + databaseName + ";";

                ExecuteSQLCommand(commandStr, sqlAccess);

            }

            public void ExecuteSQLCommand(string commandStr, SQLAccess sqlAccess)
            {
                // Opens a connection to the MySQL server
                // Executes the SQL command as specified in str

                try
                {

                    MySqlConnection myConn = new MySqlConnection($"server={sqlAccess.serverName};username={sqlAccess.userName};password={sqlAccess.password};port={sqlAccess.portNumber}");

                    myConn.Open();

                    try
                    {

                        MySqlCommand mySqlCommand = new MySqlCommand(commandStr, myConn);

                        mySqlCommand.ExecuteNonQuery();

                        switch (intCallingNum)
                        {

                            case 0:

                                string databaseName = GetDatabaseName(commandStr);
                                response.Add("Using database " + databaseName);
                                response.Add("success");

                                break;

                            case 1:

                                response.Add("Database has been created successfully");
                                response.Add("success");

                                break;

                            case 2:

                                response.Add("Table has been created successfully");
                                response.Add("success");

                                break;

                            case 3:

                                response.Add("XML file data has been successfully imported into the table");
                                response.Add("success");

                                break;
                        }

                    }
                    catch (System.Exception ex)
                    {
                        response.Add("ERROR: " + ex.ToString() + " " + ex.Message.ToString());
                        response.Add("error");

                    }
                    finally
                    {
                        if (myConn.State == ConnectionState.Open)
                        {
                            myConn.Close();
                        }
                    }


                }
                catch (Exception ex)
                {

                    response.Add("ERROR " + ex.Message.ToString());
                    response.Add("error");

                }

                // Reset intCallingNum
                intCallingNum = -1;

            }

            private string GetDatabaseName(string commandString)
            {
                // Returns the name of the database from the MySQL command string

                int start = commandString.IndexOf(" ");

                int length = commandString.Length;

                string databaseName = commandString.Substring(start, length - start);

                databaseName = databaseName.Replace(';', ' ').Trim();

                return databaseName;
            }

            public List<string> GetPrimaryKeys(List<SQLData> listOfFields)
            {
                // Returns a list of all primary keys

                List<string> primaryKeys = new List<string>();

                for (int i = 0; i < listOfFields.Count; i++)
                {

                    if (listOfFields[i].primaryKey == "true")
                    {
                        primaryKeys.Add(listOfFields[i].name);
                    }

                }

                return primaryKeys;

            }

            public List<string> GetResponse()
            {
                // Returns the response from the MySQL command

                return response;
            }

            private string[,] GetDatabaseValues(List<SQLData> dataTypes, List<KeyValuePair<string, string>> xmlDataList, List<string> columnNames)
            {
                // Combines the selected column values from the XML data list into an array

                XML.XMLOperations xmlOperations = new XML.XMLOperations();

                string[,] databaseValues;

                if (columnNames.Count > 0)
                {
                    List<string> valuesFromXMLFile = xmlOperations.GetColumnValuesList(xmlDataList, columnNames[0]);

                    databaseValues = new string[valuesFromXMLFile.Count, columnNames.Count];

                    for (int i = 0; i < columnNames.Count; i++)
                    {              
                        
                        if(i > 0)
                        {
                            valuesFromXMLFile = xmlOperations.GetColumnValuesList(xmlDataList, columnNames[i]);
                        }

                        for (int j = 0; j < valuesFromXMLFile.Count; j++)
                        {

                            databaseValues[j, i] = valuesFromXMLFile[j];

                        }

                    }

                }
                else
                {
                    databaseValues = new string[0, 0];
                }

                return databaseValues;

            }
            private void UseDtabase(string databaseName, SQLAccess sqlAccess)
            {
                // Open the database to add the table
                intCallingNum = 0; // Use Database

                string strUse = "USE " + databaseName + ";";

                ExecuteSQLCommand(strUse, sqlAccess);
            }

        }

    }

}


/*** REFERENCE ***/
/*
 * Backtick (`)
table & column ───────┬─────┬──┬──┬──┬────┬──┬────┬──┬────┬──┬───────┐
                      ↓     ↓  ↓  ↓  ↓    ↓  ↓    ↓  ↓    ↓  ↓       ↓
$query = "INSERT INTO `table` (`id`, `col1`, `col2`, `date`, `updated`) 
                       VALUES (NULL, 'val1', 'val2', '2001-01-01', NOW())";
                               ↑↑↑↑  ↑    ↑  ↑    ↑  ↑          ↑  ↑↑↑↑↑ 
Unquoted keyword          ─────┴┴┴┘  │    │  │    │  │          │  │││││
Single-quoted (') strings ───────────┴────┴──┴────┘  │          │  │││││
Single-quoted (') DATE    ───────────────────────────┴──────────┘  │││││
Unquoted function         ─────────────────────────────────────────┴┴┴┴┘ 
*/