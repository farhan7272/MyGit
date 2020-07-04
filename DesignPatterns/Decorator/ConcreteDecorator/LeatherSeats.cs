using System;
using Component;
using Decorator;

namespace ConcreteDecorator
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car): base(car)
        {
            Description = "Leather Seats";
        }
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;

        public override string GetDescription() => $"{_car.GetDescription()},{Description}";
        
    }
}
