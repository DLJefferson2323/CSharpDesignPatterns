using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class CustomGripOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        } // end method decimal price
        public CustomGripOption(IBicycle bicycle)
            : base(bicycle) { }
    } // end class
} // end namespace
