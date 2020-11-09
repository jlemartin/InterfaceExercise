using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 2.0;
        public string Model { get; set; } = "Generic";
        public int SeatCount { get; set; } = 4;
        public bool HasCDPlayer { get; set; }
        public string CompanyName { get ; set ; }
        public string Motto { get ; set ; }
        public bool HasChangedGears { get; set; } = false;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
            Console.WriteLine($"{GetType().Name} now in Park");
                HasChangedGears = false;
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("can't reverse until we change gears");
            }
        }
    }
}
