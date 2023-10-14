using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint1.Task3.V18.Lib;
namespace Tyuiu.KonovalovaAO.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные        *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране.    *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double a, b, c;
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину  стороны квадрата:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РУЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Количество квадраров размещеных в прямоугольнике без наложений  = " + ds.HowManySquares(a, b, c));
            Console.ReadLine();



        }
    }
}
