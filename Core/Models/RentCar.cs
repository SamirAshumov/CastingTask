using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        public Vehicle[] _vehicles = new Vehicle[0];

        public Truck[] _trucks = new Truck[0];

        public Car[] _cars = new Car[0];
        public int CarLimit { get; set; }
        public int TruckLimit { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                if (_cars.Length < CarLimit)
                {

                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = (Car)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car limit asilmisdir!");
                }
            }

            else if (vehicle is Truck)
            {
                if (_trucks.Length < TruckLimit)
                {

                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = (Truck)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Truck limit asilmisdir!");
                }
            }
        }

        public void ShowAllVehicles()
        {
           
            for (int i = 0;  i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is Car)
                {
                    var car = (Car)_vehicles[i];

                    Console.WriteLine($"{car.Id} {car.Marka} {car.Model} Year: {car.Year} [Passenger Capacity]: {car.PassengerCapacity}");
                }

                else if (_vehicles[i] is Truck)
                {
                    var truck = (Truck)_vehicles[i];

                    Console.WriteLine($"{truck.Id} {truck.Marka} {truck.Model} Year: {truck.Year} [Carrying Capacity]: {truck.CarryingCapacity}");
                }
            }
        }
    }
}