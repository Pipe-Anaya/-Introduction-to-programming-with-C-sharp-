﻿using System;

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
                Console.WriteLine("[0] para salir del programa");
                string programa = Console.ReadLine();

                switch (programa)
                {
                    case "1":
                        ProgramaFigurasGeometricas programaFigurasGeometricas = new ProgramaFigurasGeometricas();
                        programaFigurasGeometricas.ejecutar();
                        break;
                    case "2":
                        ProgramaMayorDeTresNumeros programaMayorDeTresNumeros = new ProgramaMayorDeTresNumeros();
                        programaMayorDeTresNumeros.ejecutar();
                        break;
                    case "3":
                        ProgramaAdivinaElNumero programaAdivinaElNumero = new ProgramaAdivinaElNumero();
                        programaAdivinaElNumero.ejecutar();
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
