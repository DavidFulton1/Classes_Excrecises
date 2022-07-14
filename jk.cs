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
       
        Car car1=new Car();
        Car car2=new Car();
        Car car3=new Car();
            car1.Make = "Toyota";
            car1.Model = "Corola";
            car1.Year = 1997;
            car1.EngineNoise = "not cool";
            car1.HonkNoise = "boring";
            car1.IsDrivable= false;

            car2.Year = 2010;
            car2.Make = "Ford";
            car2.Model = "Escort";
            car2.EngineNoise = "normal";
            car2.HonkNoise = "normal";
            car2.IsDrivable = true;

            car3.Year = 1969;
            car3.Make = "Pontiac";
            car3.Model = "GTO";
            car3.EngineNoise = "cool";
            car3.HonkNoise = "cool";
            car3.IsDrivable = true;


            Car.MakeEngineNoise(car1.EngineNoise);
            Car.MakeEngineNoise(car2.EngineNoise);
            Car.MakeEngineNoise(car3.EngineNoise);


            Car.MakeHonkNoise(car1.HonkNoise);
            Car.MakeHonkNoise(car2.HonkNoise);
            Car.MakeHonkNoise(car3.HonkNoise);


        }


    }
}
