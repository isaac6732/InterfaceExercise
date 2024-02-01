using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int HP { get; set; } = 1200;
        public int NumberOfDoors { get; set; } = 2;
        public int NumberOfWheels { get; set; } = 10;
        public string Color { get; set; }
        public int Brakes { get; set; }
        public bool Engine { get; set; } = true;
        public string Logo { get; set; }
        public string ExclusiveName { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Horse Power{HP}");
            Console.WriteLine($"Number Of Doors{NumberOfDoors}");
            Console.WriteLine($"Number Of Wheels {NumberOfWheels}");
            Console.WriteLine($"Color {Color}");
        }
    }
}
