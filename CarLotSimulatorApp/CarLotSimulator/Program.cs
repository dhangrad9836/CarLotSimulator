using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)            
        {

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.            
            var carsInLot = new CarLot();
            

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //3 Car Objects
            var spaceGreyCar = new Car();
            spaceGreyCar.Year = 2022;
            spaceGreyCar.Make = "Toyota";
            spaceGreyCar.Model = "4Runner";
            spaceGreyCar.EngineNoise = "Medium";
            spaceGreyCar.HonkNoise = "Loud";
            spaceGreyCar.IsDriveable = true;

            //check how many cars in lot
            if(Car.numOfCars == 0)
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");

            } else if(Car.numOfCars == 1)

            {
                Console.WriteLine($"There is {Car.numOfCars} car in the lot");
            }
            else
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");
            }

            //add spaceGreyCar to carLot list after spaceGreyCar Car is created
            carsInLot.Cars.Add(spaceGreyCar);

            var blackCar = new Car();
            blackCar.Year = 2024;
            blackCar.Make = "Lexus";
            blackCar.Model = "LS500";
            blackCar.EngineNoise = "Minimum";
            blackCar.HonkNoise = "Loud";
            blackCar.IsDriveable = true;

            //check how many cars in lot
            if (Car.numOfCars == 0)
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");

            }
            else if (Car.numOfCars == 1)

            {
                Console.WriteLine($"There is {Car.numOfCars} car in the lot");
            }
            else
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");
            }

            //add blackCar to carLot list after blackCar Car is created
            carsInLot.Cars.Add(blackCar);

            var whiteCar = new Car();
            whiteCar.Year = 2023;
            whiteCar.Make = "Audi";
            whiteCar.Model = "Q7";
            whiteCar.EngineNoise = "Low";
            whiteCar.HonkNoise = "Loud";
            whiteCar.IsDriveable = true;

            //check how many cars in lot
            if (Car.numOfCars == 0)
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");

            }
            else if (Car.numOfCars == 1)

            {
                Console.WriteLine($"There is {Car.numOfCars} car in the lot");
            }
            else
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //object initialization
            var anotherBlackCar = new Car()
            {
                Year = 2024,
                Make = "Lexus",
                Model = "LS400",
                EngineNoise = "Low",
                HonkNoise = "Loud",
                IsDriveable = true,
            };

            //check how many cars in lot
            if (Car.numOfCars == 0)
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");

            }
            else if (Car.numOfCars == 1)

            {
                Console.WriteLine($"There is {Car.numOfCars} car in the lot");
            }
            else
            {
                Console.WriteLine($"There are {Car.numOfCars} cars in the lot");
            }
            //add anotherBlackCar to carLot list after anotherBlackCar Car is created
            carsInLot.Cars.Add(anotherBlackCar);

            //Using constructor
            var kiaCar = new Car(2024, "Kia", "Telluride", "Medium", "Loud", true);

            //add kiaCar to carLot list
            carsInLot.Cars.Add(kiaCar);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in carsInLot.Cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}, {car.EngineNoise}");
            }

            Console.ReadLine();

        }
    }
}
