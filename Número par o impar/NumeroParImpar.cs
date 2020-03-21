using System;

namespace ConsoleApp
{
    internal class NumeroParImpar : InterfazPrograma
    {
        public void ejecutar()
        {
            Console.WriteLine("Ingrese 1  valor por teclado");
            int x = Convert.ToInt32(
            Console.ReadLine()
            );
            int y = x % 2;
            if (y != 0)
            {
                Console.WriteLine("Tu numero es impar");
            }
            else
            {
                Console.WriteLine("Tu numero es par");
            }

        }
    }
}