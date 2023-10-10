using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите H");// подсказка
            double H = Convert.ToDouble(Console.ReadLine());// ввод значения высоты для переменной H
            double g = 9.8;// велечина ускорения свободного падения
            double x = 2 * H / g;// присвоение части вычислений по формуле промежуточной переменной
            double T = Math.Sqrt(x);// извлечение числа из под корня(также по формуле) = присвоение переменной т значение нужного нам результата
            Console.WriteLine($" Время падения камня на поверхность земли с высоты h = { T }");// вывод нужного нам результата закрепленного за переменной Т
            Console.ReadKey();// команда для показа интерфейса консоли после исполнения программы/кода
        }
    }
}
