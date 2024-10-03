using Tyuiu.StrekalovRA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] public void TestMethod1() { Assert.AreEqual(-1, DataService.Addition(-10, 9)); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(-19, DataService.Subtraction(-10, 9)); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(-90, DataService.Multiplication(-10, 9)); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(-0.5, DataService.Division(-2, 4)); }
    }
}