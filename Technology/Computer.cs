using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Technology
{
    public class Computer
    {
        //Ram and Storage are measured in GB as that is the standard for modern storage
        //(practice for real work)
        //Print statements must reflect GB
        //Can add method for conversions if necessary.
        //RamInMB, StorageMB, RamInBytes, etc. can be added as needed and be calculated inline
        public Double Ram { get; set; }
        public Double Storage { get; set; }
        protected internal String Name { get; }

        public const string Company = "Apple";

        public Computer(Double ram, Double storage, String name)
        {
            this.Ram = ram;
            this.Storage = storage;
            this.Name = name;
        }

        public void AddRam(int addGB)
        {
            Ram += addGB;
            return;
        }
        public  void AddStorage(int addGB)
        {
            Storage += addGB;
        }
    }
}
