// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de elementos: ");
            int cantidadElemen = int.Parse(Console.ReadLine());

            int[] valores = new int[cantidadElemen];

            Console.Write("Ingrese el valor minimo para los objetos: ");
            int VMinimo = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadElemen; i++)
            {
                Console.Write("Ingrese el valor del objeto " + (i + 1) + ": ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posiciones de los objetos cuyo valor es mayor a " + VMinimo + ":");
            for (int i = 0; i < cantidadElemen; i++)
            {
                if (valores[i] > VMinimo)
                {
                    Console.WriteLine("Objeto en la posición: " + (i + 1) + ": " + valores[i]);
                }
            }
        }
    }

