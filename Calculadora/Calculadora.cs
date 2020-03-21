using System;

namespace ConsoleApp

{

    public class ProgramaCalculadora : InterfazPrograma
    { 
        public void ejecutar()
        {
            int resultado = 0;
         Console.WriteLine("Ingrese 1  valor por teclado");
         int num1 = Convert.ToInt32(
         Console.ReadLine()
         );
         Console.WriteLine("Ingrese atro valor");
         int num2 = Convert.ToInt32(
         Console.ReadLine()
         );
         Console.WriteLine("Ingrese 1 para + 2 para - 3 para * y 4 para / ");
         int Operacion = Convert.ToInt32(
         Console.ReadLine()
         );
         switch (Operacion)
             {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ingrese un valor valido");
                    break;
             }
                Console.WriteLine($"El resultdo es : {resultado}");
        }
    }
}