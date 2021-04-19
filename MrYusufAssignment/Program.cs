using System;

namespace MrYusufAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wetin u wan do gangan ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToInt32(Console.ReadLine());

            double total = number1 / number2;
            Console.WriteLine(total);
        }
    }
}
