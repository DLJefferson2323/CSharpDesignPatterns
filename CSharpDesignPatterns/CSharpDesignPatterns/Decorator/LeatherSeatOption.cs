using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    class LeatherSeatOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 50.00m;  }
        } // end method override decimal price
        public LeatherSeatOption(IBicycle bicycle)
            : base(bicycle) { }
    } // end class
} // end namespace
