namespace ProtectedWalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           string inputone = Console.ReadLine();
           int N = Convert.ToInt32 (inputone.Split(" ")[0]);
           int M = Convert.ToInt32(inputone.Split(" ")[1]);
           int[] id = new int[M];

           for (int i = 0; i < M; i++)
            {
                id[i] = Convert.ToInt32(Console.ReadLine());
            }

           int count = 1;

           for (int i =1; i < M-1; i++)
            {
                if ((id[i]+1 == id[i+1]) || (id[i] - 1 == id[i - 1]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

          
        }
    }
}