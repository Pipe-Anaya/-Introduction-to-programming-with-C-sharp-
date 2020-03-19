namespace ConsoleApp
{
    class Triangulo
    {
        private float _base;
        private float altura;

        public Triangulo(float _base, float altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public float area()
        {
            return (_base * altura) / 2;
        }
        public float perimetro()
        {
            return _base + (altura * 2);
        }
    }
}
