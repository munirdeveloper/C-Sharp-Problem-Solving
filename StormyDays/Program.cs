namespace StormyDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int N = Convert.ToInt32(input.Split(" ")[0]);
            int K = Convert.ToInt32(input.Split(" ")[1]);

            int[] Wind = new int[N];

            for (int i = 0; i < N; i++)
            {
                Wind[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Count = 0;

            for (int i = 0;i < N; i++)
            {
                if (Wind[i] > 100)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}