using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два положительных целых числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            for (; a < b; a++)
            {
                for (int i = 1; i <= a ; i++)
                {
                    Console.WriteLine("{0}", a);
                }
            }
        }
    }
}
