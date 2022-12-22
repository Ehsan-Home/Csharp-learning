using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
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