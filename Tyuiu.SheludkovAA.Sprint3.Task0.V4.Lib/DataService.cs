using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SheludkovAA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double proiz = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                proiz = proiz * (Math.Sin(0.1) + i);
            }
            return Math.Round(proiz,3);
        }
    }
}
