using CSharpDesignPatterns.Base;
using CSharpDesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Facade
{
    public class Registration
    {
        private IBicycle _bicycle;

        public Registration(IBicycle bike)
        {
            this._bicycle = bike;
        } // end method registration

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number "+ SerialNumberGenerator.Instance.NextSerial);
        } // end method allocated bike number
    } // end class
} // end namespace
