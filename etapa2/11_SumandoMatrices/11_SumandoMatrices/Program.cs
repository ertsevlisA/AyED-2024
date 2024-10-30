namespace _11_SumandoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sumar dos matrices de igual tamaño nxn.
            Console.WriteLine("ingrese el valor de las filas:(N)");
 
            int n = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, n];
            int[,] matriz2 = new int[n, n];
            int[,] matrizresultante = new int[n, n];


            //recorre la primera matriz1 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Ingrese el elemento en la posición ({i},{j}): ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Imprime la matriz1
            Console.WriteLine("\nLa matriz ingresada es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n j++) 
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //recorre la matriz2
            for (int e = 0; e < n; e++)
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write("Ingrese el elemento en la posición ({e},{r}): ");
                    matriz2[e, r] = int.Parse(Console.ReadLine());
                }
            }

            // Imprime la matriz2
            Console.WriteLine("\nLa matriz ingresada es:");
            for (int e = 0; e < n; e++)
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write(matriz2[e, r] + "\t");
                }
                Console.WriteLine();
            }



            
            Console.ReadKey();
        }
    }
}