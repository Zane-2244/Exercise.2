using System;


namespace Exersice._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter another number");
            var number2 = Convert.ToInt16(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("max is"+max);

        }
    }
}
