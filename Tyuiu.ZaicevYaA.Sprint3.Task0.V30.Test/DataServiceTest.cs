using Tyuiu.ZaicevYaA.Sprint3.Task0.V30.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(1, res);
        }
    }
}