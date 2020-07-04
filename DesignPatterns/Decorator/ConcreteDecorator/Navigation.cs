using System;
using Component;
using Decorator;

namespace ConcreteDecorator
{
    public class Navigation : CarDecorator
    {
        public Navigation(Car car): base(car)
        {
            Description = "Navigation";
        }
        public override double GetCarPrice() => _car.GetCarPrice() + 5000;

        public override string GetDescription() => $"{_car.GetDescription()},{Description}";
        
    }
}
