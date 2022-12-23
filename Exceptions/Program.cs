using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hi there";
            string str2 = str.Remove(4, 1);
            Console.WriteLine(str2);
            // int x = 100, y = 0;
            // try
            // {
            //     Console.WriteLine(x / y);
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("this is executed each time.");
            // }

            string name = Console.ReadLine();
            string[] validNames = { "ehsan", "arman", "peyman", "sasan" };
            try
            {
                if (validNames.Contains(name))
                {
                    Console.WriteLine("name is correct");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("name", "name is not valid");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Best place for cleanup.");
            }
        }
    }
}