using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using NUnit.Framework;

namespace FundamentalsUnitTest
{
    [TestFixture]
    public class FundamentalsTests
    {
        // One
        [Test]
        public void Fundamental1_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "1";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental1_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "1";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // two
        [Test]
        public void Fundamental2_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "2";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental2_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "2";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // three
        [Test]
        public void Fundamental3_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "3";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental3_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "3";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // four



        // Five
        [Test]
        public void Fundamental5_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "5";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental5_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "5";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // six
        [Test]
        public void Fundamental6_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "6";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental6_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "6";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // seven
        [Test]
        public void Fundamental7_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "7";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental7_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "7";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // eight
        [Test]
        public void Fundamental8_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "8";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental8_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "8";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // nine
        [Test]
        public void Fundamental9_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "9";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental9_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "9";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // ten
        [Test]
        public void Fundamental10_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "10";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental10_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "10";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // eleven
        [Test]
        public void Fundamental11_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string id = "11";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalName(id);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental11_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string id = "11";
            IDataManager dataManager = new XmlManager();
            var fundamental = new DevFixFundamental(dataManager);
            fundamental.Initialize(id);
            string fromM = dataManager.GetFundamentalDescription(id);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
    }
}
