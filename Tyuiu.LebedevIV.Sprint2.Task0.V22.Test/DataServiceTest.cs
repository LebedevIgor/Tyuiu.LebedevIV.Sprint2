using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint2.Task0.V22.Lib;

namespace Tyuiu.LebedevIV.Sprint2.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3105, y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
