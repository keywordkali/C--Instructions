using System;

namespace dice_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesPlayed = 0;
            Console.WriteLine("Welcome to the Dice Roller Game!");
            Console.Write("Do you want to roll the dice? y/n: ");
            string rollDice = Console.ReadLine();
                int total = 0;
            while (rollDice.Equals("y"))
            {

                Random rand = new Random();
                int die1 = rand.Next(1, 6);
                total += die1;
                  
                if (die1 == 1)
                {
                    Console.WriteLine($"Total is {total}");
                    Console.WriteLine("Play again? ");
                    rollDice = Console.ReadLine();
                   
                }
            }
            Console.WriteLine("Thank you for playing!");
        }
    }
}
