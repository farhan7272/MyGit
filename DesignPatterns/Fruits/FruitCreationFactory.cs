using FruitInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    public class FruitCreationFactory : IFruitCreation
    {
        public FruitCreationFactory()
        {

        }
        public IFruit GetFruit(string FruitName)
        {
            switch (FruitName.ToLower())
            {
                case "apple":
                    return new Apple();
                case "orange":
                    return new Orange();
                default:
                    return null;
            }
        }
    }
}
