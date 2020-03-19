using System;

namespace utlis
{
    public class Utlis
    {
        public static int ReadMenssaje(int x,string menssaje)
        {
            while(x!=0)
            {
                try
                {
                    console.writeline(menssaje);
                    x = int32.parse(console.readline());
                }
                catch(Exception e)
                {
                    console.writeline("Ha ocurrido un error, intente nuevamente");
                }
            }
            return x;
        }
        public static void ErrorMenssaje(string menssaje)
        {
            Console.WriteLine("                              .............         ");
            Console.WriteLine("                           .:|||||||||||||||:.      ");
            Console.WriteLine("                    ´´´´ |    ) |    ) |****| |    )");
            Console.WriteLine("                   |---- |****  |****  |    | |**** ");
            Console.WriteLine("                    ____ |    | |    | |....| |    |");
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
                 Console.WriteLine($"                {message}");
             }
    }
}
   
    
