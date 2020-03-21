
namespace ConsoleApp
{
    class Prisma
    {
        private double AreaBase, Altura;
        public void prisma(double AreaBase,double Altura)
        {
        this.AreaBase=AreaBase;
        this.Altura=Altura;
        }
        public double Volumen()
        {
            return AreaBase*Altura;
        }
    }
}