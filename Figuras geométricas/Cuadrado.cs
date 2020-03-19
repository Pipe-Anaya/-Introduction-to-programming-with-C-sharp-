namespace ConsoleApp
{
    class Cuadrado
    {
        private float lado;

        public Cuadrado(float lado)
        {
            this.lado = lado;
        }

        public float area()
        {
            return this.lado * this.lado;
        }

        public float perimetro()
        {
            return this.lado * 4;
        }
    }
}