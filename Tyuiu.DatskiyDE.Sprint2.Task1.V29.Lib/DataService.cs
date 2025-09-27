using tyuiu.cources.programming.interfaces.Sprint2;
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
// а также арифметических выражений, которая вернет логическую последовательность(массив):
// (True, True, True, False, True, True), при a = 657, b = 654, c = 657, d = 657

namespace Tyuiu.DatskiyDE.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {   
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) & (c == d);
            res[1] = (a != b) | (d > b);
            res[2] = (c <= a) && (a >= d);
            res[3] = (b > a) ^ (d < c);
            res[4] = (a > b) || (c != d);
            res[5] = (b <= c) & !(d == b);

            return res;
        }
    }
}
