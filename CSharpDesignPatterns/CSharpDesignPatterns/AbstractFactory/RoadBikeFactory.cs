using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class RoadBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new RoadFrame();
        } // end method IBikeFrame
        public override IBikeSeat CreateBikeSeat()
        {
            return new RoadSeat();
        } // end method IBikeSeat
    } // end class
} // end namespace
