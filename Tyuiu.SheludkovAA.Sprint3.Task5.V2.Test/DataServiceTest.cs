using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task5.V2.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int s1 = 1;
            int e1 = 3;
            int s2 = 1;
            int e2 = 12;
            double wait = 35.658;
            double res = ds.GetSumSumSeries(x, s1, s2, e1, e2);
            Assert.AreEqual(wait, res);
        }
    }
}
