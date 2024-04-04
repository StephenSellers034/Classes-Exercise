using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2020;

            Car myCar1 = new Car()
            {
                Make = "Tesla",
                Model = "Model 3",
                Year = 2019
            };

            Car myCar2 = new Car("BMW", "i5", 2025);

            var carList = new List<Car>() { myCar, myCar1, myCar2 };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }

        }
    }
}
