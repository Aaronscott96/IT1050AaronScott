using System;

namespace LAB_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            int  sum;
            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine($"Sum is {sum}");

            Console.WriteLine("Hello World!\nFrom Aaron Scott");
            Console.Write("Hello world!         From Aaron Scott");
            
            


        }
    }
}
