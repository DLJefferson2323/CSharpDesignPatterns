using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class DownHill : AbstractMountainBike
    {
        public override decimal Price { get; } = 860.00m;

        public DownHill (BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public DownHill (IWheel wheel)
            : this(BikeColor.Black, wheel) { }
    } // end class
} // end namespace
