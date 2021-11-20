using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class NoQack : IQackBehavior
    {
        public void Qack()
        {
            Console.WriteLine("Оно неиздаёт ни звука");
        }
    }
}
