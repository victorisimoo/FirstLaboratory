using System;

namespace ConsoleTest.Elements
{
    class Number
    {
        public int value { get; set; }

        public static Comparison<Number> CompareByValue = delegate (Number NumberOne, Number NumberTwo) {
            return NumberOne.value.CompareTo(NumberTwo.value);
        };
    }
}
