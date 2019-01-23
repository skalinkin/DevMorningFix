using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace Avtec.DevMorningFix.TempSpot.DataManager
{
    public class XmlManager : IDataManager
    {
        public string GetFundamentalName(string ID)
        {
            var name = "ain't got no name";
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
            {
                var xmlId = item.Attribute("ID").Value;
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
            var description = "ain't got no description";
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
            {
                var xmlId = item.Attribute("ID").Value;
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
            var fundamentals = new List<IDevFixFundamental>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
            {
                var dff = new DevFixFundamental();
                var id = item.Attribute("ID").Value;
                string id1 = item.Attribute("ID").Value;
                dff.ID = id1;
                dff.Name = GetFundamentalName(id1);
                dff.Description = GetFundamentalDescription(id1);
                dff.Name = item.Attribute("Name").Value;
                dff.Description = item.Attribute("Description").Value;
                fundamentals.Add(dff);
            }

            return fundamentals;
        }

        public IEnumerable<string> GetFundamentalNames()
        {
            var names = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
            {
                names.Add(item.Attribute("Name").Value);
            }

            return names;
        }

        public IEnumerable<string> GetFundamentalIDs()
        {
            var IDs = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
            {
                IDs.Add(item.Attribute("ID").Value);
            }

            return IDs;
        }

        public IEnumerable<string> GetFundamentalDescriptions()
        {
            var Descriptions = new List<string>();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fn = dir + "\\TempSpot\\DataStore\\SimpleData.xml";
            var doc = XDocument.Load(fn);
            var data = doc.Element("DevMorningFixFundamentals").Elements("fundamental");
            foreach (var item in data)
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