using System;

namespace ConsoleApp

{

    public class Calculadora : InterfazPrograma
    {
        public void ejecutar()
        {
            int respuesta = 0; 
                Console.WriteLine("Ingrese 1  valor por teclado");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese atro valor");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese 1 para + 2 para - 3 para * y 4 para / ");
                int nOperacion = Convert.ToInt32(Console.ReadLine());
                switch (nOperacion)
                {
                    case 1:
                        respuesta = x + y;
                        break;
                    case 2:
                        respuesta = x - y;
                        break;
                    case 3:
                        respuesta = x * y;
                        break;
                    case 4:
                        respuesta = x / y;
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;
                }

                if (respuesta != 0)
                {
                Console.WriteLine("El resultdo es : "+respuesta);
                }

        }
    }
}