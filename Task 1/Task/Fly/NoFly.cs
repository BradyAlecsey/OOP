using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("*полёт невозможен*");        
        }
    }
}