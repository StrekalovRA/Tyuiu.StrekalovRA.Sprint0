using Tyuiu.StrekalovRA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] public void TestMethod4() { Assert.AreEqual(-0.5, DataService.Division(3, 0)); }
    }
}