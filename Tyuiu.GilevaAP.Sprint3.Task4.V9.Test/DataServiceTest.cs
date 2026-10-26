using Tyuiu.GilevaAP.Sprint3.Task4.V9.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int StopValue = 5;
            double res = ds.Calculate(startValue, StopValue);
            double wait = 1.708;
            Assert.AreEqual(wait, res);
        }
    }
}
