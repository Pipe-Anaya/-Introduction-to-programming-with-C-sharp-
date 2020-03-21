
namespace ConsoleApp
{
    class Piramide
    {
        private double AreaBase;
        private double Altura;
        public void piramide(double AreaBase,double Altura)
        {
            this.AreaBase=AreaBase;
            this.Altura=Altura;
        }  
        public double Volumen()
         {
         return (AreaBase*Altura)/3; 
         }
    }
}