using System.Globalization;
using System.Linq;

namespace ShipsHarbour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = Convert.ToInt32(input.Split(" ")[0]);
            int M = Convert.ToInt32(input.Split(" ")[1]);
            int[] DaysArrived = new int[M];

            for (int i = 0; i < N; i++)
            {
                DaysArrived[i] = Convert.ToInt32(Console.ReadLine());                
            }

            int MaxDay = DaysArrived[0];
            int MinDay = DaysArrived[0];
            int MaxDayIndex = 0;
            int MinDayIndex = 0;

            for (int i = 1; i < N;  i++)
            {
                if (DaysArrived[i] > MaxDay)
                {
                    MaxDay = DaysArrived[i];
                    MaxDayIndex = i;                  

                }

                if (DaysArrived[i] < MinDay)
                {
                    MinDay = DaysArrived[i];
                    MinDayIndex = i;

                }

            }
            // subtask 1
            Console.WriteLine("#");
 // 
            int NoShipsArrived = (MaxDay - MinDay + 1);
            Console.WriteLine(NoShipsArrived);
            Console.WriteLine("#");

            //subtask 2

            int resultDay = -1;
            bool foundValue = false;

            for (int i = 2; i < M - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {                  

                    if (i == DaysArrived[j] && i-1 != DaysArrived[j] && i+1 != DaysArrived[j] && foundValue == false)
                    {
                       resultDay = DaysArrived[j];
                       foundValue = true;
                       Console.WriteLine(resultDay);
                    }
                    
                }
                              
               
            }
            Console.WriteLine("#");
            //subtask 3
           
            int LongestPeriod = 0;
            int CurrentPeriod = 0;

            for (int i = 1; i < N; i++)
            {
                int gap = DaysArrived[i] - DaysArrived[i - 1] - 1;

                if (gap > 0)
                {
                    CurrentPeriod += gap;
                }
                else
                {
                    CurrentPeriod = 0;
                }

                if (CurrentPeriod > LongestPeriod)
                {
                    LongestPeriod = CurrentPeriod;
                }
            }
           
            Console.WriteLine(LongestPeriod);

            //subtask 4
            Console.WriteLine("#");

            int currentCount = 0;
            int maxCount = 0;
            int MostRepeated = DaysArrived[0];

            for (int i = 1; i < N;i++)
            {
                if (DaysArrived[i] == DaysArrived[i-1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    MostRepeated = DaysArrived[i];
                }

            }
            Console.WriteLine(MostRepeated);
        }
    }
}