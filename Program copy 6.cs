/* 
Превърнете числото 2008 в 2, 8 и 16 - ична бройна система
*/




namespace Course_Work_Exercise_1;

class Program
{
    static void Main(string[] args)
    {
        // The number that is going to be converted
        int number = 2008;

        // Converting to binary
        string binary = Convert.ToString(number, 2);

        // Printing the Result:
        Console.WriteLine("The number {0} converted to binary is {1}!", number, binary);

        // Converting to octal
        string octal = Convert.ToString(number, 8);

        // Printing the Result:
        Console.WriteLine("The number {0} converted to octal is {1}!", number, octal);

        // Converting to hexadecimal
        string hexadecimal = Convert.ToString(number, 16);

        // Printing the Result:
        Console.WriteLine("The number {0} converted to hexadecimal is {1}!", number, hexadecimal);

    }
}
