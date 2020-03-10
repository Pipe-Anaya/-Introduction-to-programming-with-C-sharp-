using System;

namespace MayorDeTresNumeros
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var CLASS_UTLIS = new utlis();
            CLASS_UTLIS.DrawMenssaje("Ingrese 1 valor por teclado");
            int num1 = Convert.ToInt32(
                Console.ReadLine()
                );
            CLASS_UTLIS.DrawMenssaje("Ingrese atro valor");
            int num2 = Convert.ToInt32(
                Console.ReadLine()
                );
            CLASS_UTLIS.DrawMenssaje("Ingrese atro valor");
            int num3 = Convert.ToInt32(
                Console.ReadLine()
                );
            if ( num1 == num2 && num2 == num3 ) {
                CLASS_UTLIS.DrawMenssaje("Son iguales :3");
            } else { 
                if (num1 > num2 && num1 >= num3) {
                    CLASS_UTLIS.DrawMenssaje("El mayor es el primero");
                } else if (num2 > num3 && num2 >= num1) {
                    CLASS_UTLIS.DrawMenssaje("El mayor es el segundo");
                } else {
                    CLASS_UTLIS.DrawMenssaje("El mayor es el tercero");  
                }
            }
            Console.ReadKey();
        }
    }
}