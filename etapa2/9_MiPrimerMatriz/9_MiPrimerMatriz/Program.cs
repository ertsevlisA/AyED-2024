namespace _9_MiPrimerMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla
            //n y m son datos que ingresa el usuario

            Console.WriteLine("ingrese cuantas filas(n) va a tener la matriz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cuantas columnas(m) va a tener la matriz");
            int m = int.Parse(Console.ReadLine());

            //creo la matriz con los valores pedidos al usuario 
            int[,] matriz = new int[n, m];
            Console.WriteLine("matriz" + n + "x" + m + "inicializado en ceros");

            ImprimirMatriz(matriz);

        }
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
            Console.ReadKey();
        }
        
    }
}
    
 