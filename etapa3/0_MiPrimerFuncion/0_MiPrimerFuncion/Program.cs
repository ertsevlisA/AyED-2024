using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MiPrimerFuncion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Escribir una función a la que se le pase una cadena<nombre>
            //y muestre por pantalla el saludo ¡hola < nombre > !
            
            string nombre = "aylu";
            saludar(nombre);
        }
        static string saludar (string nombre)
        {



            string saludo=("hola" + nombre);
            return saludo;
                
         }
      
        
    }
}

