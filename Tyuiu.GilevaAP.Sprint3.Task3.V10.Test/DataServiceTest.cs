using Tyuiu.GilevaAP.Sprint3.Task3.V10.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            string value = "gdfppf vfppt p";
            char item = 'p';
            string wait = "gdff vft ";
            string res = ds.DeleteCharInString(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
