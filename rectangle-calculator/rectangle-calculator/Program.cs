using System;

namespace rectangle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine(" ");
            String choice = "y";
            
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter length: ");
               double l = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                double w = Double.Parse(Console.ReadLine());

                double area = l * w;
                double perimeter = 2 * l + 2 * w;

                Console.WriteLine("Area:         " + area);
                Console.WriteLine("Perimeter:    " + perimeter);
                Console.WriteLine();

                Console.Write("Continue? ");
                choice = Console.ReadLine();
                Console.WriteLine(" ");



            }
        }
    }
}
