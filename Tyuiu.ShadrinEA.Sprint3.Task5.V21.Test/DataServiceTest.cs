using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint3.Task5.V21.Lib;

namespace Tyuiu.ShadrinEA.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int stop1 = 3;
            int stop2 = 10;
            double res = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);
            double wait = 25.981;
            Assert.AreEqual(wait, res);
        }
    }
}
