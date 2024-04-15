using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car : Vehicle
    {
        public Car(string marka, string model, int year, int passengerCapacity) : base(marka, model, year)
        {
            PassengerCapacity = passengerCapacity;
        }
        public int PassengerCapacity { get; set; }
    }
}
