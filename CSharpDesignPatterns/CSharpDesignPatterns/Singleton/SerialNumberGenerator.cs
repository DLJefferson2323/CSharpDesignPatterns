using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        private static object sychronizationRoot = new object();
        private int _count = 64789;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(sychronizationRoot)
                        if(instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        } // end second if
                } // end if
                return instance;
            } // end get
        } // end method static serial number generator

        private SerialNumberGenerator() { }
        
        public int NextSerial { get  { return ++_count;  }  }

    } // end class
} // end namespace
