using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            int counter = 0;
            int result = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '0')
                {
                    counter++;
                    if(counter > result)
                        result = counter;
                }
                else
                    counter = 0;                 
            }
            Console.WriteLine(binaryNumber);
            Console.WriteLine(result);
            Console.Read();          
        }
    }
}
