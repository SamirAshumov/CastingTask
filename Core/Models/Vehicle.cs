using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vehicle
    {
        private static int _id;
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle(string marka, string model, int year)
        {
            _id++;
            Id= _id;
            this.Marka = marka;
            this.Model = model;
            this.Year = year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id} Marka: {Marka} - Model:  {Model} - Il : {Year}");
        }
    }
}
