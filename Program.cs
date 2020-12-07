using System;

namespace dotnet
{   
    public class ImgProperties
    {	
        static int wInt = 512;
        static int hInt = 512; 
        
        double wDouble = Convert.ToDouble(wInt);
        double hDouble = Convert.ToDouble(hInt);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            GridClass Grid = new GridClass();
            Grid.DrawGrid();
            
            PolyClass Poly = new PolyClass();
            Poly.DrawPoly(50, 25, 75, 5, 30, 30, 30);
        }
    }
}
