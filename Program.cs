using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое значение N больше 0: ");
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= N)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}
