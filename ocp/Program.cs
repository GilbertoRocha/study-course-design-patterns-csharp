using ocp;

TypeVehicle type = TypeVehicle.CAR;

if (type == TypeVehicle.CAR)
{
	Vehicle vehicle = new Car("Azul", 2022, 2.0, 5, 4);
}
else
{
	Vehicle vehicle = new MotorCycle("Brancho", 2023, 250);
}

