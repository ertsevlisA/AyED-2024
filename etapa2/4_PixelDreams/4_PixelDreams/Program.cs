using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("¿cuantos participantes son?");
            int participantes = int.Parse(Console.ReadLine());
            int[] canpartic = new int[participantes];
            for (int i = 0; i < participantes; i++)
            {
                Console.WriteLine("¿que puntaje saco el jugador nro.:" + (i + 1) + "?");
                int puntaje = int.Parse(Console.ReadLine());
                canpartic[i] = puntaje;
            }
            for (int i = 0; i < participantes; i++)
            {
                for (int r=0; r < participantes - 1; r++)
                {
                    if (canpartic[r] < canpartic[r + 1])
                    {
                        k = canpartic[r];
                        canpartic[r] = canpartic[r + 1];
                        canpartic[r + 1] = k;
                    }
                }
               

            }
            Console.WriteLine("---lista de puntajes ordenados de mayor a menor---");
            for (int i = 0; i< participantes; i++) 
            {
                Console.WriteLine(canpartic[i]);

            }
            Console.ReadKey();
            }
        }
    }

