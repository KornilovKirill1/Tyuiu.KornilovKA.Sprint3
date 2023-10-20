using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint3.Task2.V6.Lib;

namespace Tyuiu.KornilovKA.Sprint3.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double value = 0.25;

            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.567;

            Assert.AreEqual(wait, res);
        }
    }
}
