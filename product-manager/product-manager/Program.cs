using System;

namespace product_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            business.Product p1 = new business.Product();
            p1.code = "Java";
            p1.description = "Murach's Java Programming";
            p1.price = 59.50;

            business.Product p2 = new business.Product(".net", "Murach's .Net", 59.00);

            Console.WriteLine("p2 = " + p2);

        }
    }
}
