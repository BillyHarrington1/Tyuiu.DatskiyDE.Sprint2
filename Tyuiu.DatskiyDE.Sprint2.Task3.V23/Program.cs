using Tyuiu.DatskiyDE.Sprint2.Task3.V23.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                               *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* написать программу, которая вычисляет требуемое значение функции Y с   *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит зн  *");
            Console.WriteLine("* переменной X с клавиатуры.                                             *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Введите x");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
           
            Console.WriteLine("Значение функции = " + res);
            


            Console.ReadKey();
        }
    }
}
