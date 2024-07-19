using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var cars = new CarLot();
            
            Car firstCar = new Car();
            Console.WriteLine($"After creating first car, number of cars in lot is: {CarLot.NumberOfCars}");
            firstCar.Year = 2020;
            firstCar.Make = "Toyota";
            firstCar.Model = "Corolla";
            firstCar.EngineNoise = "Vroom";
            firstCar.HonkNoise = "Awooga";
            firstCar.IsDrivable = false;

            cars.CarList.Add(firstCar);

            Car secondCar = new Car()
            {
                Year = 2023,
                Make = "Honda",
                Model = "Accord",
                EngineNoise = "Purr",
                HonkNoise = "Beep Beep",
                IsDrivable = true,
            };
            
            Console.WriteLine($"After creating second car, number of cars in lot is: {CarLot.NumberOfCars}");
            cars.CarList.Add(secondCar);

            var thirdCar = new Car()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Roadster",
                EngineNoise = "Whir",
                HonkNoise = "Blare",
                IsDrivable = true,
            };
            Console.WriteLine($"After creating third car, number of cars in lot is: {CarLot.NumberOfCars}");
            
            cars.CarList.Add(thirdCar);
            
            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            firstCar.MakeHonkNoise(firstCar.HonkNoise);
            
            Console.WriteLine("-----------------");
            
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);
            
            Console.WriteLine("-----------------");
            
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);
            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            Console.WriteLine("-----------------");
            Console.WriteLine("Cars in the lot:");
            foreach (var c in cars.CarList)
            {
               Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
            }
        }
    }
}
