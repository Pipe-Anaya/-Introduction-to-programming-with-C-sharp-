using System;

namespace ConsoleApp
{
    class Icosaedro
    {
        private double Area;
        public void icosaedro(double Area)
        {
            this.Area=Area;
        }
      public double Volumen()
      {
          return ((5*(Math.Pow(Area,3)))*(3+(Math.Sqrt(5))))/12;
      }
    }
}