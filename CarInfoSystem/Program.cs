using CarInfoSystem;

Car car1 = new Car();
car1.Brand = "BMW";
car1.Color = "Siyah";

car1.Start();
car1.Stop();

Car car2 = new Car();
car2.Brand = "Mercedes";
car2.Color = "Beyaz";

car2.Start();
car2.Stop();

Car car3 = new Car();
car3.Start();

Motorcycle motorcycle1 = new Motorcycle();
motorcycle1.Brand = "Honda";

motorcycle1.Start();
motorcycle1.Stop();


IVehicle vehicle1 = new Car();
vehicle1.Start();
vehicle1.Stop();

IVehicle vehicle2 = new Motorcycle();
vehicle2.Start();
vehicle2.Stop();