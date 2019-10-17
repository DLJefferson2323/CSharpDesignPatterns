using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class Touring : AbstractRoadBike
    {
        public override decimal Price { get; } = 840.00m;

        public Touring (BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public Touring (IWheel wheel)
            : this(BikeColor.Midnight_Blue, wheel) { }
    } // end class
} // end namespace
