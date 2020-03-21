namespace ConsoleApp
{
    class Cuadrado : InterfaFigurasPlanasConLados
    {
        private float Lado;

        public Cuadrado(float Lado)
        {
            this.Lado = Lado;
        }

        public float area()
        {
            return this.Lado * this.Lado;
        }

        public float perimetro()
        {
            return this.Lado * 4;
        }
    }
}