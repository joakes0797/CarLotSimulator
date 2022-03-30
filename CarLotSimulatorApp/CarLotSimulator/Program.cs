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

            //------------------------------- Constructor (in-line instantiating with constructor)
            var davidCar = new Car(1993, "Chevy", "Cheynne", "lurba lurba lurba", "AIR HORN!", false);


            jillCar.MakeEngineNoise(jillCar.EngineNoise);
            benCar.MakeEngineNoise(benCar.EngineNoise);
            davidCar.MakeEngineNoise(davidCar.EngineNoise);
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
