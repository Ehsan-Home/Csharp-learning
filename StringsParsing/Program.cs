using System;

namespace StringsParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123", str2 = "123.123", str3 = "true";
            int num = 0;
            decimal num2 = 0;
            bool state = false;

            try
            {
                num = int.Parse(str1);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(num.ToString());

            try
            {
                num2 = decimal.Parse(str2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                state = bool.Parse(str3);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(state.ToString());

            // TryParse
            str1 = "666";
            bool succeed = int.TryParse(str1, out num);
            if (!succeed)
            {
                Console.WriteLine("conversion not successful");
            }
            else
            {
                Console.WriteLine($"The value of num using TryParse {num}");
            }
        }
    }
}