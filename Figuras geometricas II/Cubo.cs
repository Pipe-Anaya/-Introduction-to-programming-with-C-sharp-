using System;

namespace ConsoleApp
{
    class Cubo
    {
        private double Area;
        public void cubo(double Area)
        {
            this.Area = Area;
        }
        public double volumen()
        {
            return Math.Pow(Area, 3);
        }
    }
} 