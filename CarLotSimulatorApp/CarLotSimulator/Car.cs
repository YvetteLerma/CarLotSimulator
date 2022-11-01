using System;
namespace CarLotSimulator
{
    public class Car
    {
        //Default constructor
        public Car()
        {
            CarLot.numberOfCars++;
            //ClassName.StaticMember
        }

        //Custom cunstructor
        public Car ( int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"This car goes {engineNoise}");
        }
        public void MakeHornNoise(string hornNo)
        {
            Console.WriteLine($"This car horn makes a {hornNo} noise.");
        }
    }
}

