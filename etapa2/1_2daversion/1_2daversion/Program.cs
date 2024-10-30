using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2daversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos invitados hay en la fiesta?");
            int invitados = int.Parse(Console.ReadLine());

            int[] a = new int[invitados];

            for (int i = 0; i < invitados; i++)
            {
                Console.WriteLine("Cuanto consume el invitado " + (i + 1) + "?");
                int comida = int.Parse(Console.ReadLine().ToLower());
                if (comida <= 100)
                {
                    a[i] = invitados + comida / invitados;
                }
                else if (comida>= 100)
                {
                    Console.WriteLine("ERROR,Ingrese un numero menor a 100");
                    i--;
                }
            }
            int puntajeTotal = 0;
            for (int i = 0; i < invitados; i++)
            {
                puntajeTotal += a[i];

            }
            
            int promedio = 0;
            for (int cont = 0; cont < a.Count(); cont++)
            {
                promedio += a[cont];
            }
            Console.WriteLine("el promedio es: " + (promedio / invitados));
            Console.ReadKey();
        }
  
    }
}
