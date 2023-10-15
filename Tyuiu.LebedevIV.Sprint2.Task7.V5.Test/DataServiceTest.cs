using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint2.Task7.V5.Lib;

namespace Tyuiu.LebedevIV.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            double k = 0.5;
            double d = 0.5;
            bool res = ds.CheckDotInShadedArea(k, d);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
