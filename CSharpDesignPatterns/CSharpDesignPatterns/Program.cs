using CSharpDesignPatterns.AbstractFactory;
using CSharpDesignPatterns.Adapter;
using CSharpDesignPatterns.Base;
using CSharpDesignPatterns.Builder;
using CSharpDesignPatterns.Decorator;
using CSharpDesignPatterns.Facade;
using CSharpDesignPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! My name is Argos and I am here to assist you.");
            //AbstractFactoryDemo();
            //BuilderPatternDemo();
            //SingletonPatternDemo();
            //AdapterPatternDemo();
            //DecoratorPatternsDemo();
            FacadePatternDemo();
        }

        static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Vintage(BikeColor.Black, new NarrowWheel(20)));
        } // end method facade pattern demo

        static void DecoratorPatternsDemo()
        {
            IBicycle myMountainBike = new CrossCountry(new WideWheel(30));
            Console.WriteLine(myMountainBike);
            myMountainBike = new CustomGripOption(myMountainBike);
            Console.WriteLine(myMountainBike);
            myMountainBike = new LeatherSeatOption(myMountainBike);
            Console.WriteLine(myMountainBike);
        } // end method decorator pattern demo

 
        static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(28));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(30)));

            foreach(IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            } // end method for each
        } // end method adapter pattern demo

        static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial "+generator.NextSerial);
            Console.WriteLine("next serial "+SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial "+generator.NextSerial);
        } // end method Single Pattern Demo

        static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new DownHill(BikeColor.Black, new WideWheel(25));
            AbstractBikeBuilder builder = new MountainBikeBuilder(mountainBike);
            AbstractBikeDirector director = new MountainBikeDirector();

            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        } // end method build pattern demo

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
