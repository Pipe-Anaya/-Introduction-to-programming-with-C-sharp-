using System;

namespace ConsoleApp
{
    class Dodecaedro
    {
        private double Area;
        public void dodecaedro(double Area)
        {
        this.Area=Area;
        }
        public double Volumen()
        {
            return (Math.Pow(Area,3)*(15+7*(Math.Sqrt(5)))/4);
        }
    }
}