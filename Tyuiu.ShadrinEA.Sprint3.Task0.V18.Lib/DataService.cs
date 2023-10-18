using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShadrinEA.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;

            for (i = startValue; i <= stopValue; i++) ;
            {
                sumSeries = sumSeries + (Math.Pow((2 / (Math.Cos(value) + 5.0)), i));

            }
            return Math.Round(sumSeries, 3);
        }
    }
}
