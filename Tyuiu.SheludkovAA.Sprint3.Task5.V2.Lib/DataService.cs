using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SheludkovAA.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i= startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j<=stopValue2; j++)
                {
                    res = res + ((Math.Cos(j) + x) / x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
