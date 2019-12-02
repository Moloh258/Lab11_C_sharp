using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные числа А и В (A > B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (a >= b)
            {
                a -= b;
            }
            Console.WriteLine("Незанятая часть отрезка равна {0}", a);
        }
    }
}
