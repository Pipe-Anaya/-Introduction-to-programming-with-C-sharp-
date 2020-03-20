using System;

namespace utlis
{
    public class Utlis
    {
        public static int ReadMenssajeNum(int x,string menssaje)
        {
            while(x!=0)
            {
                try
                {
                    Console.WriteLine(menssaje);
                    x = Int32.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Ha ocurrido un error, intente nuevamente");
                }
            }
            return x;
        }
        public static string ReadMenssajeString(string x,string menssaje)
        {
            while (x != "")
            {
                try
                {
                    Console.WriteLine(menssaje);
                    x = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error, intente nuevamente");
                }
            }
            return x;   
        }
        public static double ReadMenssajeNumDouble(double x, string menssaje)
        {
            while (x != 0.0)
            {
                try
                {
                    Console.WriteLine(menssaje);
                    x =double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error, intente nuevamente");
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
   
    
