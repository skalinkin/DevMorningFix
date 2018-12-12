using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;

namespace Avtec.DevMorningFix.ServiceTier.DataManager
{
    public class XmlManager : IDataManager
    {
        public string GetFundamentalName(string ID)
        {
            string name = "ain't got no name";
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
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
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
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
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                DevFixFundamental dff = new DevFixFundamental(this);
                string id = item.Attribute("ID").Value;
                dff.Initialize(item.Attribute("ID").Value);
                dff.Name = item.Attribute("Name").Value;
                dff.Description = item.Attribute("Description").Value;
                fundamentals.Add(dff);
            }
            return fundamentals;
        }
        public IEnumerable<string> GetFundamentalNames()
        {
            List<string> names = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                names.Add(item.Attribute("Name").Value);
            }
            return names;
        }
        public IEnumerable<string> GetFundamentalIDs()
        {
            List<string> IDs = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                IDs.Add(item.Attribute("ID").Value);
            }
            return IDs;
        }

        public IEnumerable<string> GetFundamentalDescriptions()
        {
            List<string> Descriptions = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fn = dir + "\\ServiceTier\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (XElement item in data)
            {
                Descriptions.Add(item.Attribute("Description").Value);
            }
            return Descriptions;
        }

        public IDevFixFundamental GetDevFixFundamental(string Name)
        {
            // get from data
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }

        public IDevFixFundamental GetDevFixFundamental(int ID)
        {
            // get from data
            IDevFixFundamental f = new DevFixFundamental();
            return f;
        }
        public bool DeleteFundamental(string Name)
        {
            // get from data
            return true;
        }

        public bool CreateFundamental(int ID, string Name, string Description)
        {
            // get from data
            return true;
        }

        public bool ModifyFundamental(int ID, string Name, string Description)
        {
            // get from data
            return true;
        }

    }
}
