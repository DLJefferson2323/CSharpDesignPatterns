using CSharpDesignPatterns.Base;
using CSharpDesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Facade
{
    public class BikeFacade
    {
        public void PrepareForSale(IBicycle bicycle)
        {
            Registration reg = new Registration(bicycle);
            reg.AllocateBikeNumber();

            Documentation.PrintBrochure(bicycle);

            bicycle.CleanFrame();
            bicycle.AirTires();
            bicycle.TestRide();
        } // end method prepare for sale
    } // end class
} // end namespace
