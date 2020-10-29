using System;

namespace travel_time_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter Miles:  ");
                int miles = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Miles per hour: ");
                int mph = int.Parse(Console.ReadLine());
                double hours = miles / mph;
                int minutes = (int)(hours * 60);
                int hoursInt = minutes / 60;
                minutes = minutes % 60;
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours:   " + hoursInt);
                Console.WriteLine("Minutes: " + minutes);
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();

            }
        }
    }
}
