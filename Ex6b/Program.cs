using System;

class Program
{
    static void Main()
    {
        // Inicializa o vetor com 1000 valores aleatórios
        int[] vetor = new int[1000];
        Random random = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(1, 10001); // Valores entre 1 e 10000
        }

        // Ordena o vetor usando Array.Sort
        Array.Sort(vetor);

        // Exibe o vetor ordenado
        Console.WriteLine("Vetor ordenado:");
        foreach (int valor in vetor)
        {
            Console.Write(valor + " ");
        }
    }
}
