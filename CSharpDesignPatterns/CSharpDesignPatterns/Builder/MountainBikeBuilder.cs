using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class MountainBikeBuilder : AbstractBikeBuilder
    {
        /* Class object of AbstractMountainBike is assigned by the constructor and retrieved
        by the property Bicycle */

        private AbstractMountainBike _mountainBikeInProgress;

        /* Property of MountainBikeBuilder used to return an object of IBicycle.
         This object is of type AbstractMountainBike that implements the IBicycle
         interface */

        public override IBicycle Bicycle
        { get { return _mountainBikeInProgress; } }

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        } // end method Mountain Bike Builder

        // Methods below are overridden from the AbstractBikeBuilder
        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires");
        } // end method override build street tires
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handle Bars");
        } // end method override build handle bars
    } // end class
} // end namespace
