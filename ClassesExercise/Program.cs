using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Audi";
            myCar.Model = "A4";
            myCar.Year = 2017;

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");

            var yourCar = new Car();
            {
                yourCar.Make = "Ford";
                yourCar.Model = "Mustang";
                yourCar.Year = 2017;

                Console.WriteLine($"Nice, I have a {yourCar.Year} {yourCar.Make} {yourCar.Model}.");
            }

        }
    }
}

