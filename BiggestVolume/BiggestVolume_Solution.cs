using System.Runtime.ExceptionServices;

namespace BiggestVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32 (Console.ReadLine());

            int[] L = new int[N];

            for (int i = 0; i < N; i++)
            {
                L[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0;i < N; i++)
            {
                int Lcalc = (int)Math.Pow(L[i], 3);
                L[i] = Lcalc;               
                sum += L[i];                             
            }

            Console.WriteLine(sum);

        }
    }
}