using System;

namespace grade_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Converter App!");

            // display a welcome message
            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();  // print a blank line


            // perform conversions until choice isn't equal to "y" or "Y"
            String choice = "y";
            while (choice.Equals("y"))
            {
                // get numerical grade from user
                Console.WriteLine("Enter numerical grade: ");
                int numericalGrade = int.Parse(Console.ReadLine());

                // convert numerical grade to letter grade
                String letterGrade = " ";
                if (numericalGrade >= 88)
                    letterGrade = "A";
                else if (numericalGrade >= 80)
                    letterGrade = "B";
                else if (numericalGrade >= 67)
                    letterGrade = "C";
                else if (numericalGrade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                // display the result of the conversion
                Console.WriteLine("Letter grade: " + letterGrade + "\n");

                // see if the user wants to continue
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine(" ");
            }
        }
    }
}
