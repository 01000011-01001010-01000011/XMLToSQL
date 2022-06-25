/* Created by Chris Clarke June 2022*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace XMLToSQL
{
    internal class XML
    {

        public class XMLOperations
        {
            public List<string> GetXMLKeys(string fileName)
            {
                List<string> xmlHeadKeys = new List<string>();

               // Debug.WriteLine("FILENAME: " + fileName);

                if (File.Exists(fileName))
                {

                    try
                    {

                        //Create the XmlDocument.
                        XmlDocument doc = new XmlDocument();

                        //Load the document with the last book node.
                        XmlTextReader reader = new XmlTextReader(fileName);


                        /*reader.WhitespaceHandling = WhitespaceHandling.None;
                        reader.MoveToContent();*/
                        reader.Read();
                        doc.Load(reader);

                        XmlNode firstNode = doc.DocumentElement;

                        XmlNode parentNode = firstNode.ChildNodes[0];

                        //Debug.WriteLine("PARENT: " + parentNode.Name);

                        XmlNode firstChildNode = parentNode.ChildNodes[0];

                        //Debug.WriteLine("FIRST CHILD: " + firstChildNode.Name);

                        XmlNodeList nodes = firstChildNode.ChildNodes;

                        foreach (XmlNode node in nodes)
                        {
                            xmlHeadKeys.Add(node.Name);
                        }

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);

                    }

                }

                return xmlHeadKeys;

            }

            public List<KeyValuePair<string, string>> GetXMLDataList(string fileName)
            {
                List<KeyValuePair<string, string>> xmlDataList = new List<KeyValuePair<string, string>>();

                if (File.Exists(fileName))
                {

                    try
                    {
                        // Row  0 = column names

                        XmlReader reader = XmlTextReader.Create(fileName);

                        XmlDocument xmlDocument = new XmlDocument();

                        xmlDocument.Load(reader);

                        XmlNode firstNode = xmlDocument.DocumentElement;

                        XmlNode parentNode = firstNode.ChildNodes[0];
                                               
                        XmlNode firstChildNode = parentNode.ChildNodes[0];

                        int headNodes = parentNode.ChildNodes.Count;

                        int subNodes = firstChildNode.ChildNodes.Count; 

                        foreach(XmlNode nodes in parentNode.ChildNodes)
                        {

                            foreach (XmlNode node in nodes)
                            {
                                string key = node.Name;

                                string value = node.InnerText.ToString();

                                xmlDataList.Add(new KeyValuePair<string, string>(key, value));
                            }
                        
                        }                     

                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }

                }

                return xmlDataList;
            }

            public List<string> GetColumnValuesList(List<KeyValuePair<string, string>> xmlDataList, string columnName)
            {
                // Returns a list of column values based on the specified column name 

                List<string> columnValuesList = new List<string>();

                var matches = from key in xmlDataList where key.Key == columnName select key.Value;

                foreach (var match in matches)
                {

                    columnValuesList.Add(match);

                }

                return columnValuesList;

            }

            /*

             List<string> list = doc.Root.Elements("id")
                                           .Select(element => element.Value)
                                           .ToList();

            List<CustomerClass.Customer> currentCustomerList = new List<CustomerClass.Customer>();

            //XmlReader reader = XmlReader.Create(strFileName);
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(strFileName);

            foreach (XmlNode node in xmlDocument.GetElementsByTagName("Customer"))
            {
                customer = new Customer();

                customer.CustomerNumber = node.ChildNodes.Item(0).InnerText;
                customer.CustomerName = node.ChildNodes.Item(1).InnerText;
                customer.AddressLine1 = node.ChildNodes.Item(2).InnerText;
                customer.AddressLine2 = node.ChildNodes.Item(3).InnerText;
                customer.City = node.ChildNodes.Item(4).InnerText;
                customer.Province = node.ChildNodes.Item(5).InnerText;
                customer.PostalCode = node.ChildNodes.Item(6).InnerText;
                customer.Phone = node.ChildNodes.Item(7).InnerText;
                customer.Fax = node.ChildNodes.Item(8).InnerText;
                customer.Email = node.ChildNodes.Item(9).InnerText;
                
                currentCustomerList.Add(customer);

            }

            return currentCustomerList;*/




        }
    }

}
            
            /*
 * 
        public LinkedList<Customers.CustomerAccount> LoadCustomerDatabase()
        {
            //Loads the customers from the file into the array list       

            Customers newCustomerAccountClass = new Customers();

            FileIOClass newFileIO = new FileIOClass();

            LinkedList<Customers.CustomerAccount> newCustomerList = new LinkedList<Customers.CustomerAccount>();
                        
            string strCustomerDatabaseFilePath = newFileIO.GetCustomerDatabaseFile();

            /* if (File.Exists(strCustomerDatabaseFilePath))
             {

                 try
                 {

                     DocumentBuilderFactory docBuildFact = DocumentBuilderFactory.newInstance();

                     DocumentBuilder docBuilder = docBuildFact.newDocumentBuilder();

                     org.w3c.dom.Document doc = docBuilder.parse(strCustomerDatabaseFilePath);

                     doc.getDocumentElement().normalize();

                     NodeList nodeList = doc.getElementsByTagName("CustomerAccount");

                     int intNodeLength = nodeList.getLength();

                     for (int i = 0; i < nodeList.getLength(); i++)
                     {

                         customer = customerClass.new CustomerAccountDetails();

                         Node currentNode = nodeList.item(i);

                         if (currentNode.getNodeType() == Node.ELEMENT_NODE)
                         {

                             org.w3c.dom.Element element = (org.w3c.dom.Element)currentNode;

                             customer.CustomerAccountNumber = element.getElementsByTagName("AccountNumber").item(0).getTextContent();
                             customer.CustomerName = element.getElementsByTagName("CustomerName").item(0).getTextContent();
                             /* customer.CustomerAddressLine1 = element.getElementsByTagName("AddressLine1").item(0).getTextContent();
                              customer.CustomerAddressLine2 = element.getElementsByTagName("AddressLine2").item(0).getTextContent();
                              customer.CustomerCity = element.getElementsByTagName("City").item(0).getTextContent();
                              customer.CustomerProvince = element.getElementsByTagName("Province").item(0).getTextContent();
                              customer.CustomerPostalCode = element.getElementsByTagName("PostalCode").item(0).getTextContent();
                              customer.CustomerAttention = element.getElementsByTagName("Attention").item(0).getTextContent();
                              customer.CustomerPhone = element.getElementsByTagName("Phone").item(0).getTextContent();
                              customer.CustomerFax = element.getElementsByTagName("Fax").item(0).getTextContent();
                              customer.CustomerEmail = element.getElementsByTagName("Email").item(0).getTextContent();

                             newCustomerList.add(customer);

                         }

                     }

                 }
                 catch (Exception ex)
                 {

                     ex.printStackTrace();

                 }

             }
             else
             {

                 newCustomerList = null;


             }

return newCustomerList;


            /* XmlDataDocument xmldoc = new XmlDataDocument();
                    XmlNodeList xmlnode ;
                    int i = 0;
                    string str = null;
                    FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Product");
                    for (i = 0; i <= xmlnode.Count - 1; i++)
                    {
                        xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                        str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                        MessageBox.Show (str);

        }

        public List<CustomerAccount> LoadCustomersIntoList()
{
    //Loads the customers into the customer list

    FileIOClass newFileIO = new FileIOClass();

    string strCustomerDatabaseFile = newFileIO.GetCustomerDatabaseFile();  // Get the path to the file

    Customers.CustomerAccount newCustomer;

    //Clear the customer list 
    if (lstCustomerAccountsList.Count > 0)
    {

        lstCustomerAccountsList.Clear();

    }

    XmlDocument newXMLDocument = new XmlDocument();

    newXMLDocument.Load(strCustomerDatabaseFile);

    XmlNodeList accountList = newXMLDocument.GetElementsByTagName("AccountNumber");
    XmlNodeList nameList = newXMLDocument.GetElementsByTagName("CustomerName");

    for (int i = 0; i < accountList.Count; i++)
    {
        newCustomer = new CustomerAccount();

        newCustomer.accountNumber = accountList[i].InnerText;
        newCustomer.accountName = nameList[i].InnerText;

        lstCustomerAccountsList.Add(newCustomer);

    }

    goodCustomerFile = true;

    return lstCustomerAccountsList;

    /* XmlTextReader reader = new XmlTextReader(strCustomerDatabaseFile);

    while (reader.Read())
     {
         switch (reader.NodeType)
         {
             case XmlNodeType.Element: // The node is an element.

                 //Console.Write("<" + reader.Name);
                 //Console.WriteLine(">");
                 break;
             case XmlNodeType.Text: //Display the text in each element.
                 //Console.WriteLine(reader.Value);
                 break;
             case XmlNodeType.EndElement: //Display the end of the element.
                 //Console.Write("</" + reader.Name);
                 //Console.WriteLine(">");
                 break;
         }

     }*/

/*strCustomerDatabaseFile = File.ReadAllText(strCustomerDatabaseFile);

strCustomerDatabaseFile = strCustomerDatabaseFile.Replace('\n', '\r'); //Replace the new line character

//Get the number of lines in the file
string[] linesInFile = strCustomerDatabaseFile.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

numRows = linesInFile.Length; //Rows in the file
numColumns = linesInFile[0].Split(',').Length; // Columns per line

for (int i = 0; i < numRows; i++)
{

    var customer = new Customer.CustomerAccount();

    string[] line = linesInFile[i].Split(',');

    customer.accountNumber = line[0];
    customer.accountName = line[1];
    /*customer.accountAddressLine1 = line[2];
    customer.accountAddressLine2 = line[3];
    customer.accountCity = line[4];
    customer.accountProvince = line[5];
    customer.accountPostal = line[6];
    customer.accountCountry = line[7];
    customer.accountAttention = line[8];
    customer.accountPhone = line[9];
    customer.accountFax = line[10];
    customer.accountEmail = line[11];


}*/

