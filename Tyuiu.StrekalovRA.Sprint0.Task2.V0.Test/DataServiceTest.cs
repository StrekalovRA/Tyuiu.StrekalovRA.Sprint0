using Tyuiu.StrekalovRA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Привет, жук", DataService.GetMessage("жук"));
        }
    }
}