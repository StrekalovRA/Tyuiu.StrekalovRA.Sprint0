using Tyuiu.StrekalovRA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task7.V0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[]A = new int[] {1, -10, 3, 0, 1 };
            int[] B = new int[] { 3, 10, 13, 1, 4};
            var C = DataService.AdditionArrays(A, B);
            foreach (int i in C) { Console.Write(i + " "); }
        }
    }
}