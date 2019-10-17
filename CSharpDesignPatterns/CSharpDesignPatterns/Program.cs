using CSharpDesignPatterns.AbstractFactory;
using System;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! My name is Argos and I am here to assist you.");
            AbstractFactoryDemo();
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        } // end method abstract factory demo

    } // end class
} // end namespace
