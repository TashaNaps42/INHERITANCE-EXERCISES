using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartphoneTest
    {
        Smartphone testPhone1;
        Smartphone testPhone2;
        [TestInitialize]
        public void buildPhones()
        {
            testPhone1 = new Smartphone(0, 8, 250, "iTesty1S");
            testPhone2 = new Smartphone(0, 12, 500, "iTesty2S");
        }

        [TestMethod]
        public void ExpectSmartphoneToHaveAddRamAndAddStorage()
        {
            testPhone1.AddRam(4);
            testPhone2.AddStorage(10);
            Assert.AreEqual(testPhone1.Ram, testPhone2.Ram, 0.001);
            Assert.AreEqual(testPhone2.Storage, 510, 0.001);
        }

        [TestMethod]
        public void ExpectSmarphoneToGainSelfies()
        {
            testPhone1.AddSelfie(1000);
            testPhone2.AddSelfie(100);
            Assert.AreEqual(testPhone2.TotalSelfies, 100, 0.001);
            Assert.AreEqual(testPhone1.TotalSelfies, 1000, 0.001);
        }

        [TestMethod]
        public void LookThisIsAboveMyKnowledgeIWantEfficientTestsHowDoITestIfSomethingIsReadOnly()
        {
            Assert.IsTrue(true);
        }
        
    }
}
