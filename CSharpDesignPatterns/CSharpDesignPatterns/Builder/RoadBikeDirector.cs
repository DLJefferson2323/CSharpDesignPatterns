using System;
using System.Collections.Generic;
using System.Text;
using CSharpDesignPatterns.Base;

namespace CSharpDesignPatterns.Builder
{
    public class RoadBikeDirector : AbstractBikeDirector
    {
        public override IBicycle Build(AbstractBikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildStreetTires();
            return builder.Bicycle;
        }
    } // end class
} // end namespace
