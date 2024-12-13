// 402/221

namespace Course_Work_Exercise_6;

class Program
{
    static void Main(string[] args)
    {
        double [] rainings = new double[31];
        int n = 0;

        while (true)
        {
            Console.Write("Enter the month day count (<= 31): ");
            int m = int.Parse(Console.ReadLine());
            if (m > 0 && m <= 31)
            {
                n = m;
                break;
            }
        }

        double [] A = new double[n];
        double [] B = new double[n];
        double [] C = new double[n];

        Console.WriteLine("Enter rain ammounts for station A: ");
        addRains(A);

        Console.WriteLine("Enter rain ammounts for station B: ");
        addRains(B);

        Console.WriteLine("Enter rain ammounts for station C: ");
        addRains(C);

        Console.WriteLine("Results: ");

        PrintRainResults(A, "Station A");
        PrintRainResults(B, "Station B");
        PrintRainResults(C, "Station C");
        

    }

    static void addRains (double [] rainings)
    {
        for (int day = 0; day < rainings.Length; day++)
        {
            Console.Write("Enter the ammount of rains in l/sq2 for day {0}: ", day + 1);
            double ammount = double.Parse(Console.ReadLine());
            rainings[day] = ammount;
        }   
    }

    static double MinimalRains(double [] rainings)
    {
        double minRains = double.MaxValue; 
        bool hasRain = false; 

        foreach (double rains in rainings)
        {
            if (rains > 0) 
            {
                hasRain = true; 
                if (rains < minRains) 
                {
                    minRains = rains;
                }
        }   }
        return hasRain ? minRains : 0;
    }

    static void PrintRainResults(double[] rainings, string stationName)
    {
        double minRain = MinimalRains(rainings);

        if (minRain == 0)
        {
            Console.WriteLine($"{stationName}: No days with rain.");
        }
        else
        {
            Console.WriteLine($"{stationName}: Minimum rain amount for rainy days is {minRain} l/sq2.");
            Console.Write("Days with minimum rain: ");
            for (int i = 0; i < rainings.Length; i++)
            {
                if (rainings[i] == minRain)
                {
                    Console.Write($"{i + 1} "); 
                }
            }
            Console.WriteLine(); 
        }
    }

}
