using MayorDeTresNumeros;
using System;
namespace area_y_perimetro_de_un_triangulo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Utlis.DrawMenssaje("Ingrese 3 los lados de su triangulo");
            int l1 = Convert.ToInt32(
            Console.ReadLine()
            );
            int l2 = Convert.ToInt32(
            Console.ReadLine()
            );
            int l3 = Convert.ToInt32(
            Console.ReadLine()
            );
            int p = l1 + l2 + l3; 
            Utlis.DrawMenssaje($"El perimetro de su triangulo es: {p}");
            if (l1==l2 && l2==l3)
            {
             Utlis.DrawMenssaje("Y el triangulo es equilatero");   
            }else if (l1!=l2&&l1==l3||l2!=l1&&l2==l3||l3!=l2&&l2==l1)
            {
             Utlis.DrawMenssaje("Y su triangulo es isosceles");   
            }
            else
            {
                Utlis.DrawMenssaje("Y su triangulo es escaleno");
            }
            Utlis.DrawMenssaje("Ingrese primero la base y luego la altura");
            int b = Convert.ToInt32(
                Console.ReadLine()
            );
            int h = Convert.ToInt32(
                Console.ReadLine()
            );
            int x = b*h;
            int a = x/2;
            Utlis.DrawMenssaje($"El area de su triangulo es: {a}");
            Console.ReadKey();
        }
    }
}