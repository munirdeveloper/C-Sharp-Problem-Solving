namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            string[] station = new string[N];
            int[] arrival = new int[N];
            int[] departure = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                station[i] = (input.Split(" ")[0]);
                arrival[i] = Convert.ToInt32(input.Split(" ")[1]);
                departure[i] = Convert.ToInt32(input.Split(" ")[2]);

            }

            bool foundit = false;

            for (int i = 0;i < N; i++)
            {
                if (station[i] == "Szekesfehervar" && arrival[i] == -1)
                {
                    Console.WriteLine(departure[i]);
                    foundit = true;
                    break;
                }
            }

            if (!foundit)
            {
                Console.WriteLine("-1");
            }
        }
    }
}