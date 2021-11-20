using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Coffe
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.descriptoins = descriptoins + "Dark roast\nAdditions: non";
        }
        public override int Cost()
        {
            return 18;
        }
    }
}
