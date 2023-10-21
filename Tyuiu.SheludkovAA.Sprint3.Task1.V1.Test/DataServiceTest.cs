using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task1.V1.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int st = 1;
            int end = 7;
            double wait = 5.311;
            double res = ds.GetMultiplySeries(st, end);
            Assert.AreEqual(wait, res);
        }
    }
}
