using System;

namespace ConsoleApp
{
    class Octaedro
    {
    private double Area;
     public void octaedro(double Area)
     {
     this.Area=Area;
     }
     public double volumen()
     {
         return Math.Pow((Math.Pow(Area,3)/3),2);
     }
    } 
}