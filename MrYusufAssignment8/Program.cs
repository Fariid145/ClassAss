using System;

namespace MrYusufAssignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to convert:  ");
            int celcius = Convert.ToInt32(Console.ReadLine());

            // celcius(farenheit);
            // celcius(kelvin);

            // public static void ToFarenheit()
            // {
                Console.WriteLine("farenheit {0}", celcius + 273);
            // }
            // public static void ToKelvin()
            // {
                Console.WriteLine("kelvin {0}", celcius*9/5 + 32);
            // }
        }
    }
}
