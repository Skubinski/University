// 380/214

namespace Course_Work_Exercise_5;

class Program
{
    static void Main(string[] args)
    {
        //STEP 1
        // Enter k
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        // Enter numbers
        int oddSum = 0;
        Console.WriteLine("Enter nonnullable numbers (0 = exit!): ");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            else if (number % 2 != 0)
            {
                oddSum += number;
            }

        }
        // Print the sum of odd numbers
        Console.WriteLine("The sum of odd number is: {0}", oddSum);

        //STEP 2
        // Enter 8 digits that are bigger than 0
        int product = 1;
        int counter = 0;
        while (counter != 8)
        {
            Console.Write("Enter a positive number: ");
            int digit = int.Parse(Console.ReadLine());
            if (digit > 0)
            {
                product *= digit;
                counter++;
            }
            else
            {
                Console.WriteLine("The number is negative!");
                continue;
            }
        }

        // Calculating the root with base 8
        double eighthRoot = Math.Pow(product, 1.0 / 8.0);

        // Printing
        Console.WriteLine("The product of all numbers is: {0}", product);
        Console.WriteLine("The eight root of the product of eight positive numbers is: {0}", eighthRoot);

        //STEP 3

        // Calling the method and printing the resulta
                
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int absDiff = Math.Abs(a - b);
        int sumBC = b + c;

        // Извикване на метода Sss и изчисляване на резултата
        int returnedNumber = Sss(k);
        int result = returnedNumber * absDiff * sumBC;

        // Отпечатване на резултата
        Console.WriteLine("The result from Sss(|a - b|) * Sss(b + c) is: " + result);


    }
    static int Sss(int k)
        {
            Random random = new Random();
            int product = 1;
            bool found = false; 

            for (int i = 0; i < k; i++)
            {
                int num = random.Next(1, 100); // Generate number between 1 and 99

                // Checking
                if (num >= 10 && num <= 99 && num % 10 == 5)
                {
                    product *= num;
                    found = true;
                }
            }

            // If there is not founded number return 1
            return found ? product : 1;
        }
}
