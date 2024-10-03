using Tyuiu.StrekalovRA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.AdditionArray(new int[] { 2, 4, 1, 10 }));
            Console.WriteLine(DataService.SubtractionArray(new int[] { 2, 4, 10 }));
            Console.WriteLine(DataService.MultiplicationArray(new int[] { 2, 4, -1, 3 }));
        }
    }
}