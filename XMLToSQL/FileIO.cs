/* Created by Chris Clarke June 2022*/

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XMLToSQL
{
    internal class FileIO
    {
        public class FileOperations
        {

            public bool CheckForSetupFolder()
            {
                // Checks to see if the program settings folder exists in the Documents folder

                string folderPath = GetFolderPath(); //Folder path

                return Directory.Exists(folderPath);

            }

            public bool CheckForSetupFile()
            {
                // Checks to see if the settings file exists

                string fileName = GetSetupFilePath(); // Folder path

                return File.Exists(fileName);

            }

            public bool CheckIfFileExists(string fileName)
            {
                // Checks if the selected file exists

                bool found = File.Exists(fileName);

                return found;

            }

            public bool CheckIfDatabaseExists(string strDatabaseName)
            {
                // Checks to see if the database already exists

                string path = "C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Data\\" + strDatabaseName + "\\";

                bool found = Directory.Exists(path);

                return found;

            }

            public void CreateSetupFolder()
            {
                // Creates the setup folder in the documents folder

                if (!CheckForSetupFolder())
                {

                    string folderPath = GetFolderPath();

                    Directory.CreateDirectory(folderPath);

                }

            }


            private string GetSetupFilePath()
            {
                // Returns the path to the setup file

                string folderPath = GetFolderPath(); // Folder path

                string fileName = "MySQL Setup File.txt";

                string filePath = Path.Combine(folderPath, fileName);

                return filePath; 

            }

            private string GetFolderPath()
            {
                // Returns the path to the program setup folder

                string folderName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderName += "\\XMLtoSQL";

                return folderName;

            }


            public string OpenXMLFile() {

                string fileName = "";

                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    fileName = openFileDialog.FileName;
                                    
                }

                return fileName;

            }

            public SQL.SQLAccess GetSetupFileData()
            {
                // Opens the setup file and loads the data into the SQL.sqlAccess object
                // Creates a new file if the file doesn't exist 
                bool boolFileExists = CheckForSetupFile();

                SQL.SQLAccess credentials = new SQL.SQLAccess();

                if (boolFileExists)
                {
                    string filePath = GetSetupFilePath();
                    List<string> data = new List<string>();

                    try
                    {

                        using(StreamReader reader = new StreamReader(filePath))
                        {

                            while(!reader.EndOfStream)
                            {

                                string value = reader.ReadLine();

                                data.Add(value);
                               
                            }

                        }
                                                                                              
                        if(data.Count > 0)
                        {
                            credentials.serverName = data[0];
                            credentials.portNumber = data[1];
                            credentials.userName = data[2];
                            credentials.password = data[3];

                        }

                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message);

                    }

                }
                else
                {
                    File.Create(GetSetupFilePath());

                    credentials.serverName = "";
                    credentials.portNumber = "";
                    credentials.userName = "";
                    credentials.password = "";

                }
                               
                return credentials;

            }

            public void SaveSetupFile(SQL.SQLAccess credentials)
            {
                // Saves the credentials to file

                string filePath = GetSetupFilePath();

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {

                        writer.WriteLine(credentials.serverName);
                        writer.WriteLine(credentials.portNumber);
                        writer.WriteLine(credentials.userName);
                        writer.WriteLine("");

                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
          
        }       

    }

}
