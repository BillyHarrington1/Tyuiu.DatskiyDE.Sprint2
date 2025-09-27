using Tyuiu.DatskiyDE.Sprint2.Task5.V11.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();


            string res1 = ds.FindDateOfNextDay(1939, 08, 31);
            Assert.AreEqual("01.09.1939", res1);
                     
            string res2 = ds.FindDateOfNextDay(2021, 12, 31);
            Assert.AreEqual("01.01.2022", res2);
        }
    }
}
