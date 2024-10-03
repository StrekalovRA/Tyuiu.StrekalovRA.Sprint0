namespace Tyuiu.StrekalovRA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int A, int B) { return A + B; }
        public static int Subtraction(int A, int B) { return A - B; }
        public static int Multiplication(int A, int B) { return A * B; }

        public static double Division(int A, int B) { 
            if (B == 0) { return -1; }
            return A / B;
        }
    }
}