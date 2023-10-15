using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.LebedevIV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 2000;
            int d = 1;
            string res = ds.FindMonthName(k, d);
            string wait = "февраль";
            Assert.AreEqual(wait, res);
        }
    }
}
