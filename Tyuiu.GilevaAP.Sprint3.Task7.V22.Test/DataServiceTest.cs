using Tyuiu.GilevaAP.Sprint3.Task7.V22.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double actual = res[5];
            double expected = 0.5;

            Assert.AreEqual(expected, actual);
        }
    }
}
