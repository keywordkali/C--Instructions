using System;

namespace ch03_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr1 = 7;
            Console.WriteLine("nbr1 = " + nbr1);

            nbr1++;
            Console.WriteLine("nbr1 = " + nbr1);
            nbr1--;
            Console.WriteLine("nbr1 = " + nbr1);
            nbr1+=4; //compound assignment operator +=
            Console.WriteLine("nbr1 = " + nbr1);
        }
    }
}
