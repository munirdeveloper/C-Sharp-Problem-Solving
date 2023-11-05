namespace GameConsoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] companies = new string[N];

            for (int i = 0; i < N ; i++)
            {
                companies[i] = Console.ReadLine();
            }            

            int M = Convert.ToInt32(Console.ReadLine());
            int[] id = new int[M];
            int[] generation = new int[M];
            int[] consCount = new int[M];
            
            for (int i = 0;i < M ; i++)
            {
                string input = Console.ReadLine();
                id[i] = Convert.ToInt32(input.Split(" ")[0]);
                generation[i] = Convert.ToInt32(input.Split(" ")[1]);
                consCount[i] = Convert.ToInt32(input.Split(" ")[2]);
            }
         

            Dictionary<int, string> idToCompany = new Dictionary<int, string>();

            for (int i = 0; i < N; i++)
            {
                idToCompany[i + 1] = companies[i];
            }

            int count = 0;

            for (int i = 0; i < M; i++)
            {
                if (generation[i] == 7)
                {
                    count++;
                    Console.WriteLine("{0} {1}", count, idToCompany[id[i]]);
                }
            }

           
        }
    }
}