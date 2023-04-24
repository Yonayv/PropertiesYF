using System;

namespace PropertiesYF
{
    class Program
    {

        /// <summary>
        /// each Car is created with a new car object which allows us to access the Car.ss
        /// The car is assgigned to its make, where you can set the value.
        /// each car value has its own unique set value
        /// the console.writeline projects the set value back to the Car.se
        /// </summary>
        /// <param name="args"> </param>
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
