using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitInterface;
using Fruits;

namespace FruitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            FruitCreationFactory fruitCreationFactory = new FruitCreationFactory();
            IFruit fruity = fruitCreationFactory.GetFruit(fruit.ToString().ToLower().Trim());
            Console.WriteLine(fruity.Name);
            Console.WriteLine(fruity.Color);
            Console.ReadLine();
        }
    }
}
