using System;
using System.Collections.Generic;
using CustomGenerics.Structure;
using System.Text;
using ConsoleTest.Elements;

namespace ConsoleTest.Services
{
    class Storage
    {
        //Instance element
        private static Storage _instance = null;

        //Method for instance
        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }
        public RangeTree<Number> rangeTree;
    }
}
