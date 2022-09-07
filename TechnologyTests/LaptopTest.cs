using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTest
    {
        Laptop testTop1;
        Laptop testTop2;

        [TestInitialize]
        public void buildLaptops()
        {
            testTop1 = new Laptop(4.0, 8, 750, "Lappy1.0");
            testTop2 = new Laptop(5.1, 16, 1250, "Lappy2.0");
        }
        [TestMethod]
        public void LaptopsInheritAddRamAndAddStorage()
        {
            testTop1.AddRam(8);
            testTop2.AddStorage(250);
            Assert.AreEqual(testTop1.Ram, 16, .001);
            Assert.AreEqual(testTop2.Storage, 1500, .001);
        }

        [TestMethod]
        public void TooHeavy_ExpectLaptopOverWeightLimitToReturnTrue()
        {
            Assert.IsTrue(testTop2.tooHeavy());
        }

        [TestMethod]
        public void TooHeavy_ExpectLaptopUnder5ToReturnFalse()
        {
            Assert.IsFalse(testTop1.tooHeavy());
        }
    }
}
