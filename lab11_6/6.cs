using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число из ряда Фибоначчи");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int c, i = 2;         
            while (a != n)
            {
                c = a;
                a += b;
                b = c;
                i++;
            }
            Console.WriteLine("Порядковый номер равен: {0}", i);
        }
    }
}
