using System;
using Component;
namespace Components
{
    public class SportsVehicle : Car
    {
        public SportsVehicle()
        {
            Description = "Sports Utility Vehicle";
            Price = 50000;
        }
        public override double GetBasePrice() => Price;
        public override string GetDescription() => Description;
        public override double GetCarPrice() => Price;
    }
}
