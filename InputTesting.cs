namespace InputTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] M = new int[N];
            int[] E = new int[N];
            int[] A = new int[N];
            int[] B = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                M[i] = Convert.ToInt32(input.Split(" ")[0]);
                E[i] = Convert.ToInt32(input.Split(" ")[1]);
                A[i] = Convert.ToInt32(input.Split(" ")[2]);
                B[i] = Convert.ToInt32(input.Split(" ")[3]);              
            }           

        }
    }
}