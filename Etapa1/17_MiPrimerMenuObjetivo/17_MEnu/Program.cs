using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenuObjetivo
{

    }      
    
namespace MenuProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                bool salir = false;
                Console.WriteLine("Bienvenido/a, te mostramos el menu de hoy, elige un numero de las opciones");
                Console.WriteLine("--- Menú ---");
                Console.WriteLine("1. Opción 1");
                Console.WriteLine("2. Opción 2");
                Console.WriteLine("3. Opción 3");
                Console.WriteLine("4. Salir");

                
                while (!salir)
                {
                    Console.Write("Seleccione una opción: ");

                    
                    string opcion = Console.ReadLine();
                    
                    if (opcion == "1")
                    {
                        Console.WriteLine(" elegiste la Opción 1.La de la pizza");
                       
                    }
                    else if (opcion == "2")
                    {
                        Console.WriteLine("elegiste la Opción 2.Buena eleccion,escogiste la opcion de la hamburguesa");
                        
                    }
                    else if (opcion == "3")
                    {
                        Console.WriteLine("elegiste la Opción 3.Escogiste la opcion de la mila con papas fritas");
                        
                    }
                    else if (opcion == "4")
                    {
                        Console.WriteLine("¡Chauu!");
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida, seleccione una opción del menú.");
                    }
                }

                
                Console.ReadKey();
            }
        }
    }


 