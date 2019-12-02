using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            int c = 1;
            while (c < a)
            {
                b++;
                c += b;
            }
            Console.WriteLine("K равно {0}/nСумма равна: {1}", b, c);
        }
    }
}
