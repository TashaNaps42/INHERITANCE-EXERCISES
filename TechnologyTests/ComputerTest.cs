using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        Computer testComputer1;
        Computer testComputer2;
        [TestInitialize]
        public void BuildComputers()
        {
            testComputer1 = new Computer(16, 1000, "Tester1.0");
            testComputer2 = new Computer(8, 750, "Tester2.0");
        }

        [TestMethod]
        public void AllComputersAreMadeByApple()
        {
            Assert.AreEqual(Computer.Company, "Apple");
        }

        [TestMethod]
        public void ComputersCanAddRam()
        {
            testComputer1.AddRam(16);
            testComputer2.AddRam(8);
            Assert.AreEqual(testComputer1.Ram, 32, .001);
            Assert.AreEqual(testComputer2.Ram, 16, .001);
        }

        [TestMethod]
        public void ComputersCanAddStorage()
        {
            testComputer1.AddStorage(250);
            testComputer2.AddStorage(250);
            Assert.IsTrue(testComputer1.Storage.Equals(1250));
            Assert.IsTrue(testComputer2.Storage == 1000);
            Assert.IsFalse(testComputer1.Storage == testComputer2.Storage);
        }
    }
}
