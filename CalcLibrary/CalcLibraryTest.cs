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
            double rad = Calc.RadQ(625);
            Assert.AreEqual(25, rad);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double rad = Calc.RadQ(-12);
            Assert.AreEqual(double.NaN, rad);
       
        }
        [TestMethod]
        public void TestMethod3()
        {
            double rad = Calc.RadQ(8);
            Assert.AreEqual(2.8284271247461903, rad );
        }
        [TestMethod]
        public void TestMethod4()
        {
            double rad = Calc.RadQ(-9);
            Assert.AreEqual(double.NaN, rad);


        }
        [DataTestMethod]
        [DataRow(81,9)]
        [DataRow(64, 8)]
        [DataRow(10404,102)]
        [DataRow(2500, 50)]
        [DataRow(144, 12)]
        public void RadiceData(double num,double aspettato)
        {
            double risultato = Calc.RadQ(num);
            Assert.AreEqual(aspettato, risultato);


        }
    }
}
