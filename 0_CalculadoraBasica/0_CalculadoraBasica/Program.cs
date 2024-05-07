using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("decime un numero cualquiera");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("ahora decime otro mas");
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de estos dos numeros es" +( num1 + num2));
            Console.WriteLine("la resta de estos dos numeros es" + (num1 - num2));
            Console.WriteLine("y la multi de estos dos numeros es" + (num1 * num2));
            Console.WriteLine("su division de estos dos numeros es" + (num1 / num2));
            Console.WriteLine("y su resto es" + (num1 % num2));

            Console.ReadKey();
        }
    }
}
