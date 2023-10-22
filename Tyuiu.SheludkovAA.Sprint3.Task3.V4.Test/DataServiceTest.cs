using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task3.V4.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char c = 'j';
            string wait = "plk  dw cv kl";
            string res = ds.DeleteCharInString(str, c);
            Assert.AreEqual(wait, res);

        }
    }
}
