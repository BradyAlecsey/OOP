﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Additions
{
    class Soy : Additions
    {
        Beverage decorator;
        string info = "";
        public Soy(Beverage beverage)
        {
            this.decorator = beverage;
        }
        public override int Cost()
        {
            return decorator.Cost() + 3;
        }
        public override string GetDescriptions()
        {
            info = this.decorator.GetDescriptions();
            info = info.Substring(0, info.Length - 3);
            return info + "soy;    ";
        }
    }
}
