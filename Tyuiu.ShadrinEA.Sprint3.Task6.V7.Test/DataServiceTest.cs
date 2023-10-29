using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint3.Task6.V7.Lib;

namespace Tyuiu.ShadrinEA.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 17;
            int stop = 26;
            int res = ds.GetSumTheDivisors(start, stop);
            int wait = 344;
            Assert.AreEqual(wait, res);
        }
    }
}
