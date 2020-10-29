using System;

namespace student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form ");
            Console.WriteLine(" ");
            
                Console.Write("Enter a first name: ");
                String fn = Console.ReadLine();
                Console.Write("Enter a last name: ");
                String ln = Console.ReadLine();
                Console.Write("Enter your year of birth: ");
                int birthYear = int.Parse(Console.ReadLine());

            //create full name and temp password
            String name = fn + " " + ln;
            String password = fn + "*" + birthYear;

            Console.WriteLine(" ");
            Console.WriteLine("Welcome " + name + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + password);
        }




















            
        }
    }

