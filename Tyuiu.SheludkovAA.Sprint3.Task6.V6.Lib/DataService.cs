using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SheludkovAA.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int d;
            int x;
            int c1 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (d=1; d<=x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 10)
                        {
                            c1++;
                        }
                    }
                }
            }
            return c1;
        }
    }
}
