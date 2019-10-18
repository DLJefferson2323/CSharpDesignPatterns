using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class WhiteTiresOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 80.00m;  }
        } // end override method decimal price
        public WhiteTiresOption(IBicycle bicycle)
            : base(bicycle) { }

    } // end class
} // end namespace
