using System;
using System.Collections.Generic;
using System.Text;
using Task.Swim;

namespace Task
{
    class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyingWithWings(), new DuckQack(), new Swimable())
        { }
    }
}
