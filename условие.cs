using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число градусов первого угла данного треугольника");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число градусов второго угла данного треугольника");
            int B = Convert.ToInt32(Console.ReadLine());
            if ((A + B) < 180)
            {
                Console.WriteLine("Такой треугольник существует");
                if (A == 90 || B == 90)
                {

                    Console.WriteLine("Треугольник прямоугольный");

                }
            }
            else
            {
                Console.WriteLine("Такой треугольник не существует");
            }
        }
    }
}
