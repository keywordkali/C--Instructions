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
            string rollDice = getChoiceString("Do you want to roll the dice?", "Y", "y");
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
        public static String getChoiceString(String prompt, String s1, String s2)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                s = GetRequiredString(prompt);
                if (!s.Equals(s1) && !s.Equals(s2))
                {
                    Console.WriteLine("Error! Entry must be '" + s1 + "' or '" +
                            s2 + "'. Try again.");
                }
                else
                {
                    isValid = true;
                }
            }
            return s;
        }
        public static string GetRequiredString(String prompt)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                if (s.Equals(""))
                {
                    Console.WriteLine("Error! This entry is required. Try again.");
                }
                else
                {
                    isValid = true;

                }
                break;
            }
            return s;
            

        }
       
    }
}
