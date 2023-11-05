namespace BirthSeason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] year = new int[N];
            int[] month = new int[N];
            int[] day = new int[N];
            int[] startYear = new int[N];
            int[] gradYear = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                year[i] = Convert.ToInt32(input.Split(" ")[0]);
                month[i] = Convert.ToInt32(input.Split(" ")[1]);
                day[i] = Convert.ToInt32(input.Split(" ")[2]);
                startYear[i] = Convert.ToInt32(input.Split(" ")[3]);
                gradYear[i] = Convert.ToInt32(input.Split(" ")[4]);
            }

            int springcount = 0;
            int summercount = 0;
            int autumncount = 0;
            int wintercount = 0;
            
            for (int i = 0;i < N; i++)
            {
                if (month[i] == 2 || month[i] == 3 || month[i] == 4)
                {
                    springcount++;
                }
                else if (month[i] == 5 || month[i] == 6 || month[i] == 7 || month[i] == 8)
                {
                    summercount++;
                }
                else if (month[i] == 9 || month[i] == 10 )
                {
                    autumncount++;
                }
                else if (month[i] == 1 || month[i] == 12)
                {
                    wintercount++;
                }
            }

            Console.WriteLine("{0} {1} {2} {3}", springcount, summercount, autumncount, wintercount);
            
        }
    }
}