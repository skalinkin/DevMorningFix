using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.DataManager;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMorningFixUnitTest
{
    [TestFixture]
    public class FundamentalsTests
    {
        // One
        [Test]
        public void Fundamental1_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "1";
            IDataManager dataManager = new XmlManager();
            var fundamental = new Fundamental1();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = "this class cannot be tested";
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental1_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "1";
            IDataManager dataManager = new XmlManager();
            var fundamental = new Fundamental1();
            string fromM = dataManager.GetFundamentalDescription(ID);
            // Act
            string fromF = "this class cannot be tested";
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        // two
        [Test]
        public void Fundamental2_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "2";
            IDataManager dataManager = new XmlManager();
            var fundamental = new FundamentalTwo(); // this is not how its actually created
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental2_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "2";
            IDataManager dataManager = new XmlManager();
            var fundamental = new FundamentalTwo();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // three
        [Test]
        public void Fundamental3_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "3";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalThree();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental3_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "3";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalThree();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // four



        // Five
        [Test]
        public void Fundamental5_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "5";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new DevFixFundamental(ID, dataManager);
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental5_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "5";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new DevFixFundamental(ID, dataManager);
            string fromM = dataManager.GetFundamentalDescription(ID);
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
            string ID = "6";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalSix();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        [Test]
        public void Fundamental6_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "6";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalSix();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // seven
        [Test]
        public void Fundamental7_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "7";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalSeven();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = "the class contains no name property";   // fundamental.Name;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        [Test]
        public void Fundamental7_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "7";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalSeven();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // eight
        [Test]
        public void Fundamental8_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "8";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalEight();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = fundamental.Name;
            //Assert
            StringAssert.AreEqualIgnoringCase(fromM, fromF);
        }
        [Test]
        public void Fundamental8_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "8";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalEight();
            string fromM = dataManager.GetFundamentalDescription(ID);
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
            string ID = "9";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalNine();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = "the class contains no name property";   // fundamental.Name;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        [Test]
        public void Fundamental9_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "9";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalNine();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // ten
        [Test]
        public void Fundamental10_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "10";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalTen();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = "the class contains no name property";   // fundamental.Name;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        [Test]
        public void Fundamental10_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "10";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalTen();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        // eleven
        [Test]
        public void Fundamental11_GetName_ReturnsCorrectNameValue()
        {
            //Arange
            string ID = "11";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalEleven();
            string fromM = dataManager.GetFundamentalName(ID);
            // Act
            string fromF = "the class contains no name property";   // fundamental.Name;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
        [Test]
        public void Fundamental11_GetDescription_ReturnsCorrectDescriptionValue()
        {
            //Arange
            string ID = "11";
            IDataManager dataManager =  new XmlManager();
            var fundamental = new FundamentalEleven();
            string fromMLong = dataManager.GetFundamentalDescription(ID);
            string fromM = fromMLong.Substring(0, 10);
            // Act
            string fromF = fundamental.Description;
            //Assert
            StringAssert.Contains(fromM, fromF);
        }
    }
}
