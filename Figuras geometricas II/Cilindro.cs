using System;

namespace ConsoleApp
{
    class Cilindro
    {
        private double Radio,Altura;
        public void cilindro(double Radio,double Altura)
        {
            this.Radio=Radio;
            this.Altura=Altura;
        }
        public double Volumen()
        {
            return (Math.PI*Radio)*Altura;
        }
    }
}