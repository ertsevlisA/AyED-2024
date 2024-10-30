namespace _8_VectorRandomSwitch
{
   


        class Program
        {
            static void Main()
            {
                Console.WriteLine("Ingrese el tamaño del vector:");
            int n = int.Parse(Console.ReadLine());
                while ( n <= 0)
                {
                    Console.WriteLine("Ingrese un número entero válido mayor que cero.");
                }

                // Crear vector de tamaño n
                int[] vector = new int[n];

                // Llenar el vector con números aleatorios entre 1 y 100
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    vector[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100
                }

            // Menú de opciones
            while (true)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Imprimir todos los elementos del vector.");
                Console.WriteLine("2. Buscar un número en el vector.");
                Console.WriteLine("3. Ordenar el vector (ascendente o descendente).");
                Console.WriteLine("4. Salir del programa.");
                Console.WriteLine("Ingrese su opción (1-4):");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                    {
                        Console.WriteLine("Opción inválida. Ingrese un número del 1 al 4.");
                    }

                    switch (opcion)
                    {
                        case 1:
                            // Imprimir todos los elementos del vector
                            Console.WriteLine("Elementos del vector:");
                            ImprimirVector (vector);
                            break;

                        // Método para imprimir todos los elementos del vector
                        
                    case 2:
                            // Buscar un número en el vector
                            Console.WriteLine("Ingrese el número a buscar:");
                        int numeroBuscar;
                        while (!int.TryParse(Console.ReadLine(), out numeroBuscar))
                        {
                                Console.WriteLine("Ingrese un número entero válido.");
                            }
                            BuscarNumero(vector, numeroBuscar);
                            break;
                       
                    case 3:
                            // Ordenar el vector (ascendente o descendente)
                            Console.WriteLine("\n¿Cómo desea ordenar el vector?");
                            Console.WriteLine("1. Orden ascendente.");
                            Console.WriteLine("2. Orden descendente.");
                            Console.WriteLine("Ingrese su opción (1-2):");

                        int opcionOrden = int.Parse(Console.ReadLine());
                            while ( opcionOrden < 1 || opcionOrden > 2)
                            {
                                Console.WriteLine("Opción inválida. Ingrese 1 para ascendente o 2 para descendente.");
                            }

                            if (opcionOrden == 1)
                            {
                                OrdenarVector(vector, true); // Orden ascendente
                            }
                            else
                            {
                                OrdenarVector(vector, false); // Orden descendente
                            }
                            Console.WriteLine("Vector ordenado:");
                            ImprimirVector(vector);
                            break;
                      
                    case 4:
                            // Salir del programa
                            Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("no existe esa opcion");
                            break;
                    }
                }
                   
            }

        // Método para imprimir todos los elementos del vector
        static void ImprimirVector(int[] vector)
        {
            foreach (var elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
        // Método para buscar un número en el vector y mostrar su posición
        static void BuscarNumero(int[] vector, int numero)
        {
            bool encontrado = false;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numero)
                {
                    Console.WriteLine($"El número {numero} se encuentra en la posición {i} del vector.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"El número {numero} no se encuentra en el vector.");
            }
        }
        // Método para ordenar el vector (ascendente o descendente)
        static void OrdenarVector(int[] vector, bool ascendente)
        {
            Array.Sort(vector); // Orden ascendente por defecto
            if (!ascendente)
            {
                Array.Reverse(vector); // Orden descendente si se solicita
            }
        }
    }

}
