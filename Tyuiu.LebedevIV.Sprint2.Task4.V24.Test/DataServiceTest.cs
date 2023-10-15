using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint2.Task4.V24.Lib;

namespace Tyuiu.LebedevIV.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1.495;

            Assert.AreEqual(wait, res);
        }
    }
}
