/* Да се състави алгоритъм за изчисляване на разстоянието d между две точки в равнината - A и B,
 зададени със своите декартови координати - Xa, Ya и Xb, Yb

 15/31
*/


namespace Course_Work_Exercise_2;

class Program
{
    static void Main(string[] args)
    {
        // Xa
        Console.Write("Enter the Xa coordinant: ");
        double Xa = double.Parse(Console.ReadLine());

        // Ya
        Console.Write("Enter the Ya coordinant: ");
        double Ya = double.Parse(Console.ReadLine());

        // Xb
        Console.Write("Enter the Xb coordinant: ");
        double Xb = double.Parse(Console.ReadLine()); 

        // Yb
        Console.Write("Enter the Yb coordinant: ");
        double Yb = double.Parse(Console.ReadLine());

        // Calculating the distance
        var distance = Math.Sqrt((Math.Pow(Xa - Xb, 2) + (Math.Pow(Ya - Yb, 2))));

        // Printing the distance
        Console.WriteLine("The distance is: {0}", distance);

    }
}
