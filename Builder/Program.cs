using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder builder = new();
Director director = new (builder);

director.ConstructSedanCar();
Vehicle sedanCar = builder.GetVehicle();
Console.WriteLine($"Criado um veículo do tipo: {sedanCar.VehicleType}, {sedanCar.Seats} assentos, transmissão {sedanCar.Transmission} e motor {sedanCar.Engine.Power}");
Console.WriteLine(sedanCar.Airbags ? "com aibags" : "sem airbags");
Console.WriteLine();

director.ConstructTruck();
Vehicle truck = builder.GetVehicle();
Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}, {truck.Seats} assentos, transmissão {truck.Transmission} e motor {truck.Engine.Power}");
Console.WriteLine(truck.Airbags ? "com aibags" : "sem airbags");
Console.WriteLine();

director.ConstructSUV();
Vehicle suv = builder.GetVehicle();
Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType}, {suv.Seats} assentos, transmissão {suv.Transmission} e motor {suv.Engine.Power}");
Console.WriteLine(suv.Airbags ? "com aibags" : "sem airbags");
Console.WriteLine();

Console.ReadLine();