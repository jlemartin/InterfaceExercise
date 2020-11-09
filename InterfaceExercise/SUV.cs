using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }

        public double EngineSize { get ; set ; }
        public string Model { get ; set ; }
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get ; set ; }
        public bool HasFourWheelDrive { get; set; } = true;
        public int CargoSize { get; set; }
        public string CompanyName { get ; set ; }
        public string Motto { get ; set ; }

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
