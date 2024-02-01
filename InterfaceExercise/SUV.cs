using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; } = 2;
        public int HP { get; set; } = 800;
        public int NumberOfWheels { get; set; } = 4;
        public string Color { get; set; }
        public int Brakes { get; set; } = 4;
        public bool Engine { get; set; } = true;
        public string Logo { get; set; }
        public string ExclusiveName { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Horse Power{HP}");
            Console.WriteLine($"Number Of Seats{NumberOfSeats}");
            Console.WriteLine($"Number Of Wheels {NumberOfWheels}");
            Console.WriteLine($"Color {Color}");
        }
    }
}
