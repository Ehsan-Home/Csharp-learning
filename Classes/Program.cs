using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bmw = new Vehicle(1234, "Z7", 2018, 4);

            Console.WriteLine(bmw.GetModelNumber());

            bmw.SetModelNumber(3345);

            Console.WriteLine(bmw.GetModelNumber());
        }
    }
}