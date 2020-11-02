using System;
namespace product_manager
{
    public class MyConsole
    {
        public static String getString(String prompt)
        {
            Console.WriteLine(prompt);
            string s = Console.ReadLine();  // read user entry

            return s;
        }

        public static String getLine(String prompt)
        {
            Console.WriteLine(prompt);
            String s = Console.ReadLine();  // read user entry


            return s;
        }

        public static int getInt(String prompt)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);


                try
                {

                    i = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter something valid.");
                }
            }
            return i;
        }

        public static int GetInt(String prompt, int min, int max)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                i = getInt(prompt);
                if (i < min)
                {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (i > max)
                {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(String prompt)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                try
                {

                    d = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter something valid.");
                }
            }
            return d;
        }

        public static double GetDouble(String prompt, double min, double max)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                d = getDouble(prompt);
                if (d < min)
                {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (d > max)
                {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return d;
        }
        public static String getRequiredString(String prompt)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                Console.ReadLine();
                if (s.Equals(""))
                {
                    Console.WriteLine("Error! This entry is required. Try again.");
                }
                else
                {
                    isValid = true;
                }
            }
            return s;
        }
        public static String getChoiceString(String prompt, String s1, String s2)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                s = getRequiredString(prompt);
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

        public static bool GetBoolean(String prompt)
        {
            String check = getChoiceString(prompt, "true", "false");
            if (check.Equals("true"))
                return true;
            else
                return false;
        }
    }
}



