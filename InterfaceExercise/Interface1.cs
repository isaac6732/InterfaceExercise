using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int Brakes { get; set; }
        public bool Engine { get; set; }

        public void DisplayDetails();

    }

    
}
