using System;
using utlis;
namespace piedra_papel_o_tijeras
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        
            var aletorio = new Random();
            string maquina = " ";
            int numeroA = aletorio.Next(1,3);
            int gu = 0;
            int gm = 0;
            int i = 0;
            while (gu < 3 || gm < 3)
            {
                i++;
                if (i == 1)
                {
                    Utlis.DrawMenssaje("Bienvenido a piedra papel o tijeras");
                }

                Utlis.DrawMenssaje("Ingrese 1 para piedra 2 para papel y 3 para tijeras");
                int u = Int32.Parse(Console.ReadLine());
                switch (numeroA)
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

                if (u == 1 && maquina == "tijeras" || u == 2 && maquina == "piedra" || u == 3 && maquina == "papel")
                {
                    Utlis.DrawMenssaje($"Ronda n°{i} ganada");
                    gu++;
                    if (gu==3)
                    {
                     Utlis.DrawMenssaje("ganaste 3 veces, quieres salir");
                     string salir = Console.ReadLine();
                     if (salir=="si")
                     {
                         Utlis.DrawMenssaje("GANADOR!");   
                      return;   
                     }
                    }
                }
                else if (u == 1 && maquina == "papel" || u == 2 && maquina == "tijeras" ||
                         u == 3 && maquina == "piedra")
                {
                    Utlis.DrawMenssaje($"Ronda n°{i} perdida");
                    gm++;
                    if (gm==3)
                    {
                     Utlis.DrawMenssaje("perdiste"); 
                     return;
                    }
                }
                else
                {
                    Utlis.DrawMenssaje($"Ronda n°{i} empatada");
                }
            }
            Console.ReadKey();
        }
    }
}