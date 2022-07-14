using Classes_excercise1;
Car car1 = new Car()
{
    Make = "Ford",
    Model = "Ranger",
Year = 2002
};
Car car2 = new Car()
{
    Make = "Honda",
    Model = "Civic",
    Year =2004
};
Car car3 = new Car()
{
    Make = "Chevy",
    Model = "Corvette",
    Year = 2016
};

Console.WriteLine($"{car1.Make}- {car1.Model}- {car1.Year}" );
