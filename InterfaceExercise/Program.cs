using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values



            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            List<IVehicle> list = new List<IVehicle>();

            Car car = new Car()
            {
                HasTrunk = true,
                Color = "Red",
                Brakes = 4,
                NumberOfWheels = 4,
                Logo = "Srr"
            };
            Truck truck = new Truck()
            {
                NumberOfDoors = 2,
                Color = "Red",
                Brakes = 2,
                NumberOfWheels = 10,
                Logo = "Tk"
            };
            SUV sUV = new SUV()
            {
                NumberOfSeats = 2,
                Color = "Red",
                Brakes = 2,
                NumberOfWheels = 10,
                Logo = "SV"

            };

            car.DisplayDetails();
            Console.WriteLine( );

            truck.DisplayDetails();
            Console.WriteLine( );

            sUV.DisplayDetails();



        }

            
    }
}
