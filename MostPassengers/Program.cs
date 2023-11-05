namespace MostPassengers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] on = new int[N];
            int[] off = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                on[i] = Convert.ToInt32(input.Split(" ")[0]);
                off[i] = Convert.ToInt32(input.Split(" ")[1]);
            }

            int maxCount = 0;

            for (int i = 0;i < N; i++)
            {
                if (on[i] > maxCount)
                {
                    maxCount = on[i];                   
                }
            }
            Console.WriteLine(maxCount);

        }
    }
}