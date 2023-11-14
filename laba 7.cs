using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int celoe_chislo))
            {
                Console.WriteLine(1);
            }
            else if (double.TryParse(str, out double vehchestv_chislo))
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
