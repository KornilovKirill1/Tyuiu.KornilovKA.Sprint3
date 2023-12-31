﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KornilovKA.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;

            while (startValue <= stopValue)
            {
                res += Math.Pow(1.0 / (Math.Cos(startValue) + Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
