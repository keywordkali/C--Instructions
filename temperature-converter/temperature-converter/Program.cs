using System;

namespace temperature_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter! ");
            Console.WriteLine(" ");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter degrees in Fahrenheight: ");
                double fh = Double.Parse(Console.ReadLine());

                double cel = (fh - 32) * 5 / 9;
                Console.WriteLine(cel);

                // display the result of the conversion
               Console.WriteLine("Degrees in Celsius: " + cel);

                // see if the user wants to continue
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine("");


            }
        }
    }
}
