using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.LebedevIV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int k = 8;
            int d = 1;
            string res = ds.FindDayName(k, d);
            string wait = "Понедельник";
            Assert.AreEqual(wait, res);
        }
    }
}
