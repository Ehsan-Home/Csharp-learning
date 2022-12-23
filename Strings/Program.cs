using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "this is str1";

            // concat with +
            // str1 += " continue of string";

            // concat with Concat
            // string outStr = String.Concat(str1, " ", "continue of str1 concat");

            // equal checking with Equals 
            // bool res = String.Equals("hello", "hello");
            // Console.WriteLine(res);

            // equal checking with ==
            // Console.WriteLine("hello" == "hello");

            // First index of a char in the string
            int index = str1.IndexOf("i");
            Console.WriteLine($"index of i {index}");

            // Last index of a char in the string
            index = str1.LastIndexOf("i");
            Console.WriteLine($"last index of i is {index}");

            // len of string
            char lastCh = str1[str1.Length - 2];
            Console.WriteLine($"Last char of the string is {lastCh}");

            // array joining
            string[] strs = { "this", "is", "ehsan", "speaking" };
            string joinedStr = String.Join('_', strs);
            Console.WriteLine($"joined strs are {joinedStr}");
        }
    }
}