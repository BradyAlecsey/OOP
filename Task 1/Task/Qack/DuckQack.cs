using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class DuckQack : IQackBehavior
    {
        public void Qack()
        {
            Console.WriteLine("Уточка делает *Кря*");
        }
    }
}