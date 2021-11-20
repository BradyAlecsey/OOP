using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Swim
{
    class Swimable : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Оно уверенно держиться на воде");
        }
    }
}