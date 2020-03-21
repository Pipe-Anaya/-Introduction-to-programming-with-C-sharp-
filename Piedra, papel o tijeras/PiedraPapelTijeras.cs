using System;

namespace ConsoleApp
{
    internal class ProgramaPiedraPapelTijeras : InterfazPrograma
    {
        private Random Aleatorio;
        public ProgramaPiedraPapelTijeras()
        { 
        this.Aleatorio = new Random();
        }
        public void ejecutar()
        {
            string maquina = "";
            int numeroAleatorio = Aleatorio.Next(1,3);
            int gadasUsuario = 0;
            int ganadasMaquina = 0;
            int round = 0;
            while (gadasUsuario < 3 || ganadasMaquina < 3)
            {
                round++;
                if (round == 1)
                {
                    Console.WriteLine("Bienvenido a piedra papel o tijeras");
                }

                Console.WriteLine("Ingrese piedra  papel o tijeras");
                string usuario = Console.ReadLine();
                switch (numeroAleatorio)
                {
                    case 1:
                        maquina = "piedra";
                        break;
                    case 2:
                        maquina = "papel";
                        break;
                    case 3:
                        maquina = "tijeras";
                        break;
                }
                if(usuario!="piedra"&&usuario!="papel"&&usuario!="tijeras")
                {
                    Console.WriteLine("Entrada ingresada no valida intente nuevamente");
                }
                else if (usuario == "piedra"&& maquina == "tijeras"||
                         usuario == "papel" && maquina == "piedra" ||
                         usuario == "tijeras" && maquina == "papel")
                {
                    Console.WriteLine($"Ronda n°{round} ganada");

                    gadasUsuario++;

                    if (gadasUsuario == 3)
                    {
                        Console.WriteLine("¡GANADOR!");

                        Console.WriteLine($"Ganaste en {round}, feliciades");

                      return;
                    }
                }
                else if (usuario == "piedra" && maquina == "papel" ||
                         usuario == "papel" && maquina == "tijeras"||
                         usuario == "tijeras" && maquina == "piedra")
                {
                    Console.WriteLine($"Ronda n°{round} perdida");

                    ganadasMaquina++;

                    if (ganadasMaquina==3)
                    {

                     Console.WriteLine($"Has perdido en la ronda n°{round}, ganador maquina"); 

                     return;
                    }
                }
                else
                {
                    Console.WriteLine($"Ronda n°{round} empatada");
                }
            }
        }
    }
}