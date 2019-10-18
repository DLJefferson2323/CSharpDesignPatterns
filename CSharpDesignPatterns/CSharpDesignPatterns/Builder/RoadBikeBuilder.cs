using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class RoadBikeBuilder : AbstractBikeBuilder
    {
        /* Class object of AbstractRoadBike is assigned by the constructor and retrieved
         by the property Bicycle */

        private AbstractRoadBike _roadBikeInProgress;

        /* Property of RoadBikeBuilder used to return an object of IBicycle.
         This object is of type AbstractRoadBike that implements the IBicycle
         interface */

        public override IBicycle Bicycle
        {  get { return _roadBikeInProgress; }  }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        } // end method Road Bike Builder

        // Methods below are overridden from the AbstractBikeBuilder
        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires");
        } // end method override build street tires
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handle Bars");
        } // end method override build handle bars

    } // end class
} // end namespace
