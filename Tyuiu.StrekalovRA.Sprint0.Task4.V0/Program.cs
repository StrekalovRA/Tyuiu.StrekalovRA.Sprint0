using Tyuiu.StrekalovRA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.StrekalovRA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(3, 4));
            Console.WriteLine(DataService.Subtraction(3, -2));
            Console.WriteLine(DataService.Multiplication(2, 4));
            Console.WriteLine(DataService.Division(7, 4));
            Console.ReadKey();
        }
    }
}