using System;
using Task.Swim;

namespace Task
{
    class Program
    {
        static void Main()
        {
            var mallardDuck = new MallardDuck();
            var rubberDuck = new RubberDuck();
            var woodDuck = new WoodDuck();

            Console.WriteLine("Рыжая утка:");
            mallardDuck.Display();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Резиновая уточка:");
            rubberDuck.Display();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Деревянная игрушка утки:");
            woodDuck.Display();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Попытка убить резиновую уточку:");
            rubberDuck.Dead();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("28 ударов ножом по рыжей уточке спустя:");
            mallardDuck.Dead();
            mallardDuck.Fly();
            mallardDuck.Qack();
            mallardDuck.Swim();
        }
    }
}