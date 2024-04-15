using Core.Models;
namespace CastingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentCar rentcar = new RentCar();
            rentcar.CarLimit = 4;
            rentcar.TruckLimit = 3;

            Car car1 = new Car("BMW","X5", 2023, 5);
            Car car2 = new Car("Hyundai", "Tucson", 2015, 5);
            Car car3 = new Car("Kia", "Rio", 2019, 5);
            Car car4 = new Car("Hyundai", "Sonata", 2018, 5);

            

            rentcar.AddVehicle(car1);
            rentcar.AddVehicle(car2);
            rentcar.AddVehicle(car3);
            rentcar.AddVehicle(car4);

            Truck truck1 = new Truck("Ford", "Ranger", 2012, 985);
            Truck truck2 = new Truck("Toyota", "Tacoma", 2016, 765);
            Truck truck3 = new Truck("Nissan", "Frontier", 2014, 735);

            rentcar.AddVehicle(truck1);
            rentcar.AddVehicle(truck2);
            rentcar.AddVehicle(truck3);


            rentcar.ShowAllVehicles();

            
        }
    }
}
