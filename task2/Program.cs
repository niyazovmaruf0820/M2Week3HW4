using task2;

CargoCar cargoCar = new CargoCar("Fura",10000,100000, 350, true, 10, 100);
PassengerCar passengerCar = new PassengerCar("Lamborgini",10000,100000, 150, true, 4, 10000);
CargoPlane cargoPlane = new CargoPlane("Fura",100000,1000000, 1500, true, 4, 700);
PassengerPlane passengerPlane = new PassengerPlane("Fura",10000,100000, 150, true, 10, 10);
System.Console.WriteLine(cargoCar.Info());
System.Console.WriteLine("----------------------------");
System.Console.WriteLine(cargoPlane.Info());
System.Console.WriteLine("----------------------------");
System.Console.WriteLine(passengerCar.Info());
System.Console.WriteLine("----------------------------");
System.Console.WriteLine(passengerPlane.Info());
System.Console.WriteLine("----------------------------");
