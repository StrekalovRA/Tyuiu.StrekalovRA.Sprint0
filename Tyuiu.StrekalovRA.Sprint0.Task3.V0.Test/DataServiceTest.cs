using Tyuiu.StrekalovRA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-1, DataService.Sum(-10, 9));
        }
    }
}