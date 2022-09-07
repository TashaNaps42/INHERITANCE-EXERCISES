using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Smartphone : Computer
    {
        public int TotalSelfies { get; set; }

        public Smartphone(int totalSelfies, double ram, double storage, string name) : base(ram, storage, name)
        {
            TotalSelfies = totalSelfies;
        }

        public void AddSelfie(int selfie)
        {
            TotalSelfies += selfie;
        }
    }
}
