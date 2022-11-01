using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carLot = new CarLot();
            //Create a seperate class file called Car - DONE!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Dot Notation

            Car car1 = new Car();
            car1.Year = 2016;
            car1.Make = "Mazda";
            car1.Model = "CX-5";
            car1.EngineNoise = "Zoom zoom";
            car1.HonkNoise = "beeeeeep!";
            car1.IsDrivable = true;

            carLot.ParkingLot.Add(car1);

            //Onject Initializer Syntax
            var car2 = new Car() { Year = 2013, Make = "Ford", Model = "Focus", EngineNoise = "errrrrrr, errrrrrrrrr", HonkNoise = "beep", IsDrivable = false };

            carLot.ParkingLot.Add(car2);

            //Custom constructor

            var car3 = new Car(2022, "Ford", "Explorer", "Vroom!", "Loud Beep!", true);

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHornNoise(car1.HonkNoise);

            car2.MakeEngineNoise("problem, problem");
            car2.MakeHornNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHornNoise(car3.HonkNoise);

            carLot.ParkingLot.Add(car3);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var vehicle in carLot.ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.MakeEngineNoise(vehicle.EngineNoise);
                vehicle.MakeHornNoise(vehicle.HonkNoise);
                Console.WriteLine();
            }
        }
    }
}
