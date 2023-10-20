using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KornilovKA.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                res *= (Math.Pow(value, startValue) + 1.0) * Math.Cos(4);
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(res, 3);
        }
    }
}
