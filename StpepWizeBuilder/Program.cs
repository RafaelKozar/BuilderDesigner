// See https://aka.ms/new-console-template for more information
var car = CarBuilder.Create()
    .OfType(CarType.Crossover)
    .WithWheels(18)
    .Build();

Console.WriteLine(car);



