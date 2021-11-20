using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class RubberDuckQack : IQackBehavior
    {
        public void Qack()
        {
            Console.WriteLine("Резиновая уточка весело покрякивает в ванной с пузырьками)");
        }
    }
}