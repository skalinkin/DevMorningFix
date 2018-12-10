using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Avtec.DevMorningFix.DataManager
{
    public class XmlManager : IDataManager
    {
        public string GetFundamentalName(string ID)
        {
            string name = "ain't got no name";
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                string xmlId = item.Attribute("ID").Value;
                if (xmlId == ID)
                {
                    name = item.Attribute("Name").Value;
                    break;
                }
            }
            return name;
        }
        public string GetFundamentalDescription(string ID)
        {
            string description = "ain't got no description";
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                string xmlId = item.Attribute("ID").Value;
                if (xmlId == ID)
                {
                    description = item.Attribute("Description").Value;
                    break;
                }
            }
            return description;
        }
        public IEnumerable<IDevFixFundamental> GetFundamentalsList()
        {
            List<IDevFixFundamental> fundamentals = new List<IDevFixFundamental>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\SimpleDataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                DevFixFundamental dff = new DevFixFundamental();
                dff.ID = item.Attribute("ID").Value;
                dff.Name = item.Attribute("Name").Value;
                dff.Description = item.Attribute("Description").Value;
                fundamentals.Add(dff);
            }
            return fundamentals;
        }
    }
}
