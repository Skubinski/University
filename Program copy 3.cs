/* Да се отпечатат следните фигури:

87в/61
*/



namespace Course_Work_Exercise_4;

class Program
{
    static void Main(string[] args)
    {
        // Using for loop for the number of rows
        for (int i = 1; i <= 7; i++)
        {
            // Print the spaces
            for (int j = i; j < 7; j++)
            {
                Console.Write(" ");
            }
            
            // Print the stars
            for (int f = 1; f <= i; f++)
            {
                Console.Write("*");
            }
            // Move to the next line
            Console.WriteLine();
        }
    }
}
