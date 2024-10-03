using Tyuiu.StrekalovRA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int[] A = new int[] { 1, 2, 3, 4 };
        int[] B = new int[] { -1, -9 };
        int[] C = new int[] { -1, -1, 2, 5 };
        [TestMethod] public void TestMethod1() { Assert.AreEqual(10, DataService.AdditionArray(A)); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(10, DataService.SubtractionArray(B)); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(10, DataService.MultiplicationArray(C)); }
    }
}