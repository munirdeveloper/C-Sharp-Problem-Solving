namespace HorrorMoviesAttempt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] input1 = input.Split(" ");

            int dataLength = Convert.ToInt32(input1[0]);
            int limitYear = Convert.ToInt32(input1[1]);
            double limitRating = Convert.ToDouble(input1[2]);

            int[] year = new int[dataLength];
            double[] rating = new double[dataLength];
            string[] title = new string[dataLength];

            for (int i = 0; i < dataLength; i++)
            {
                string input2 = Console.ReadLine();
                string[] data = input2.Split(";");

                if (data.Length >= 3)
                {
                    year[i] = Convert.ToInt32(data[0]);
                    rating[i] = Convert.ToDouble(data[1]);
                    title[i] = data[2];                 
                        
                }
            }

            double maxRatedVal = 0;
            int maxRatedInd = 0;

            for (int i = 0;i < dataLength ;i++)
            {
                if (year[i] == limitYear && rating[i] > maxRatedVal)
                {
                    maxRatedVal = rating[i];
                    maxRatedInd = i;
                }
            }
            string filmTitleForMaxVal = title[maxRatedInd];
            Console.WriteLine("#1");
            Console.WriteLine(filmTitleForMaxVal);


            string filmTitleAll = "";

            for (int i = 0; i < dataLength ;i++)
            {
                if (rating[i] == limitRating)
                {
                    filmTitleAll = filmTitleAll + title[i] + "\n";
                }
            }

            Console.WriteLine("#2");
            Console.WriteLine(filmTitleAll);









        }
    }
}