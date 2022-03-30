using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //------------------------------ Dot Notation (instantiating, then assigning values to properties)
            var jillCar = new Car();
            jillCar.Year = 2014;
            jillCar.Make = "Toyota";
            jillCar.Model = "Camry";
            jillCar.EngineNoise = "loud on highway, quiet on creep";
            jillCar.HonkNoise = "honk!";
            jillCar.IsDriveable = true;

            parkingLot.Cars.Add(jillCar);

            //------------------------------ Object Initializer Syntax (assigning properties at time of instantiation)
            var benCar = new Car()
            {
                Year = 2018,
                Make = "Tesla",
                Model = "Model 3",
                EngineNoise = "zoom zoom",
                HonkNoise = "HOOOONNKKKK!",
                IsDriveable = true
            };

            parkingLot.Cars.Add(benCar);

            //------------------------------- Constructor (in-line instantiating with constructor)
            var davidCar = new Car(1993, "Chevy", "Cheyenne", "lurba lurba lurba", "AIR HORN!", false);

            parkingLot.Cars.Add(davidCar);

            Console.WriteLine("Jill's Car goes: ");
            jillCar.MakeEngineNoise(jillCar.EngineNoise);
            jillCar.MakeHonkNoise(jillCar.HonkNoise);

            Console.WriteLine("Ben's Car goes: ");
            benCar.MakeEngineNoise(benCar.EngineNoise);
            benCar.MakeHonkNoise(benCar.HonkNoise);

            Console.WriteLine("David's Car goes: ");
            davidCar.MakeEngineNoise(davidCar.EngineNoise);
            davidCar.MakeHonkNoise(davidCar.HonkNoise);



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("The cars in the parking lot are: ");
            foreach (var car in parkingLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

        }
    }
}
