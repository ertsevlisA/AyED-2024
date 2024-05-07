using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            Console.WriteLine("Decime el radio de la esfera");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("la superficie es de=" + (4*Math.PI*(radio * radio)));
            Console.WriteLine("el volumen es de=" + (4 * Math.PI / 3*(radio * radio * radio)));
            Console.ReadKey();
        }
    }
}
