using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint3.Task5.V2.Lib;

namespace Tyuiu.SheludkovAA.Sprint3.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int s1 = 1;
            int e1 = 3;
            int s2 = 1;
            int e2 = 12;

            Console.Title = "Спринт #3 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* из ряда по формуле                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начальная точка первого цикла = " + s1);
            Console.WriteLine("Начальная точка второго цикла = " + s2);
            Console.WriteLine("Конечная точка первого цикла = " + e1);
            Console.WriteLine("Конечная точка второго цикла = " + e2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма равна : " + ds.GetSumSumSeries(x, s1, s2, e1, e2));
            Console.ReadKey();
        }
    }
}
