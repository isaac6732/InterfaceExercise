using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; } = true;
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfWheels { get; set; } = 4;
        public string Color { get; set; }
        public int Brakes { get; set; }
        public bool Engine { get; set; } = true;
        public string Logo { get; set; }
        public string ExclusiveName { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Has Trunk{HasTrunk}");
            Console.WriteLine($"Number Of Doors{NumberOfDoors}");
            Console.WriteLine($"Number Of Wheels {NumberOfWheels}");
            Console.WriteLine($"Color {Color}");
        }
        
    }
}
