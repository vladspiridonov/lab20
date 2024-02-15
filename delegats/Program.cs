using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegats
{
    class Program
    {
        delegate double MyDelegado(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r =Convert.ToDouble(Console.ReadLine());
            if (r < 0)
                Console.WriteLine("\nЯ такое не буду считать");
            else
            {
                Console.Write("L=");
                MyDelegado myDelegado = Length;
                double l = myDelegado(r);
                Console.WriteLine(l);
                Console.Write("S=");
                myDelegado = Area;
                double s = myDelegado(r);
                Console.WriteLine(s);
                Console.Write("V=");
                myDelegado = Volume;
                double v = myDelegado(r);
                Console.WriteLine(v);
            }
                Console.ReadKey();       

        }
        static double Length (double r)
        {
            double length = 2 * Math.PI * r;
            return length;            
        }
        static double Area (double r)
        {
            double area = Math.PI * r*r;
            return area;
        }
        static double Volume(double r)
        {
            double volume = 4/(double)3*Math.PI * r * r*r;
            return volume;
        }
    }
}
