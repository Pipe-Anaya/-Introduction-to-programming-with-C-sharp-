using System;

namespace ConsoleApp
{
    class ProgramaAdivinaElNumero : InterfazPrograma 
    {
        private int NumeroAleatorio;
        private Random Aleatorio;

        public ProgramaAdivinaElNumero()
        {
            this.Aleatorio = new Random();
        }

        public void ejecutar()
        {

            Console.WriteLine("¡Bienvenido a adivina el numero!");
            Console.WriteLine("Ingrese el límite para escojer un número aleatorio, mínimo debe ser cien, de lo contrario se tomará cien como valor");

            int numeroInicial = 1;
            int limite = int.Parse(Console.ReadLine());

            if (limite < 99) { limite = 100; }

            NumeroAleatorio = Aleatorio.Next(numeroInicial, limite);

            int intentosDisponibles = 7;
            bool banderaJugar = true;

            while (banderaJugar != false)
            {
                if (intentosDisponibles == 0) { 
                    banderaJugar = false;
                    Console.WriteLine("¡Se han acabado los intentos!");
                    Console.WriteLine($"El número es: {NumeroAleatorio}");
                    return; 
                }

                intentosDisponibles -= 1;

                Console.WriteLine($"Ingrese un número del {numeroInicial} al {limite}");
                int numeroUsuario = int.Parse(Console.ReadLine());

                Console.WriteLine($"Te quedan {intentosDisponibles} intentos");

                if (NumeroAleatorio > numeroUsuario)
                {
                    Console.WriteLine("Es mayor");
                    numeroInicial = numeroUsuario;
                } else if (NumeroAleatorio < numeroUsuario) {
                    Console.WriteLine("Es menor");
                    limite = numeroUsuario;
                } else {
                    Console.WriteLine("¡Felicidades has ganado el juego!");
                    banderaJugar = false;
                }
            }
        }
    }
}
    