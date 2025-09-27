using Tyuiu.DatskiyDE.Sprint2.Task2.V10.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task2.V10
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
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Paint                                                                  *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            if (res)
            {
                Console.WriteLine("Точка есть в области");
            }
            else
            {
                Console.WriteLine("Точки нет в области");
            }
                

            Console.ReadKey();
        }
    }
}
