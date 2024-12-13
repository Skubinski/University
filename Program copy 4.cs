/* Запишете израз, който е истина при изпълнение на указаното условие и лъжа в противен случай:
x принадлежи на интервала [2,5] или на интервала [-1,1]

36в/37
*/


namespace Course_Work_Exercise_3;

class Program
{
    static void Main(string[] args)
    {
        // Enter the value of X
        Console.Write("Enter the value of X: ");
        double x = double.Parse(Console.ReadLine());

        // We create a boolean variable to indicate whether the condition is true or false
        bool correct = false;

        // We check if the condition is true or false and printing whether the statement is True or False
        if (x >= 2 && x <= 5)
        {
            correct = true;
            Console.WriteLine(correct);
        }

        else if (x >= -1 && x <= 1)
        {
            correct = true;
            Console.WriteLine(correct);
        }

        else
        {
            Console.WriteLine(correct);
        }
    }
}
