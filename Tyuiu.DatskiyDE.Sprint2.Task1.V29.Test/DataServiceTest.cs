using Tyuiu.DatskiyDE.Sprint2.Task1.V29.Lib;
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
// а также арифметических выражений, которая вернет логическую последовательность(массив):
// (True, True, True, False, True, True), при a = 657, b = 654, c = 657, d = 657
namespace Tyuiu.DatskiyDE.Sprint2.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
