using System;
using Task3.Coffe;
using Task3.Additions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DarkRoast+Milk+Whip
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescriptions()}\nCost:{darkRoast.Cost()}\n ");
            //HouseBlend+Soy+whip
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescriptions()}\nCost:{houseBlend.Cost()}\n ");
            //Espresso+all addishion
            Beverage espresso = new Espresso();
            espresso = new Soy(espresso);
            espresso = new Whip(espresso);
            espresso = new Milk(espresso);
            espresso = new Mocha(espresso);
            Console.WriteLine($"{espresso.GetDescriptions()}\nCost:{espresso.Cost()}\n ");
            Console.ReadLine();
        }
    }
}
