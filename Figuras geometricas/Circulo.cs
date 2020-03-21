using System;

namespace ConsoleApp
{
    class Circulo
    {
        private float Radio;

        public Circulo(float Radio)
        {
            this.Radio = Radio;
        }

        public float area()
        {
            float PIxRadio = (float)Math.PI * Radio;
            return PIxRadio * PIxRadio;
        }

        public float circunferencia()
        {
            return (Radio * 2) * (float)Math.PI;
        }
    }
}
