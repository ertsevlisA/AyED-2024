using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_alreves
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra1, letra2, letra3;
            Console.WriteLine("decime una letra cualquiera");
            letra1 = Console.ReadLine();
            Console.WriteLine("decime una letra mas");
            letra2 = Console.ReadLine();
            Console.WriteLine("decime otra letra");
            letra3 = Console.ReadLine();
            Console.WriteLine(letra3+letra2+letra1);
            Console.ReadKey();
        }
    }
}
