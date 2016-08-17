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
            Console.WriteLine("Введите длину стороны треугольника: ");
            int sideLength;
            bool checkInput =  int.TryParse(Console.ReadLine(), out sideLength);
            while (checkInput == false)
            {
                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
                checkInput = int.TryParse(Console.ReadLine(), out sideLength);
            }

            Console.WriteLine("Введите длину высоты проведенной к этой стороне: ");
            int height;
            checkInput = int.TryParse(Console.ReadLine(), out height);
            while (checkInput == false)
            {
                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
                checkInput = int.TryParse(Console.ReadLine(), out height);
            }
                      
            float area = calculateTriangleArea(sideLength, height);
            Console.WriteLine("Площадь треугольника со стороной '{0}' и высотой '{1}', равняется '{2}'", sideLength, height, area);
            Console.ReadKey();
        }

          static float calculateTriangleArea(int sideLength, int height)
        {
             float s;
             return s = 0.5f*sideLength * height;        
        }
    }
}
