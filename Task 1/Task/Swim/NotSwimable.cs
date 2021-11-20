using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Swim
{
    class NotSwimable : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Оно отправилось на дно");
        }
    }
}