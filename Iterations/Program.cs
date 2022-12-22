using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple for loop
            // for (int i = 0; i < 20; i++)
            // {
            //     Console.WriteLine("i is {0}", i);
            // }

            // forEach
            char[] letters = { 'e', 'h', 's', 'a', 'n', 'e', 's' };
            foreach (char ch in letters)
            {
                if (ch == 'e' || ch == 's')
                {
                    Console.WriteLine("e or s found.");
                }
            }

            string name = "";
            while (name != "exit")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                switch (name)
                {
                    case "ehsan":
                        Console.WriteLine("your name is {0}", name);
                        break;
                    case "arman":
                    case "peyman":
                    case "sasan":
                        Console.WriteLine("you are ehsan's brother.");
                        break;
                    case "exit":
                        Console.WriteLine("You exit.");
                        break;
                    default:
                        Console.WriteLine("You are strange!");
                        break;
                }
            }



        }
    }
}