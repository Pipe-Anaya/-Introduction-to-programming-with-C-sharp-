using System;

namespace ConsoleApp
{
    class Index
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el número del programa que quiere ejecutar.");
                Console.WriteLine("[1] para figuras geométricas planas");
                Console.WriteLine("[2] para el mayor de tres números");
                Console.WriteLine("[3] para jugar adivina el número");
                Console.WriteLine("[4] para piedra, papel o tijeras");
                Console.WriteLine("[5] para la calculadora");
                Console.WriteLine("[6] para número par o impar");
                Console.WriteLine("[7] para HOLA MUNDO");
                Console.WriteLine("[8] para figuras geometricas no planas");
                Console.WriteLine("[0] para salir del programa");
                string programa = Console.ReadLine();

                switch (programa)
                {
                    case "1":
                        ProgramaFigurasGeometricas programaFigurasGeometricas
                        = new ProgramaFigurasGeometricas();

                        programaFigurasGeometricas.ejecutar();
                        break;
                    case "2":
                        ProgramaMayorDeTresNumeros programaMayorDeTresNumeros
                        = new ProgramaMayorDeTresNumeros();

                        programaMayorDeTresNumeros.ejecutar();
                        break;
                    case "3":
                        ProgramaAdivinaElNumero programaAdivinaElNumero
                        = new ProgramaAdivinaElNumero();

                        programaAdivinaElNumero.ejecutar();
                        break;
                    case "4":
                        ProgramaPiedraPapelTijeras programaPiedraPapelTijeras
                        = new ProgramaPiedraPapelTijeras();

                        programaPiedraPapelTijeras.ejecutar();
                        break;
                    case "5":
                        ProgramaCalculadora calculadora
                        = new ProgramaCalculadora();

                        calculadora.ejecutar();
                        break;
                    case "6":
                        NumeroParImpar numeroParImpar
                        = new NumeroParImpar();

                        numeroParImpar.ejecutar();
                        break;
                    case "7":
                        HolaMudo holamudo
                        = new HolaMudo();

                        holamudo.ejecutar();
                        break;
                    case "8":
                        ProgramaFigurasGeometricasNoPlanas programaFigurasGeometricasNoPlanas
                        = new ProgramaFigurasGeometricasNoPlanas();

                        programaFigurasGeometricasNoPlanas.ejecutar();
                        break;
                    case "0":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La entrada es inválida.");
                        break;
                }
            }
        }
    }
}
