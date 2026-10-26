using Tyuiu.GilevaAP.Sprint3.Task6.V25.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            int wait = 89;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
