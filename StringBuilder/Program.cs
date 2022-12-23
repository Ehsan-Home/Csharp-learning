﻿using System;
using System.Text;

namespace MyStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // more efficient than + or concat
            StringBuilder sb = new StringBuilder("str");
            sb.Append("str2");

            string[] strs = { "peyman", "arman", "sasan", "ehsan" };
            sb.AppendJoin("*", strs);

            Console.WriteLine(sb.ToString());
        }
    }
}