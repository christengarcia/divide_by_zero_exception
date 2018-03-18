/*
 * C# Program to Demonstrate DivideByZero Exception
 */

using System;

namespace divide_by_zero_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
        }
    }
}
