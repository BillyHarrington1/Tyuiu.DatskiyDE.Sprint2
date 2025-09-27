using System;
using Tyuiu.DatskiyDE.Sprint2.Task6.V5.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                               *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.  *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера:        *");
            Console.WriteLine("* «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.               *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям.           *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство карты*");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите номер карты (6-14):");
            int k = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindCardValue(k);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Достоинство карты: " + res);

            Console.ReadKey();
        }
    }
}