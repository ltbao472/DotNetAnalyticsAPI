﻿using Analytics.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Analytics.Data
{
    public class DataItem
    {
        string name = "";
        private static XDocument _document = null;
        public static XDocument Document
        {
            set { _document = value; }
            get 
            {
                if (_document == null)
                {
                    _document = XDocument.Parse(DataResource.DataItems);
                }
                return _document;
            }
        }
        public DataItem(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return GetResource("Name"); }
        }

        public string Category
        {
            get { return GetResourceCategory(name, "Name"); }
        }

        public string APICommand
        {
            get { return GetResource("APICommand"); }
        }

        public string WebViewName
        {
            get { return GetResource("WebViewName"); }
        }

        public string AppViewName
        {
            get { return GetResource("AppViewName"); }
        }

        public string DataType
        {
            get { return GetResource("DataType"); }
        }

        public Type Type
        {
            get
            {
                
                switch (DataType)
                {
                    case "STRING":
                        return typeof(string);
                    case "DATE":
                    case "DATETIME":
                        return typeof(DateTime);
                    case "INTEGER":
                        return typeof(int);
                    case "TIME":
                    case "PERCENT":
                    case "FLOAT":
                    case "CURRENCY":
                        return typeof(decimal);
                    
                }
                return typeof(string);
            }
        }

        public string AllowedInSegments
        {
            get { return GetResource("AllowedInSegments"); }
        }

        public string Description
        {
            get { return GetResource("description"); }
        }

        public ItemType ItemType
        {
            get { return (ItemType)Convert.ToInt32(GetResourceItemType(name, "Value")); }
        }

        public string GetResource(string attribute)
        {
            return GetResource(name,attribute);
        }
        public string GetResource(string name,string attribute)
        {
            string result = "";
            var element = (from x in Document.Descendants("DataItem") where x.Attribute("Name").Value == name select x).FirstOrDefault();
            if (element != null && attribute != "description")
                result = element.Attributes(attribute).Select(t => t.Value).FirstOrDefault();
            else if (attribute == "description")
                result = element.Value;
            return result;
        }

        public string GetResourceCategory(string name, string attribute)
        {
            string result = "";
            var element = (from x in Document.Descendants("DataItem") where x.Attribute("Name").Value == name select x).FirstOrDefault();
            if (element != null)
                result = element.Parent.Parent.Attributes(attribute).Select(t => t.Value).FirstOrDefault();
            return result;
        }

        public string GetResourceItemType(string name, string attribute)
        {
            string result = "";
            var element = (from x in Document.Descendants("DataItem") where x.Attribute("Name").Value == name select x).FirstOrDefault();
            if (element != null)
                result = element.Parent.Attributes(attribute).Select(t => t.Value).FirstOrDefault();
            return result;
        }

        public static DataItem GetDataItemByAPICommand(string command)
        {
            return new Data.DataItem(command.Replace("ga:", ""));
        }

        public static string GetString(List<Data.DataItem> list)
        {
            string result = "";
            if (list == null) return result;
            foreach (DataItem item in list)
            {
                result += item.APICommand + ",";
            }
            if (!string.IsNullOrEmpty(result))
                result = result.Remove(result.Length - 1, 1);
            return result;

        }

        public static string GetString(List<Data.DataItem> list,string specialChar)
        {
            string result = "";
            if (list == null) return result;
            foreach (DataItem item in list)
            {
                result += specialChar + item.APICommand + ",";
            }
            if (!string.IsNullOrEmpty(result))
                result = result.Remove(result.Length - 1, 1);
            return result;

        }
    }
}