namespace PlaneTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32 (Console.ReadLine());
            int[] Distance = new int[N];
            int[] Price = new int[N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                Distance[i] = Convert.ToInt32(input.Split(" ")[0]);
                Price[i] = Convert.ToInt32(input.Split(" ")[1]);                
            }
            
            int FurthestCity = Distance[0];
            int CheapestPrice = Price[0];

            int PriceOfFurthestCity = Price[0];

            for (int i = 1; i < N; i++)
            {
                if (CheapestPrice > Price[i])
                {                  
                    CheapestPrice = Price[i];
                }      
                if (FurthestCity < Distance[i])
                {
                    FurthestCity = Distance[i];
                    PriceOfFurthestCity = Price[i];                   
                }                             

            }

            Console.WriteLine(PriceOfFurthestCity);

            int SecondFurthest = Price[0];
            int SecondDistance = Distance[0];
            
            for (int i = 0;i < N; i++)
            {
                if (Price[i] < SecondFurthest && SecondFurthest < PriceOfFurthestCity && Distance[i] < SecondDistance && SecondDistance < FurthestCity )
                {
                    SecondFurthest = Price[i];
                }
            }
            Console.WriteLine(SecondFurthest);
           














        }
    }
}