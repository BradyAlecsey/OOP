using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.getInstanse();
            boiler.fill();
            boiler.check();
            boiler = ChocolateBoiler.getInstanse();
            boiler.check();
            boiler.boil();
            boiler.drain();
        }
    }
}
