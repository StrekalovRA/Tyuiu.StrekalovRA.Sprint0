namespace Tyuiu.StrekalovRA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] A, int[]B) {
            int[]C = new int[A.Length];
            for (int I = 0; I < A.Length; I += 1) { C[I] = A[I] + B[I]; }
            return C;
        }
    }
}