using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите P проценты:\n");
            int a = Convert.ToInt32(Console.ReadLine());
            double x = 1000;
            int y = 0;
            while (x < 1100)
            {
                y++;
                x *= (a * 0.01 + 1);
            }
            Console.WriteLine("Вклад равен: {0}. Месяц: {1}", x, y);
        }
    }
}
