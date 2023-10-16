using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint3.Task0.V12.Lib;

namespace Tyuiu.KornilovKA.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 2;
            double value = 1;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
