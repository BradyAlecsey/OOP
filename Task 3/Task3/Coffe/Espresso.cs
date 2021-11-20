using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            this.descriptoins = descriptoins + "Espresso\nAdditions: non";
        }
        public override int Cost()
        {
            return 10;
        }
    }
}
