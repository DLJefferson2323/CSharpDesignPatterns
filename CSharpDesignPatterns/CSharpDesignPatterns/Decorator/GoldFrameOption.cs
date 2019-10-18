using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class GoldFrameOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 1000.00m;  }
        } // end method override decimal price
        public GoldFrameOption(IBicycle bicycle)
            : base(bicycle) { }

    } // end class
} // end namespace
