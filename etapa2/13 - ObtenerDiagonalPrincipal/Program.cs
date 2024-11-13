// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        int n = 4;

        Random random = new Random();
        int[,] matriz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = random.Next(1, 100);
            }
        }

        int[] diagonalPrinci = new int[n];

        for (int i = 0; i < n; i++)
        {
            diagonalPrinci[i] = matriz[i, i];
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine(" Diagonal principal: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(diagonalPrinci[i] + " ");
        }
        Console.ReadKey();

    }
}
