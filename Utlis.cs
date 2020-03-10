using System;

namespace MayorDeTresNumeros
{
    public class utlis
    {
        public void ErrorMenssaje(string menssaje)
        {
            Console.WriteLine("                              .............         ");
            Console.WriteLine("                           .:|||||||||||||||:.      ");
            Console.WriteLine("                     ---- |    ) |    ) |****| |    )");
            Console.WriteLine("                    |---- |****  |****  |    | |**** ");
            Console.WriteLine("                     ---- |    | |    | |....| |    |");
            Console.WriteLine("                --@@@@----------:  :----------@@@@--");
            Console.WriteLine($"                             {menssaje}");   
        }
        public void DrawMenssaje(string message)
             {
                 Console.WriteLine("                               ......               ");
                 Console.WriteLine("                            .:||||||||:.            ");
                 Console.WriteLine("                           |            |           ");
                 Console.WriteLine("                          (   o      o   )          ");
                 Console.WriteLine("                --@@@@----------:  :----------@@@@--");
                 Console.WriteLine($"                            {message}");
             }
    }
}
   
    
