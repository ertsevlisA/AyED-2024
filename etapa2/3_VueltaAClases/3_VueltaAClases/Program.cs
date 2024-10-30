using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos tps tenes en la materia?");

            int tps = int.Parse(Console.ReadLine());

            int[] cantps = new int[tps];

            for (int i = 0; i < cantps.Count(); i++)
            {
                Console.WriteLine(" Cuanto te sacaste en el tp Nro.: " + (i + 1) + "?");
                int calif = int.Parse(Console.ReadLine().ToLower());

                if (calif < 11)
                {
                    cantps[i] = calif;
                    Console.WriteLine(cantps[i]);
                }
                else
                {
                    Console.WriteLine("la nota maxima es 10");
                    i--;
                }
            }

            int promedio = 0;
            for (int cont = 0; cont < cantps.Count(); cont++)
            {
                promedio += cantps[cont];
            }
            Console.WriteLine("el promedio es: " + (promedio / tps));
            if(promedio>6)
            {
                Console.WriteLine("aprobaste la materia");
            }
            else
            {
                Console.WriteLine("no aprobaste");
            }
            Console.WriteLine("cuantos examenes tiene la materia");
            int examenes = int.Parse(Console.ReadLine());

            Console.ReadKey();
            }  
                
        }
    }
   

