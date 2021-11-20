using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Additions
{
    class Whip : Additions
    {
        Beverage decorator;
        string info = "";
        public Whip(Beverage beverage)
        {
            this.decorator = beverage;
        }
        public override int Cost()
        {
            return decorator.Cost() + 4;
        }
        public override string GetDescriptions()
        {
            info = this.decorator.GetDescriptions();
            info = info.Substring(0, info.Length - 3);
            return info + "whip;    ";
        }
    }
}
