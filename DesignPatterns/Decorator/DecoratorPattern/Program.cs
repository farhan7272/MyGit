using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;
using ConcreteDecorator;
using Component;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = string.Empty;
            do
            {
                Console.WriteLine("Enter the car type. C for Compact.F for FullSize.L for Luxury.M for Midsize. S for Sports");
                var cartype = Console.ReadLine();
                switch (cartype.ToLower().Trim())
                {
                    case "c":
                        Console.WriteLine("you have selected Compact");
                        Car car = new CompactCar();
                        GetCarTrim(car);
                        break;
                    case "f":
                        Console.WriteLine("you have selected Full Size");
                        Car fullSizeCar = new FullSizeCar();
                        GetCarTrim(fullSizeCar);
                        break;
                    case "l":
                        Console.WriteLine("you have selected Luxury");
                        Car luxuryVehicle = new LuxuryVehicle();
                        GetCarTrim(luxuryVehicle);
                        break;
                    case "m":
                        Console.WriteLine("you have selected Mid Size");
                        Car midSizeCar = new MidSizeCar();
                        GetCarTrim(midSizeCar);
                        break;
                    case "s":
                        Console.WriteLine("you have selected Sports");
                        Car sportsVehicle = new SportsVehicle();
                        GetCarTrim(sportsVehicle);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to try more car prices. y for yes. n for no");
                ans = Console.ReadLine();

            } while (ans == "y");
        }

        private static void GetCarTrim(Car car)
        {
            var ansTrim = string.Empty;
            do
            {
                Console.WriteLine("Enter the Trim.L For Leather.N for Navigation.S for Sunroof");
                var trim = Console.ReadLine();
                switch (trim.ToLower().Trim())
                {
                    case "l":
                        Console.WriteLine("you have selected leather seats");
                        car = new LeatherSeats(car);
                        break;
                    case "n":
                        Console.WriteLine("you have selected navigation");
                        car = new Navigation(car);
                        break;
                    case "s":
                        Console.WriteLine("you have selected sunroof");
                        car = new Sunroof(car);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Description : {car.GetDescription()}");
                Console.WriteLine($"Car Base Price :{car.GetBasePrice():C2}");
                Console.WriteLine($"Car Final Price: {car.GetCarPrice():C2}");
                Console.WriteLine("Want to add more trim");
                ansTrim = Console.ReadLine();
            } while (ansTrim.ToLower().Trim() == "y");
        }
    }
}
