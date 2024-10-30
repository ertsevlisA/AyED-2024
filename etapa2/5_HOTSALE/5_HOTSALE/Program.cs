using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_HOTSALE
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("¿cuantos productos se vendio durante el evento?");
            int productos = int.Parse(Console.ReadLine());
            int[] canproduc = new int[productos];
            for (int m = 0; m < productos; m++)
            {
                Console.WriteLine("¿cual es el precio del producto nro.:" + (m + 1) + "?");
                int precio = int.Parse(Console.ReadLine());
                canproduc[m] = precio;
            }
            for (int m = 0; m < productos; m++)
            {
                for (int r = 0; r < productos - 1; r++)
                {
                    if (canproduc[r] < canproduc[r + 1])
                    {
                        k = canproduc[r];
                        canproduc[r] = canproduc[r + 1];
                        canproduc[r + 1] = k;
                    }
                }
               
            }
            Console.WriteLine("---lista del producto con el precio mas alto al precio mas bajo---");
            for (int i = 0; i < productos; i++)
            {
                Console.WriteLine(canproduc[i]);

            }
            Console.ReadKey();
        }
    }
}
                

        
    

