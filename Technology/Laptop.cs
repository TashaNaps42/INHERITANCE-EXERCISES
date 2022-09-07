using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        //measured in lbs because America is inferior to those using metric sys
        readonly Double Weight;

        public Laptop (Double weight, Double ram, Double storage, String name): base(ram, storage, name)
        {
            Weight = weight;
        }

        public bool tooHeavy()
        {
            if (Weight >= 5.0)
            {
                Console.WriteLine("This laptop is too heavy, back to the drawing board!");
                return true;
            } else
            {
                Console.WriteLine("This laptop is going to market!");
                return false;
            }
        }
    }
}
