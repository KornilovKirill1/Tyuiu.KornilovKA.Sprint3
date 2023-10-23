using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint3.Task4.V3.Lib;

namespace Tyuiu.KornilovKA.Sprint3.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            var res = ds.Calculate(startValue, stopValue);
            double wait = 1.067;

            Assert.AreEqual(wait, res);
        }
    }
}
