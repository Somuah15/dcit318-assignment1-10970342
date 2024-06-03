using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first side: ");
            int side1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the second side: ");
            int side2 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the third side: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
