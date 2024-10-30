using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int N;
            num = 0;
          
            Console.WriteLine("Ingresa cualquier numero que se te ocurra");
            N = int.Parse(Console.ReadLine());
            while (num <= N)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }

                num++;
            }
            Console.ReadKey();



        }
    }
}
