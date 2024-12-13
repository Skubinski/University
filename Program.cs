using System.Net.Security;

namespace Course_Work_Exercise_7;

class Program
{
    static void Main(string[] args)
    {
        string [] cities = new string[50];

        addCities(cities);

        sortCities(cities);


        
    }
    static void addCities (string [] cities)
    {
        for (int index = 0; index < cities.Length; index++)
        {
            Console.Write("Enter the name of the city (Exit - to stop adding): ");
            string newCity = Console.ReadLine();
            if (newCity.ToLower() == "exit")
            {
                break;
            }
            else
            {
                newCity = char.ToUpper(newCity[0]) + newCity.Substring(1).ToLower();

                cities[index] = newCity;
            }
        }
    }

    static void sortCities (string [] cities)
    {
        Array.Sort(cities);
        for (int city = 0; city < cities.Length; city++)
        {
            Console.WriteLine(cities[city]);
        }
    }
}
