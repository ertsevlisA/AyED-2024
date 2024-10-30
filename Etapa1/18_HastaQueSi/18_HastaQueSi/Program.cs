using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            string SI;
            Console.WriteLine("Esciba SI para poder terminar el programa");
            SI = Console.ReadLine();

            while (SI != "SI")
            {
                Console.WriteLine("¿Queres terminar el programa?");
                SI = Console.ReadLine();
            }
            if (SI == "SI")
            {
                Console.WriteLine("Hasta la vista");
            }

            Console.ReadKey();

        }
    }
}
