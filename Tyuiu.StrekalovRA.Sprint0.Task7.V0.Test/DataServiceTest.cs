using Tyuiu.StrekalovRA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int[] A = new int[] { 1, 2, 3, 4 };
        int[] B = new int[] { -1, -9, 1, 3 };
        int[] C = new int[] { 0, -7, 4, 7 };
        [TestMethod] public void TestMethod1() { CollectionAssert.AreEqual(C, DataService.AdditionArrays(A, B)); }
    }
}