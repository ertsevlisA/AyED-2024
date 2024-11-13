// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de candidatos: ");
        int cantidadCandi= int.Parse(Console.ReadLine());

        int[] puntajes = new int[cantidadCandi];

        for (int i = 0; i < cantidadCandi; i++)
        {
            Console.WriteLine("Ingrese el puntaje del candidato " + (i + 1) + ":");
            puntajes[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < cantidadCandi; i++)
        {
            for (int j = i; j < cantidadCandi; j++)
            {
                if (puntajes[i] > puntajes[j])
                {
                    int temp = puntajes[i];
                    puntajes[i] = puntajes[j];
                    puntajes[j] = temp;
                }
            }
        }

        Console.WriteLine("Puntajes ordenados:");
        for (int i = 0; i < cantidadCandi; i++)
        {
            Console.Write(puntajes[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Ingrese el número para filtrar los puntajes múltiplos:");
        int numeroFiltro = int.Parse(Console.ReadLine());

        Console.WriteLine("Puntajes múltiplos de " + numeroFiltro + ":");
        for (int i = 0; i < cantidadCandi; i++)
        {
            if (puntajes[i] % numeroFiltro == 0)
            {
                Console.Write(puntajes[i] + " ");
                //es un espacio para q se vea mas estetico
            }
        }
        Console.ReadKey();
    }
}
