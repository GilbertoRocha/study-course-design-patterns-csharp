
using Builder;
using Builder.Builders;
using Builder.Products;

VehicleBuilder builder = new VehicleBuilder();
Director director = new Director(builder);

director.ConstructSedanCar();

Vehicle sedan = builder.GetVehicle();

Console.WriteLine($"Criado um veiculo : {sedan.VehicleType}");

director.ConstructTruck();
Vehicle truck = builder.GetVehicle();

Console.WriteLine($"Criado um veiculo : {truck.VehicleType}");

director.ConstructSUV();
Vehicle suv = builder.GetVehicle();

Console.WriteLine($"Criado um veiculo : {suv.VehicleType}");