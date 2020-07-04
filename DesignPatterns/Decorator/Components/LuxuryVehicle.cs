using System;
using Component;
namespace Components
{
    public class LuxuryVehicle : Car
    {
        public LuxuryVehicle()
        {
            Description = "Luxury Car";
            Price = 40000;
        }
        public override double GetBasePrice() => Price;
        public override string GetDescription() => Description;
        public override double GetCarPrice() => Price;
    }
}
