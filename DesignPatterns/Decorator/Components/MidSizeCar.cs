using System;
using Component;
namespace Components
{
    public class MidSizeCar : Car
    {
        public MidSizeCar()
        {
            Description = "Mid Size Car";
            Price = 20000;
        }
        public override double GetBasePrice() => Price;
        public override string GetDescription() => Description;
        public override double GetCarPrice() => Price;
    }
}
