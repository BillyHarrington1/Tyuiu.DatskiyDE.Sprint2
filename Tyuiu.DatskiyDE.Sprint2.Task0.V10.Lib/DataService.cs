using tyuiu.cources.programming.interfaces.Sprint2;
// Написать программу из операций сравнений
// (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
// и арифметических выражений, которая вернет логическую последовательность(массив):
// (False, True, False, True, False, True), при x = 1305, y = 475

namespace Tyuiu.DatskiyDE.Sprint2.Task0.V10.Lib
{
    public class DataService : ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 1 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x + 2 > y;
            res[4] = x <= y;
            res[5] = x + 3 >= y;

            return res;
        }
    }
}
