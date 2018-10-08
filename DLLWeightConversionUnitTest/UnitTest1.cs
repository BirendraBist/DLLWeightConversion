using DLLWeightConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DLLWeightConversionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Class1 c1= new Class1();
        
        [TestMethod]
        public void ConvertToGramTestMethod()

        {
            double ut = c1.ConvertToGrams(2);
            Assert.AreEqual(56.69904, ut, 0.001);
        }
        [TestMethod]
        public void ConvertToOuncesTestMethod()
        {
            double ut = c1.ConvertToOunces(1);
            Assert.AreEqual(0.035, ut, 0.001);
        }
    }
}
