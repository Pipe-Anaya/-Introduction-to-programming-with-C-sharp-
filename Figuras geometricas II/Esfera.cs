using System;
namespace ConsoleApp
{
    class Esfera
    {
        private double Radio;
        public void esfera(double Radio)
        {
        this.Radio=Radio;
        }
        public double volumen()
        {
            return (Math.PI*Radio)*3;
        }
    }
}