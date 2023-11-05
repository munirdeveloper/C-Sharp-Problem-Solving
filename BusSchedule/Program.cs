namespace BusSchedule
{
    internal class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] towns = new string[N];
            int[] arrival = new int[N];
            int[] departure = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length >= 3)
                {
                    towns[i] = parts[0];
                    arrival[i] = Convert.ToInt32(parts[1]);
                    departure[i] = Convert.ToInt32(parts[2]);
                }
            }

            bool foundit = false;

            for (int i = 0; i < N; i++)
            {
                if (towns[i] == "Szekszard" && arrival[i] == -1)
                {

                    foundit = true;

                }


            }

            if (foundit == true)
            {
                Console.WriteLine("YES!!!");
            }

            else
            {
                Console.WriteLine("NO!!!");
            }

        }
    }
}