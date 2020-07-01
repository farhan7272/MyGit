using FruitInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    public class Apple : IFruit
    {
        public string Name { get; set; } 
        public string Color { get; set; } 

        public Apple()
        {
            Name = "I am Apple";
            Color = "Apple is red in color";
        }
    }
}
