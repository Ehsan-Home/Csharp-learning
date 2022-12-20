using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;

            Console.WriteLine("a/b:" + a / b);
            Console.WriteLine("a%b:" + a % b);
            Console.WriteLine("a*b:" + a * b);

            string str1 = "hello", str2 = " world";

            Console.WriteLine(str1 + str2);

            string str3 = null;
            // Similar to swift
            Console.WriteLine(str3 ?? "no value");

            // if (str3 == null)
            // {
            //     str3 = "No value";
            // }
            str3 ??= "Assigned value";
            Console.WriteLine(str3);
        }
    }
}