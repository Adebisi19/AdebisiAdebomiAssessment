using System;
using System.Linq;
using System.Data;
using System.Xml;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common.Utilities
{
    class GetDataFromXML
    {
        public string xmlParser(string xmlPath, string searchField, string returnField, string search)
        {

            XmlReader xmlFile;
            XmlTextReader xmlReader = new XmlTextReader(xmlPath);

            xmlFile = XmlReader.Create(xmlPath, new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlReader);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Page_Name";
            int index = dv.Find(search);

            if (index == -1)
            {
                return null;
            }
            else
            {
                return dv[index]["Page_URL"].ToString();

            }


        }
    }
}
