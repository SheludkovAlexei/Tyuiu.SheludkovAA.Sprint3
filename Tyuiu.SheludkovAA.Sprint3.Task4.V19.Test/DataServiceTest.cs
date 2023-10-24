using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task4.V19.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x1 = -5;
            int x2 = 5;
            double wait = 9.432;
            double res = ds.Calculate(x1, x2);
            Assert.AreEqual(wait, res);
        }
    }
}
