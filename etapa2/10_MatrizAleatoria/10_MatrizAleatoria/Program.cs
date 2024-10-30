namespace _10_MatrizAleatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llenar una matriz de n×m con valores aleatorios entre un rango dado(por ejemplo, 1 a 100).

            Console.WriteLine("ingrese el valor de las filas (n)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de la columnas(m)");
            int m = int.Parse(Console.ReadLine());

            // Definir el rango para los valores aleatorios
            int minVal = 1;
            int maxVal = 100;

            // Crear una instancia de Random para generar números aleatorios
            Random random = new Random();

            // Crear la matriz de n x m
            int[,] matriz = new int[n, m];

            // Llenar la matriz con valores aleatorios dentro del rango especificado
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(minVal, maxVal); // Generar un número aleatorio entre minValor y maxValor
                }
            }

            // Imprimir la matriz
            Console.WriteLine("Matriz " + n + "x" + m + " con valores aleatorios entre " + minVal + " y " + maxVal + ":");
            ImprimirMatriz(matriz);
        }

        // Método para imprimir la matriz
        static void ImprimirMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(); // Salto de línea al terminar una fila
            }
        }

    }
}