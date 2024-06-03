using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 65 || age <= 12)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }
    }
}
