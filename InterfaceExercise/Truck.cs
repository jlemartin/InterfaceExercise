using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Generic";
        public int SeatCount { get; set; } = 2;
        public int BedSize { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
            Console.WriteLine($"4 wheel drive - {GetType().Name} now driving forward");
            }
            else
            {
            Console.WriteLine($"{GetType().Name} now driving forward");
            }
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
