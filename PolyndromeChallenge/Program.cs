using System;
using System.Text;

namespace Polyndrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }
                str = CleanStr(str);
                (bool, int) res = isPolyndrome(str);
                Console.WriteLine($"Polindorme: {res.Item1}, length:{res.Item2}");
            }
        }

        static string CleanStr(string str)
        {
            StringBuilder sb = new StringBuilder("");
            foreach (char ch in str)
            {
                if (!char.IsPunctuation(ch) && ch != ' ')
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString().ToLower();
        }

        // raddar, halfSize = 3
        static (bool, int) isPolyndrome(string str)
        {
            int halfSize = (int)(str.Length / 2);
            int length = str.Length;
            for (int i = 0; i < halfSize; i++)
            {
                if (str[i] != str[length - (i + 1)])
                {
                    return (false, 0);
                }
            }
            return (true, length);
        }

    }
}