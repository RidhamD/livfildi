using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int h;
           
            Console.WriteLine("Введите длину стороны треугольника: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину высоты проведенной к этой стороне: ");
            h = int.Parse(Console.ReadLine());
            Area(a, h);         
            
            Console.ReadKey();
        }

          static void Area(float a, float h)
        {
             float s;
             s = 0.5f*a * h;
             Console.WriteLine(s);
        }
    }
}
