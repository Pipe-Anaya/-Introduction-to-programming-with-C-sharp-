namespace ConsoleApp
{
    class Triangulo : InterfaFigurasPlanasConLados
    {
        private float Base;
        private float Altura;

        public Triangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public float area()
        {
            return (Base * Altura) / 2;
        }
        public float perimetro()
        {
            return Base + (Altura * 2);
        }
    }
}
