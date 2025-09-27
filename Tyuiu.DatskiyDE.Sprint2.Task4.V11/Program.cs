using Tyuiu.DatskiyDE.Sprint2.Task4.V11.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task4.V11
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* написать программу, которая вычисляет требуемое значение c             *");
            Console.WriteLine("* использованием тернарного оператора, ввод x,y, если                    *");
            Console.WriteLine("* z = x - 20 * 2 < y / 4 ? (3 + 8 / (x, 2),y) : y - (x + 1 / y + 2, x);  *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Введите x");
            double x = Convert.ToInt32(Console.ReadLine());
  

            Console.WriteLine("Введите y");
            double y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x,y);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
