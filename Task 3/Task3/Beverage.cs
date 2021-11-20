using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class Beverage
    {
        protected string descriptoins = "Name of beverage: ";
        private string myAdditions = null;
        public abstract int Cost();
        public virtual string GetDescriptions()
        {
            return descriptoins;
        }
    }
}
