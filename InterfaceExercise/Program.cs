using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //In ICompany - DONE
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */


            //Create 3 classes called Car , Truck , & SUV - DONE
            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class - DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE
            //Creatively display and organize their values

            // Car #1
            var camry = new Car();
            camry.CompanyName = "Toyota";
            camry.Model = "Camry";
            camry.HasCDPlayer = true;
            camry.Motto = "Going places";
            camry.SeatCount = 4;

            // Car #2
            var mini = new Car();
            mini.CompanyName = "Cooper";
            mini.Model = "Mini";
            mini.HasCDPlayer = true;
            mini.Motto = "Tiny BMW";
            mini.SeatCount = 2;
            mini.EngineSize = 1.8;

            // Truck #1
            var f150 = new Truck();
            f150.CompanyName = "Ford";
            f150.HasFourWheelDrive = false;
            f150.Model = "F150";
            f150.Motto = "Ford Tough";
            f150.EngineSize = 4.6;
            f150.BedSize = 22;

            // Truck #2
            var silverado = new Truck();
            silverado.CompanyName = "Chevrolet";
            silverado.HasFourWheelDrive = true;
            silverado.Model = "Silverado";
            silverado.Motto = "That's my Chevy";
            silverado.EngineSize = 5.2;
            silverado.BedSize = 26;

            // SUV #1
            var outback = new SUV();
            outback.CompanyName = "Subaru";
            outback.Model = "Outback";
            outback.HasFourWheelDrive = true;
            outback.Motto = "It's a Subaru!";
            outback.EngineSize = 2.0;
            outback.CargoSize = 28;

            // SUV #2
            var rav4 = new SUV();
            rav4.CompanyName = "Toyota";
            rav4.Model = "RAV4";
            rav4.Motto = "Going Places";
            rav4.HasFourWheelDrive = true;
            rav4.EngineSize = 2.5;
            rav4.CargoSize = 24;

            var allVehicles = new List<IVehicle>() { camry, mini, f150, silverado, outback, rav4 };

            foreach (var v in allVehicles)
            {
                Console.WriteLine($"{v.Model}: ");
                v.Drive();
                v.ChangeGears(true);
                v.Reverse();
                v.ChangeGears(true);
                v.Park();
                Console.WriteLine();
            }

            var cars = new List<Car>() { camry, mini };
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.CompanyName} {c.Model} with {c.SeatCount} seats");
                Console.WriteLine($"and an engine size of {c.EngineSize}");
                Console.WriteLine($"{c.Motto}");
                Console.WriteLine();
            }

            var trucks = new List<Truck>() { f150, silverado };
            foreach (var t in trucks)
            {
                Console.WriteLine($"{t.CompanyName} {t.Model} with {t.SeatCount} seats");
                Console.WriteLine($"and an engine size of {t.EngineSize}");
                Console.WriteLine($"{t.Motto}");
                Console.WriteLine();
            }

            var suvs = new List<SUV>() { outback, rav4 };
            foreach (var s in suvs)
            {
                Console.WriteLine($"{s.CompanyName} {s.Model} with {s.SeatCount} seats");
                Console.WriteLine($"and a cargo size of {s.CargoSize}");
                Console.WriteLine($"{s.Motto}");
                Console.WriteLine();
            }

        }
    }
}
