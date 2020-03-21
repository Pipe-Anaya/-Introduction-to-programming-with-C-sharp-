using System;

namespace ConsoleApp
{
    class Tetraedro
    {
    private double Area;
    public void tetraedro(double Area)
    {
        this.Area=Area;
    }
    public double volumen()
    {
        return Math.Pow((Math.Pow(Area,3)/2),2);
    }
    }
}