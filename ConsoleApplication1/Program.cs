using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateAreaFigures;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите необходимую фигуру: \n 1 - Треугольник \n 2 - Четырехугольник \n 3 - Квадрат \n 4 - Выход ");
            int shapeId = ReadNumberInt(); 
            GeneralMenu(shapeId);
            Console.Read();

        }

        public static int ReadNumberInt()
        {
            int value;
             do
            {
                if (int.TryParse(Console.ReadLine(), out value))
                    break;

                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
            }
            while (true);
            return value;
        }
        public static double ReadNumberDouble()
        {
            double value;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out value))
                    break;

                Console.WriteLine("Вы ввели неверное значение! Введите пожалуйста число!");
            }
            while (true);
            return value;
        }

        public static void GeneralMenu(int caseSwitch)
        {   
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Выберите формулу: \n 1 - Формула площади треугольника по стороне и высоте \n 2 - Формула площади треугольника по двум сторонам и углу между ними \n 3 - Назад");
                    int formulaId = ReadNumberInt();
                    TriangleMenu(formulaId);
                    break;
                case 2:
                    Console.WriteLine("Выберите формулу: \n 1 - Формула половины произведения диагоналей и синуса острого угла между ними \n 2 - Формула Брахмагупты \n 3 - Назад");
                    formulaId = ReadNumberInt();
                    QuadrangleMenu(formulaId);
                    break;
                case 3:
                    Console.Write("Введите длину стороны квадрата: ");
                    int side =ReadNumberInt();
                    double area = CalculateArea.Square(side);
                    Console.WriteLine("Площадь квадрата со стороной '{0}', равняется '{1}'", side,area);
                    ChangePolygon();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Такого пункта меню нет, повторите ввод!");
                    int shapeId = ReadNumberInt();
                    GeneralMenu(shapeId);
                    break;
            }
        }

        public static void TriangleMenu(int caseSwitch)
        {           
            switch (caseSwitch)
            {
                case 1:
                    Console.Write("Введите длину стороны треугольника: ");
                    int sideOne = ReadNumberInt();
                    Console.Write("Введите длину высоты проведенной к этой стороне: ");
                    int height = ReadNumberInt();
                    double area = CalculateArea.Triangle(sideOne, height);
                    Console.WriteLine("Площадь треугольника со стороной '{0}' и высотой '{1}', равняется '{2:0.00}'", sideOne, height, area);
                    ChangePolygon();
                    break;
                case 2:
                    Console.Write("Введите длину первой стороны треугольника: ");
                    sideOne = ReadNumberInt();
                    Console.Write("Введите длину второй стороны треугольника: ");
                    int sideTwo = ReadNumberInt();
                    Console.Write("Введите угол между сторонами: ");
                    double angle = ReadNumberDouble();
                    area = CalculateArea.Triangle(sideOne, sideTwo, angle);
                    Console.WriteLine("Площадь треугольника с первой стороной '{0}', со второй стороной '{1}' и углом '{2}' равняется '{3:0.00}'", sideOne, sideTwo, angle, area);
                    ChangePolygon();
                    break;
                case 3:
                    Console.WriteLine("Выберите необходимую фигуру: \n 1 - Треугольник \n 2 - Четырехугольник \n 3 - Квадрат \n 4 - Круг");
                    int shapeId = ReadNumberInt();
                    GeneralMenu(shapeId);
                    break;
                default:
                    Console.WriteLine("Такого пункта меню нет, повторите ввод!");
                    shapeId = ReadNumberInt();
                    GeneralMenu(shapeId);
                    break;
            }
        }
        public static void QuadrangleMenu(int caseSwitch)
        {
            switch (caseSwitch)
            {
                case 1:
                    Console.Write("Введите первую диагональ: ");
                    int diagonalOne  = ReadNumberInt();
                    Console.Write("Введите вторуб диагональ: ");
                    int diagonalTwo = ReadNumberInt();
                    Console.Write("Введите угол между диагоналями: ");
                    double angle = ReadNumberInt();
                    double area = CalculateArea.Quadrangle(diagonalOne, diagonalTwo, angle);
                    Console.WriteLine("Площадь четырехугольника с диагоналями '{0}' и '{1}', и углом '{2}' равняется '{3:0.00}'", diagonalOne, diagonalTwo, angle, area);
                    ChangePolygon();
                    break;
                case 2:
                    Console.WriteLine("Введите длину всех сторон(через пробел):");
                    string quadrangleSides = Console.ReadLine();
                    Char separation = ' ';
                    int[] sides = new int[4];
                    String[] quadrangleSide = quadrangleSides.Split(separation);
                    int i = 0;
                    foreach (string side in quadrangleSide)
                    {
                        sides[i] = Convert.ToInt32(side);
                        i++;
                    }
                   
                    area = CalculateArea.Quadrangle(sides[0], sides[1], sides[2], sides[3]);
                    Console.WriteLine("Площадь четырехугольника со сторонами '{0}','{1}', '{2}', '{3}', равняется '{4:0.00}'", sides[0], sides[1], sides[2], sides[3], area);
                    ChangePolygon();
                    break;
                case 3:
                    Console.WriteLine("Выберите необходимую фигуру: \n 1 - Треугольник \n 2 - Четырехугольник \n 3 - Квадрат \n 4 - Круг");
                    int shapeId = ReadNumberInt();
                    GeneralMenu(shapeId);
                    break;
                default:
                    Console.WriteLine("Такого пункта меню нет, повторите ввод!");
                    shapeId = ReadNumberInt();
                    GeneralMenu(shapeId);
                    break;
            }
        }
        public static void ChangePolygon()
            {
            Console.Write("Вы хотите найти площадь другой фигугры(да/нет)?");
                    string answer = Console.ReadLine();
                    if (answer.Contains("да"))
                    {
                        Console.WriteLine("Выберите необходимую фигуру: \n 1 - Треугольник \n 2 - Четырехугольник \n 3 - Квадрат \n 4 - Выход ");
                        int shapeId = ReadNumberInt();
                        GeneralMenu(shapeId);
            }
}


    }
}
