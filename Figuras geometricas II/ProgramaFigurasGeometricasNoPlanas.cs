using System;

namespace ConsoleApp
{
    class ProgramaFigurasGeometricasNoPlanas : InterfazPrograma
    {
        public void ejecutar()
        {
            int opcion;
            int area,altura;
            int radio;
            Console.WriteLine("[1] para el volumen del cubo");
            Console.WriteLine("[2] para el volumen del prisma");
            Console.WriteLine("[3] para el volumen de la piramide");
            Console.WriteLine("[4] para el volumen de la esfera");
            Console.WriteLine("[5] para el volumen del cilindro");
            Console.WriteLine("[6] para el volumen del tetraedro");
            Console.WriteLine("[7] para el volumen del dodecaedro");
            Console.WriteLine("[8] para el volumen del icosaedro");
            Console.WriteLine("[0] para volver al menú principal");
            opcion = Int32.Parse(
            Console.ReadLine()
            );
            switch(opcion)
            {
                case 1:
                    Cubo cubo = new Cubo();
                    Console.WriteLine("Ingrese el área del cubo");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    cubo.cubo(area);
                    Console.WriteLine($"El volumen del cubo  es: " +
                    $"{cubo.volumen()}");
                    break;
                case 2:
                    Prisma prisma = new Prisma();
                    Console.WriteLine("Ingrese el área de la base del prisma");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    Console.WriteLine("Ingrese la altura");
                    altura = Int32.Parse(
                    Console.ReadLine()
                    );
                    prisma.prisma(area, altura);
                    Console.WriteLine($"El volumen del cubo es: " +
                    $"{prisma.Volumen()}");
                    break;
                case 3:
                    Piramide piramide = new Piramide();
                    Console.WriteLine("Ingrese el área de la base de la piramide");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    Console.WriteLine("Ingrese la altura de la piramide");
                    altura = Int32.Parse(
                    Console.ReadLine()
                    );
                    Console.WriteLine($"El volumen de la piramide es: " +
                    $"{piramide.Volumen()}");
                    break;
                case 4:
                    Esfera esfera = new Esfera();
                    Console.WriteLine("Ingrese el radio de la esfera");
                    radio = Int32.Parse(
                    Console.ReadLine()
                    );
                    esfera.esfera(radio);
                    Console.WriteLine($"El volumen de la piramide es: " +
                    $"{esfera.volumen()}");
                    break;
                case 5:
                    Cilindro cilindro = new Cilindro();
                    Console.WriteLine("Ingrese el radio de la base del cilindro");
                    radio = Int32.Parse(
                    Console.ReadLine()
                    );
                    Console.WriteLine("Ingrese la altura del cilindro");
                    altura = Int32.Parse(
                    Console.ReadLine()
                    );
                    cilindro.cilindro(radio, altura);
                    Console.WriteLine($"El volumen del cilindro es: " +
                    $"{cilindro.Volumen()}");
                    break;
                case 6:
                    Tetraedro tetraedro = new Tetraedro();
                    Console.WriteLine("Ingrese el área del tetraedro");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    tetraedro.tetraedro(area);
                    Console.WriteLine($"El volumen del tetraedro es: " +
                    $"{tetraedro.volumen()}");
                    break;
                case 7:
                    Dodecaedro dodecaedro = new Dodecaedro();
                    Console.WriteLine("Ingrese el área del dodecaedro");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    dodecaedro.dodecaedro(area);
                    Console.WriteLine($"El volumen del odecaedro es: " +
                    $"{dodecaedro.Volumen()}");
                    break;
                case 8:
                    Icosaedro icosaedro = new Icosaedro();
                    Console.WriteLine("Ingrese el área del icosaedro");
                    area = Int32.Parse(
                    Console.ReadLine()
                    );
                    icosaedro.icosaedro(area);
                    Console.WriteLine($"El volumen del icosaedro es: " +
                    $"{icosaedro.Volumen()}");
                    break;
                case 0:
                    Index.Main();
                    break;
                default:
                    Console.WriteLine("La entrada es inválida"); 
                    break;
            }
        }
            
    }
}