using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Connection_db
{
    public class ConnectionInfor
    {
        private string _Server;
        private string _Database;
        private string _Username;
        private string _Password;
        private string _SerialKey = "";
        private Boolean _newconn = false;
        private Class_Public class_pub = new Class_Public();
        public Boolean Newconn
        {
            get { return _newconn; }
            set { _newconn = value; }
        }
        public string Server
        {
            get { return _Server; }
            set { _Server = value; }
        }
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string Pasword
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string SerialKey
        {
            get { return _SerialKey; }
            set { _SerialKey = value; }
        }
        public ConnectionInfor()
        {
            _Server = "";
            _Database = "";
            _Username = "";
            _Password = "";

        }
        public void Save_Connect()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlNodelist = default(XmlNodeList);
            string strPath = null;
            strPath = Application.StartupPath;
            if (strPath.Length > 4)
            {
                int i = strPath.IndexOf("\\bin");
                if (i > 0)
                {
                    strPath = strPath.Substring(0, i);
                }
                strPath = strPath + "\\" + "Connection.xml";
                xmldoc.Load(strPath);
                xmlNodelist = xmldoc.GetElementsByTagName("add");
                foreach (XmlNode xmlNode in xmlNodelist)
                {
                    if (xmlNode.Attributes["key"].Value == "Code")
                    {                      
                            xmlNode.Attributes["value"].Value = "1";
                                            }
                    if (xmlNode.Attributes["key"].Value == "Server")
                    {
                        xmlNode.Attributes["value"].Value =class_pub.EncryptToBase64String(_Server,"12345678");
                    }
                    if (xmlNode.Attributes["key"].Value == "Database")
                    {
                        xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(_Database, "12345678"); 
                    }
                    if (xmlNode.Attributes["key"].Value == "Username")
                    {
                        xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(_Username, "12345678"); 
                    }
                    if (xmlNode.Attributes["key"].Value == "Password")
                    {
                        xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(_Password, "12345678"); 
                    }
                    if (xmlNode.Attributes["key"].Value == "SerialKey")
                    {
                        xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(_SerialKey, "12345678"); 
                    }
                }

                xmldoc.Save(strPath);

            }
        }
        public void Encrypt()
        {
            XmlDocument xmldoc = new XmlDocument();
            //XmlNode xmlNode = default(XmlNode);
            //XmlNode xmlParentNode = default(XmlNode);
            XmlNodeList xmlNodelist = default(XmlNodeList);
            bool blnMahoa = false;
            string strPath = null;
            strPath = Application.StartupPath;
            if (strPath.Length > 4)
            {
                int i = strPath.IndexOf("\\bin");
                if (i > 0)
                {
                    strPath = strPath.Substring(0, i);
                }
                strPath = strPath + "\\" + "Connection.xml";
                xmldoc.Load(strPath);
                xmlNodelist = xmldoc.GetElementsByTagName("add");
                foreach (XmlNode xmlNode in xmlNodelist)
                {
                    if (xmlNode.Attributes["key"].Value == "Code")
                    {
                        if (xmlNode.Attributes["value"].Value == "0")
                        {
                            xmlNode.Attributes["value"].Value = "1";
                            blnMahoa = true;
                        }
                    }
                    if (blnMahoa)
                    {
                        if (xmlNode.Attributes["key"].Value == "Server")
                        {
                            xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(xmlNode.Attributes["value"].Value, "12345678");

                        }
                        if (xmlNode.Attributes["key"].Value == "Database")
                        {

                            xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(xmlNode.Attributes["value"].Value, "12345678");

                        }
                        if (xmlNode.Attributes["key"].Value == "Username")
                        {

                            xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(xmlNode.Attributes["value"].Value, "12345678");

                        }
                        if (xmlNode.Attributes["key"].Value == "Password")
                        {

                            xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(xmlNode.Attributes["value"].Value, "12345678");

                        }
                        if (xmlNode.Attributes["key"].Value == "SerialKey")
                        {

                            xmlNode.Attributes["value"].Value = class_pub.EncryptToBase64String(xmlNode.Attributes["SerialKey"].Value, "12345678");

                        }

                    }
                    if (blnMahoa == true)
                    {
                        xmldoc.Save(strPath);
                    }
                }
            }
        }

        public void CnnGet()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlNodelist = default(XmlNodeList);
            string strPath = null;
            strPath = Application.StartupPath;
            if (strPath.Length > 4)
            {
                int i = strPath.IndexOf("\\bin");
                if (i > 0)
                {
                    strPath = strPath.Substring(0, i);
                }
                strPath = strPath + "\\" + "Connection.xml";
                xmldoc.Load(strPath);
                xmlNodelist = xmldoc.GetElementsByTagName("add");
                foreach (XmlNode xmlNode in xmlNodelist)
                {

                    if (xmlNode.Attributes["key"].Value == "Server")
                    {
                        _Server = class_pub.DecryptFromBase64String(xmlNode.Attributes["value"].Value, "12345678");
                    }
                    if (xmlNode.Attributes["key"].Value == "Database")
                    {
                        _Database = class_pub.DecryptFromBase64String(xmlNode.Attributes["value"].Value, "12345678");
                    }
                    if (xmlNode.Attributes["key"].Value == "Username")
                    {
                        _Username = class_pub.DecryptFromBase64String(xmlNode.Attributes["value"].Value, "12345678");
                    }
                    if (xmlNode.Attributes["key"].Value == "Password")
                    {
                        _Password = class_pub.DecryptFromBase64String(xmlNode.Attributes["value"].Value, "12345678");
                    }
                    if (xmlNode.Attributes["key"].Value == "SerialKey")
                    {
                        _SerialKey = class_pub.DecryptFromBase64String(xmlNode.Attributes["value"].Value, "12345678");
                    }

                }
            }
        }

        public string strConnectionInfor()
        {
            CnnGet();
            return "SERVER=" + _Server + ";DATABASE=" + _Database + ";User Id=" + _Username + ";Password=" + _Password + ";Connect TimeOut=100";
        }


    }
}
