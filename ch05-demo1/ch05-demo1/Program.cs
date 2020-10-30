using System;

namespace ch05_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5!");
          

            int nbr = ParseInt("Enter a number: ");

            Console.WriteLine("You entered : " + nbr);
            

            PrintOrderDetails( "Target ", 33, "Light up pumpkin");
            PrintCandyStats("Snickers", 5);
            PrintCandyStats("Kit Kat");
            PrintFaveSong("Accidents Will Happen");
        }
        private static int ParseInt(String prompt)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine(prompt);


                try
                {

                    return int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter something valid.");
                }
            }
            return n;
        }
        //demonstrate of named parameters
            private static void PrintOrderDetails(String sellerName, int orderNum,String productName)
            {
                Console.WriteLine("Order Details: " + productName + ", on " + "Order # " + orderNum + ", purchased at" + sellerName);
            }
        //demonstrating optional parameters
        private static void PrintCandyStats(String candyName, int quantity = 0)
        {
            Console.WriteLine("* " + quantity + " pieces of " + candyName);

        }
       private static void PrintFaveSong(String name)
        {
            Console.WriteLine($"My favorite song is {name}.");

        } 

    }
    }

