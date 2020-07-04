using System;
using Component;
namespace Components
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Compact Car";
            Price = 10000;
        }
        public override double GetBasePrice() => Price;
        public override string GetDescription() => Description;

        public override double GetCarPrice() => Price;
    }
}
