using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot lot = new CarLot();


            Car fCar = new Car();
            lot.CarList.Add(fCar);
            fCar.Year = 2021;
            fCar.Make = "Toyota";
            fCar.Model = "Corolla";
            fCar.EngineNoise = "Breem";
            fCar.HonkNoise = "Beep beep";
            fCar.IsDrivable = true;

            fCar.MakeEngineNoise();
            fCar.MakeHonkNoise();


            Car sCar = new Car() { Year = 1997, Make = "Ford", Model = "Corolla", EngineNoise = "Broom broom", HonkNoise = "Doesn't work", IsDrivable = false };
            lot.CarList.Add(sCar);

            sCar.MakeEngineNoise();
            sCar.MakeHonkNoise();

            Car tCar = new Car(2017, "Jeep", "Wrangler", "Vroom vroom", "Meep meep", true);
            lot.CarList.Add(tCar);

            tCar.MakeEngineNoise();
            tCar.MakeHonkNoise();

            Console.WriteLine("-------------");


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} {car.EngineNoise} {car.HonkNoise} {car.IsDrivable}");
            }
        }
    }
}
