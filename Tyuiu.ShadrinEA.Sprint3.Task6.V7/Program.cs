using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint3.Task6.V7.Lib;

namespace Tyuiu.ShadrinEA.Sprint3.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Алгоритмы  циклической структуры                                       *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #7                                                                   *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому  *");
            Console.WriteLine("* отрезку [17, 26] сумму всех делителей .                                      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int start1 = 17;
            int stop1 = 26;

            Console.WriteLine("Начало отрезка = " + start1);
            Console.WriteLine("Конец отрезка = " + stop1);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма делителей отрезка = " + ds.GetSumTheDivisors(start1, stop1));
            Console.ReadKey();
        }
    }
}
