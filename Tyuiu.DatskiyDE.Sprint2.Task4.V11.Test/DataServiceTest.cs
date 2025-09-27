using Tyuiu.DatskiyDE.Sprint2.Task4.V11.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 277.175;
            Assert.AreEqual(wait, res);
        }
    }
}