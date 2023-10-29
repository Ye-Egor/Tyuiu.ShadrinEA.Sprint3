﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShadrinEA.Sprint3.Task6.V7.Lib
{
    public class DataService : ISprint3Task6V7
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sm = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sm += d;   
                    }
                }
            }
            return sm;
        }
    }
}
