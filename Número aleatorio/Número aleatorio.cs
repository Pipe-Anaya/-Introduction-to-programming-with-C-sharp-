using System;
using MayorDeTresNumeros;

namespace Numero_Aleatorio
{
    internal class Program
    {
        static bool RetoCumplido = false;
        public static void Main(string[] args)
        {

            int NumeroA = 0;

            var Aleatorio = new Random();
            
            Utlis.DrawMenssaje("Bienvenido a : divina el numero!");

            Utlis.DrawMenssaje("ingrese una de los 10 niveles dificultad");

            int NivelD = Int32.Parse(Console.ReadLine());

            switch (NivelD)
            {
                case 1:
                    NumeroA = Aleatorio.Next(1, 100);
                    break;
                case 2:
                    NumeroA = Aleatorio.Next(1, 1000);
                    break;
                case 3:
                    NumeroA = Aleatorio.Next(1, 10000);
                    break;
                case 4:
                    NumeroA = Aleatorio.Next(1, 100000);
                    break;
                case 5:
                    NumeroA = Aleatorio.Next(1, 1000000);
                    break;
                case 6:
                    NumeroA = Aleatorio.Next(1, 10000000);
                    break;
                case 7:
                    NumeroA = Aleatorio.Next(1, 100000000);
                    break;
                case 8:
                    NumeroA = Aleatorio.Next(1, 1000000000);
                    break;
                case 10:
                    NumeroA = Aleatorio.Next(-1000000000, 1000000000);
                    break;
                 default:
                     Utlis.ErrorMenssaje("inggrese un numero valido");
                     break;
            }

            if (NumeroA != 0)
            {
                reto(NumeroA);
                Utlis.DrawMenssaje("GANADOR!"); 
                Utlis.DrawMenssaje("ERES INCREIBLE!");
                Utlis.DrawMenssaje($"Reto n°{NivelD} completado");
            }

            
            Console.ReadKey();
        }
        static void reto(int NumeroA)
        {
            int NumU = 0;
            bool salida = false;
            while (salida == false)
            { 
             Utlis.DrawMenssaje("Ingrese un numero");
             NumU = Int32.Parse(Console.ReadLine());
             if (NumU < NumeroA)
             {
                 Utlis.ErrorMenssaje("El numero aleatorio es mayor a el numero ingresado");
             }else if (NumU > NumeroA)
             {
                 Utlis.ErrorMenssaje("El numero aleaatorio es menor a el numero ingresado");
             }else
             { 
                 Utlis.DrawMenssaje("CORRECTO!");
                 RetoCumplido = true;
                 salida = true;
             }
            }
        }
    }
}
    