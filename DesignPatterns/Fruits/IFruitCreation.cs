using System;
using System.Collections.Generic;
using System.Text;

namespace FruitInterface
{
    interface IFruitCreation
    {
        IFruit GetFruit(string FruitName);
    }
}
