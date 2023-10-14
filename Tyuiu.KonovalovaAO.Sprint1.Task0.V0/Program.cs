using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KonovalovaAO.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу,  которая вычисляет выражение  9/3*2+12/4/3-2       *");
            Console.WriteLine("* и печатает результат на экран.                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 9/3*2+12/4/3-2                                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РУЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();

        }
    }
}
