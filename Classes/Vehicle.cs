using System;

namespace Program
{
    public class Vehicle
    {
        private int _modelNumber;
        private string _model;
        private int _year;
        private int _numberOfWheels;

        public string Color
        {
            get; set;
        }

        public Vehicle(int modelNumber, string model, int year, int numberOfWheels, string inputColor)
        {
            _modelNumber = modelNumber;
            _model = model;
            _year = year;
            _numberOfWheels = numberOfWheels;
            Color = inputColor;
        }

        // public int GetModelNumber()
        // {
        //     return _modelNumber;
        // }

        // public void SetModelNumber(int modelNumber)
        // {
        //     _modelNumber = modelNumber;
        // }

        public int ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is moving with the speed of 20 KM/h");
        }
    }
}