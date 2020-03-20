using System;

namespace ConsoleApp
{
    class ProgramaMayorDeTresNumeros : InterfazPrograma
    {
        private int[] numeros = new int[3];

        public void ejecutar()
        {

            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            
            if (numeros[0] == numeros [1] && numeros[0] == numeros[2])
            {
                Console.WriteLine("¡Todos son iguales!");
                return;
            }

            if (numeros[0] > numeros[1] && numeros[0] > numeros[2]) {
                Console.WriteLine($"El mayor es {numeros[0]}");
            } else if (numeros[1] > numeros[2] && numeros[1] > numeros[0]) {
                Console.WriteLine($"El mayor es {numeros[1]}");
            } else {
                Console.WriteLine($"El mayor es {numeros[2]}");
            }
        }
    }
}