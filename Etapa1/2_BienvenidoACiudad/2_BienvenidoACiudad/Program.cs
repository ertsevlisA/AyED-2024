using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese un numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero diferente");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de los dos numeros es igual a " + (numero1 + numero2));
            Console.WriteLine("la resta de los dos numeros seria" + (numero1 - numero2));
            Console.WriteLine("la multiplicacion de ambos numeros seria igual a" + (numero1 * numero2));
            Console.WriteLine("la division de ambos numeros seria" + (numero1 / numero2));
            Console.WriteLine("el resto de la divison seria igual a" + (numero1 % numero2));
            Console.ReadKey();
        }
    }
}
