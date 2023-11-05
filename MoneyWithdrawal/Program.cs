using System.Security.Cryptography;

namespace MoneyWithdrawal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] Hour = new int[N];
            int[] Minute = new int[N];
            int[] Type = new int[N];
            int[] Number = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                Hour[i] = Convert.ToInt32(input.Split(" ")[0]);
                Minute[i] = Convert.ToInt32(input.Split(" ")[1]);
                Type[i] = Convert.ToInt32(input.Split(" ")[2]);
                Number[i] = Convert.ToInt32(input.Split(" ")[3]);
            }

            int sum = 0;

            for (int i = 0;i < N; i++)
            {
                if (Type[i] == -2)
                {
                    sum += Number[i];                   
                }
            }
            Console.WriteLine(sum);

        }
    }
}