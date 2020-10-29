using System;

namespace table_of_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the squares and cubes table!");
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter an Integer: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();
                String table = "";
                table += "Number\tSquared\tCubed\n";
                table += "======\t=======\t=====\n";

                for (int i = 1; i <= num; i++)
                {
                    int square = i * i;
                    int cube = i * i * i;
                    table += i + "\t" + square + "\t" + cube + "\n";
                }
                Console.WriteLine(table);
                Console.Write("Continue? ");
                choice = Console.ReadLine();
                Console.WriteLine(" ");
            }
        }
    }
}
