using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bmw = new Vehicle(1234, "Z7", 2018, 4, "Blue");

            bmw.ModelNumber = 9807;

            Console.WriteLine(bmw.ModelNumber);

            bmw.Model = "X3";

            Console.WriteLine(bmw.Model);
            Console.WriteLine(bmw.Color);
        }
    }
}