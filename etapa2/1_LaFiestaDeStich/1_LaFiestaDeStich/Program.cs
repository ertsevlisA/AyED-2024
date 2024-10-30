using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStich
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("cuantos invitados hay en la fiesta de Stitch");
            int invitado = int.Parse(Console.ReadLine());
            int[] cantinvit = new int[invitado];
            for (int cont = 0; cont < cantinvit.Count(); cont++)
            {
                Console.WriteLine("ingrese la cantidad de comida que va a comer cada uno");
                int Cantcomida = int.Parse(Console.ReadLine());
                if (Cantcomida < 100 && Cantcomida >= 1)
                {
                    cantinvit[cont] = Cantcomida;
                    Console.WriteLine(cantinvit[cont]);
                }
                else
                {
                    Console.WriteLine("ERROR, ingrese la cantidad de comida entre 1 al 100");
                    cont--;
                }
            }
            int promedio = 0;
            for (int cont = 0; cont < cantinvit.Count(); cont++)
            {
                promedio += cantinvit[cont];
            }
            Console.WriteLine("el promedio es: " + (promedio / invitado));
            Console.ReadKey();

        }
    }
}
