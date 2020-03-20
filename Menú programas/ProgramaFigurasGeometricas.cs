using System;

namespace ConsoleApp
{
    class ProgramaFigurasGeometricas : InterfazPrograma
    {

        public void ejecutar()
        {
            while ( true )
            {
                Console.WriteLine("[1] Para el área o perímetro del cuadrádo");
                Console.WriteLine("[2] Para el área o perímetro del triángulo");
                Console.WriteLine("[3] para el area de un circulo");
                Console.WriteLine("[0] Para regresar al menú principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el valor del lado");
                        float lado = float.Parse(Console.ReadLine());

                        Cuadrado cuadrado = new Cuadrado(lado);

                        Console.WriteLine($"El perímetro es: {cuadrado.perimetro()}");
                        Console.WriteLine($"El área es: {cuadrado.area()}");
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el valor de la base");
                        float _base = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el valor del segundo lado");
                        float altura = float.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(_base, altura);

                        Console.WriteLine($"El perímetro es: {triangulo.perimetro()}");
                        Console.WriteLine($"El área es: {triangulo.area()}");

                        break;
                    case "3":
                        Console.WriteLine("Ingrese el valor del radio");
                        float radio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(radio);

                        Console.WriteLine($"La circunferencia es {circulo.circunferencia()}");
                        Console.WriteLine($"El área es: {circulo.area()}");
                        break;
                    case "0":
                        Index.Main();
                        break;
                    default:
                        Console.WriteLine("La entrada es inválida");
                        break;
                }
            }
        }
    }
}
