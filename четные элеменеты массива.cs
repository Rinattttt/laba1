using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace четные_элементы_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввиедите количество строк");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] massiv = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Введите каждое значение для каждого элемента массива");
                    massiv[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Все четные значения элементов массива(разделенные пробелом):");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (massiv[i, j] % 2 == 0)
                    {
                        Console.Write(massiv[i, j] + " ");
                    }
                }
            }
        }
    }
}
