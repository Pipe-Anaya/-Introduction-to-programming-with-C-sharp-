using System;

namespace MayorDeTresNumeros
{
    public static class Utlis
    {
        public static void ErrorMenssaje(string menssaje)
        {
            Console.WriteLine("                              .............         ");
            Console.WriteLine("                           .:|||||||||||||||:.      ");
            Console.WriteLine("                     ´´´´ |    ) |    ) |****| |    )");
            Console.WriteLine("                    |---- |****  |****  |    | |**** ");
            Console.WriteLine("                     ____ |    | |    | |....| |    |");
            Console.WriteLine("                --@@@@----------:  :----------@@@@--");
            Console.WriteLine($"                 {menssaje}");   
        }
        public static void DrawMenssaje(string message)
             {
                 Console.WriteLine("                               ......               ");
                 Console.WriteLine("                            .:||||||||:.            ");
                 Console.WriteLine("                           |            |           ");
                 Console.WriteLine("                          (   o      o   )          ");
                 Console.WriteLine("                --@@@@----------:  :----------@@@@--");
                 Console.WriteLine($"                 {message}");
             }
    }
}

   
    
