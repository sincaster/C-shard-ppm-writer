using System;
using System.Numerics;

namespace dotnet
{
    class PolyClass
    {
//        public int InterpolateX();
//        public int InterpolateY();
    
/*
        public class Ray
        {
            public Vector3 origin()
            {
                return orig;
            }
            
            public Vector3 direction()
            {
                return dir;
            }
            
            public Vector3 at(float t) 
            {
                return orig + (t * dir);
            }
            
            public Ray(Vector3 origin, Vector3 direction) : base(origin, direction) {}
            
            public Vector3 orig, dir;
        }
        
        public int DrawColor(Ray ray)
        {
            Vector3 unitDirection = ray.direction() / ray.direction().Length();
            return Convert.ToInt32(Vector3 unitDirection = ray.direction() / ray.direction().Length());
            
        }
*/
        
//        ImgProperties Img = new ImgProperties();
        
        // an x and y coordinate for each point (note that there are 3 points: A, B and C)
        public void DrawPoly(int x1, int x2, int x3, int y1, int y2, int y3, int limit)
        {
            for (int x = 0; x <= limit; ++x)
                for (int y = 0; y <= limit; --y)
                {
                    double r = Convert.ToDouble(x + y);
                    double g = Convert.ToDouble(y - x);
                    double b = -0.75;
                    
                    int ir = Convert.ToInt32(255.999 * r);
                    int ig = Convert.ToInt32(255.999 * b);
                    int ib = Convert.ToInt32(255.999 * g);
                    
                    Console.WriteLine(ir + " " + ig + " " + ib);
                }
                Console.WriteLine("\n");
        }
    }
}