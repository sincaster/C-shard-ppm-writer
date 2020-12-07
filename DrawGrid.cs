using System;

namespace dotnet
{
    public class GridClass
    {
        public void DrawGrid()
        {
            const int wInt = 512;
            const int hInt = 512;
            
            double wDouble = Convert.ToDouble(wInt);
            double hDouble = Convert.ToDouble(hInt);
            
            Console.WriteLine("P3\n" + wInt + " " + hInt + "\n255\n");
            
            for (int i = hInt - 1; i >= 0; --i)
                for (int k = 0; k < wInt; ++k)
                {
                    double x = Convert.ToDouble(i);
                    double y = Convert.ToDouble(k);
                    
                    double r = x / (wDouble - x);
                    double g = y / (hDouble + y);
                    double b = 0.75;
                    
                    // grayscale
                    int ir = Convert.ToInt32(255.999 * Math.Sqrt(r)) << i - 1;
                    int ig = Convert.ToInt32(255.999 * Math.Sqrt(g)) << k - 1;
                    int ib = Convert.ToInt32(255.999 * b);
                    
                    double grey = (ir + ig + ib) / 3;
                    
                    int igrey = Convert.ToInt32(grey);
                    
                    Console.WriteLine(igrey + " " + igrey + " " + igrey);
                }
                Console.WriteLine("\n");
        }
    }
}