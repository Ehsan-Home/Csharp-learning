using System;

namespace Program
{
    public class Car : Vehicle
    {
        private int _numberOfHeaters;
        public Car(int modelNumber, string model, int year, int numberOfWheels, string inputColor, int numberOfHeaters) : base(modelNumber, model, year, numberOfWheels, inputColor)
        {
            _numberOfHeaters = numberOfHeaters;
        }

        public void PrintModelNumber()
        {
            Console.WriteLine($"model number is {base.ModelNumber}");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is moving with the speed of 44 KM/h");
        }
    }
}