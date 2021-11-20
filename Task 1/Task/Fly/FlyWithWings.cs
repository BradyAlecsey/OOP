using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class FlyingWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("*полёт с использованием крыльев*");
        }
    }
}