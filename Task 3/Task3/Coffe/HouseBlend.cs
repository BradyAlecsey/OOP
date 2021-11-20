using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Coffe 
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.descriptoins = descriptoins + "House blend\nAdditions: non";
        }
        public override int Cost()
        {
            return 10;
        }
    }
}
