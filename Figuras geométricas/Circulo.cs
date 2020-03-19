using System;

namespace ConsoleApp
{
    class Circulo
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float area()
        {
            float PIxRadio = (float)Math.PI * radio;
            return PIxRadio * PIxRadio;
        }

        public float circunferencia()
        {
            return (radio * 2) * (float)Math.PI;
        }
    }
}
