﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = -5;
            int e = 5;
            int len = e - s + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -27.22;
            valueWaitArray[1] = -22.25;
            valueWaitArray[2] = -16.66;
            valueWaitArray[3] = -11.04;
            valueWaitArray[4] = -6.13;
            valueWaitArray[5] = -3;
            valueWaitArray[6] = 4.84;
            valueWaitArray[7] = 8.86;
            valueWaitArray[8] = 14.43;
            valueWaitArray[9] = 20.18;
            valueWaitArray[10] = 25.24;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(s, e);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
