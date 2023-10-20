using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KornilovKA.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                result *= Math.Pow(value, i) + (1.0 / (i + 1));
            }

            return Math.Round(result, 3);
        }
    }
}
