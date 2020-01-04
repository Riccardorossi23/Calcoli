using Calcoli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary
{
    [TestClass]
    public class CalcLibraryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double rad = Calc.RadQ(12);
            Assert.AreEqual(rad, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double rad = Calc.RadQ(-7);
            Assert.AreEqual(rad, double.NaN);
       
        }
        public void TestMethod3()
        {
            double rad = Calc.RadQ(8);
            Assert.AreEqual(rad, 2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double rad = Calc.RadQ(-9);
            Assert.AreEqual(rad, double.NaN);


        }
    }
}
