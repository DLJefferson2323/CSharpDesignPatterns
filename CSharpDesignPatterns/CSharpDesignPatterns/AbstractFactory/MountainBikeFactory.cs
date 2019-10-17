using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainFrame();
        } // end method IBikeFrame
        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainSeats();
        } // end method IBikeSeat
    } // end class
} // end namespace
