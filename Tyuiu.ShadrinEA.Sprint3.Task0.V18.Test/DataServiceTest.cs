﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint3.Task0.V18.Lib;

namespace Tyuiu.ShadrinEA.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {  
        [TestMethod]
        public void TestMethod1()
        {
        DataService ds = new DataService();

        int value   = 1 ;
        int startValue =1;
        int stopValue = 6;

        double res = ds.GetMultiplySeries(value, startValue, stopValue);

        double wait = 0.001;

        Assert.AreEqual(wait, res);

        }
    }
}
