using System;

namespace Logical_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
            }
            else
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Enter the second number:");

            if (int.TryParse(Console.ReadLine(), out int b))
            {
            }
            else
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the operator:");
            char input_operator = char.Parse(Console.ReadLine());

            switch (input_operator)
            {
                case '&':
                    Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b, 10));
                    Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b, 2));
                    Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b, 16));
                    Console.ReadLine();
                    break;
                case '|':
                    Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b, 10));
                    Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b, 2));
                    Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b, 16));
                    Console.ReadLine();
                    break;
                case '^':
                    Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b, 10));
                    Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b, 2));
                    Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b, 16));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong operator!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
