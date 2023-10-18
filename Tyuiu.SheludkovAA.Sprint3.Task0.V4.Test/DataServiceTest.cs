using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task0.V4.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 0;
            int end = 5;
            double wait = 14.943;
            double res = ds.GetMultiplySeries(start, end);
            Assert.AreEqual(wait, res);
        }
    }
}
