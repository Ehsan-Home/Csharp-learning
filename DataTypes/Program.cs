using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 30.3f;
            decimal d = 10.3m;
            bool bo = false;

            string str = "a string";
            char ch = 'c';
            int[] arrayStr = new int[5];
            char[] arrayCh = { 'e', 'h', 's', 'a', 'n' };

            Console.WriteLine("{0},{1},{2}", a, b, d);
            Console.WriteLine(d.ToString());

        }
    }
}