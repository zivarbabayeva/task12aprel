using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Milk: Product
    {
        public string Name;
        public double Price; 
    }
    public Milk(double volume, double fatRate)
    {
        Volume = volume;
        FatRate = fatRate;
    }
}
