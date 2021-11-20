using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            this.descriptoins = descriptoins + "Decaf\nAdditions: non";
        }
        public override int Cost()
        {
            return 15;
        }
    }
}
