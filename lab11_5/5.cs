using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых положительных числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while ( a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            Console.WriteLine("НОД равен {0}", a);
        }
    }
}
