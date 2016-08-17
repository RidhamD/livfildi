using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sideLength;            
            do
            {
                Console.Write("Введите длину стороны треугольника: ");
                if (int.TryParse(Console.ReadLine(), out sideLength))
                    break;

                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
                
            }
            while (true);
                        
            int height;
            do
            {
                Console.Write("Введите длину высоты проведенной к этой стороне: ");
                if (int.TryParse(Console.ReadLine(), out height))
                    break;

                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
            }
            while (true);

            float area = CalculateTriangleArea(sideLength, height);
            Console.WriteLine("Площадь треугольника со стороной '{0}' и высотой '{1}', равняется '{2}'", sideLength, height, area);
            Console.Read();
        }

        private static float CalculateTriangleArea(int sideLength, int height)
        {             
             return 0.5f * sideLength * height;        
        }
    }
}
