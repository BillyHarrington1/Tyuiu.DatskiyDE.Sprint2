using System;
using Tyuiu.DatskiyDE.Sprint2.Task5.V11.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                             *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:        *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m *");
            Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.   *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите год (g):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}