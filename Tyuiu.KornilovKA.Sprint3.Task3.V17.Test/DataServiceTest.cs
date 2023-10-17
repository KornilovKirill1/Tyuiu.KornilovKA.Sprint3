using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint3.Task3.V17.Lib;

namespace Tyuiu.KornilovKA.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string value = "*vn98n! b,";
            int wait = 98;

            var res = ds.ConvertStringToInt(value);
            Assert.AreEqual(wait, res);
        }
    }
}
