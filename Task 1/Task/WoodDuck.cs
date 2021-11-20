using System;
using System.Collections.Generic;
using System.Text;
using Task.Swim;

namespace Task
{
    class WoodDuck : Duck
    {
        public WoodDuck()
            : base(new NoFly(), new NoQack(), new NotSwimable())
        { }
    }
}