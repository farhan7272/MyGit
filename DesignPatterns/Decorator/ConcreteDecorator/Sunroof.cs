using System;
using Component;
using Decorator;

namespace ConcreteDecorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car): base(car)
        {
            Description = "Sunroof";
        }
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;

        public override string GetDescription() => $"{_car.GetDescription()},{Description}";
        
    }
}
