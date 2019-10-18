using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public abstract class AbstractBikeBuilder
    {
        // Property of the IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }
        
        /* Methods below are virtual which means optionally overwritten -override- in a child*/
        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandleBars() { }
    } // end class
} // end namespace
