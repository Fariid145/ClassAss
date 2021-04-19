using System;

namespace Mryusufssinngment20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year");
            int year = Convert.ToInt32(Console.ReadLine());

            int conv = year / 100 + 1;
            Console.WriteLine(conv);

        }
    }
}
