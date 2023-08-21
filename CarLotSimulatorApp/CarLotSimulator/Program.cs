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

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Car car1 = new Car(2003, "Honda", "Civic", "vroom", "beep", true);
            Car car2 = new Car(2003, "Honda", "Civic", "vroom", "beep", true);
            Car car3 = new Car(2006, "Chevrolet", "Suburban", "vroom", "getOutOfMYWay", true);

            car1.MakeEngineNoise("Hiss");
            car1.MakeHonkNoise("beeeep");
            car2.MakeEngineNoise("Hiss");
            car2.MakeHonkNoise("beeeep");
            car3.MakeEngineNoise("Hiss");
            car3.MakeHonkNoise("beeeep");

            Car car4 = new Car()
            {
                Year = 2003,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "vroom",
                HonkNoise = "beeeep",
                IsDriveable = false
            };

            Car car5 = new Car();
            car5.Year = 2010;
            car5.Make = "TOyota";
            car5.IsDriveable = true;
            car5.Model = "Corolla";
            car5.EngineNoise = "TickTock";
            car5.HonkNoise = "Aooga";

            //car lost stuff
            CarLot cLot = new CarLot();
            cLot.cars.Add(car1);
            cLot.cars.Add(car2);
            cLot.cars.Add(car3);
            cLot.cars.Add(car4);
            cLot.cars.Add(car5);

            foreach (Car c in cLot.cars) {
                Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
            }

        }
    }
}
