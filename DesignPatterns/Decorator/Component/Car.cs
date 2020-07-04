using System;

namespace Component
{
    public abstract class Car
    {
        
        public string Description { get; set; }
        public double Price { get; set; }
        public abstract string GetDescription();
        public abstract double GetBasePrice();
        public abstract double GetCarPrice();
    }
}
