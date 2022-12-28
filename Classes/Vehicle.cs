using System;

namespace Program
{
    public class Vehicle
    {
        private int _modelNumber;
        private string _model;
        private int _year;
        private int _numberOfWheels;

        public Vehicle(int modelNumber, string model, int year, int numberOfWheels)
        {
            _modelNumber = modelNumber;
            _model = model;
            _year = year;
            _numberOfWheels = numberOfWheels;
        }

        public int GetModelNumber()
        {
            return _modelNumber;
        }

        public void SetModelNumber(int modelNumber)
        {
            _modelNumber = modelNumber;
        }
    }
}