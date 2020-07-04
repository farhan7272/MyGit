using System;
using Component;

namespace Decorator
{
    public class CarDecorator : Car
    {
        protected Car _car;       
        public CarDecorator(Car car)
        {
            _car = car;
        }
        public override double GetBasePrice() => _car.GetBasePrice();

        public override string GetDescription() => _car.GetDescription();

        public override double GetCarPrice() => _car.GetCarPrice();

    }
}
