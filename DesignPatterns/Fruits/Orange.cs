using FruitInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    class Orange : IFruit
    {
        public string Name { get; set; } 
        public string Color { get; set; } 


        public Orange()
        {
            Name = "I am Orange";
            Color = "My color is Orange too. He he";
        }
    }
}
