using System;
using Component;
namespace Components
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Full Size Car";
            Price = 10000;
        }
        public override double GetBasePrice() => Price;

        public override double GetCarPrice() => Price;

        public override string GetDescription() => Description;
        
    }
}
