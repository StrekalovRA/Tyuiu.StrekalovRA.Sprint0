namespace Tyuiu.StrekalovRA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[]A) {
            var B = 0;
            foreach (var i in A) { B += i; }
            return B;
        }

        public static object SubtractionArray(int[] A) {
            var B = 0;
            foreach (var i in A) { B -= i; }
            return B;
        }

        public static object MultiplicationArray(int[] A) {
            var B = 1;
            foreach (var i in A) { B *= i; }
            return B;
        }
    }
}