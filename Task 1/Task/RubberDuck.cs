using System;
using System.Collections.Generic;
using System.Text;
using Task.Swim;

namespace Task
{
    class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new NoFly(), new RubberDuckQack(), new Swimable())
        { }
    }
}