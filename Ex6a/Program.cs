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

        // Ordena o vetor usando Bubble Sort
        BubbleSort(vetor);

        // Exibe o vetor ordenado
        Console.WriteLine("Vetor ordenado:");
        foreach (int valor in vetor)
        {
            Console.Write(valor + " ");
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Troca arr[j] e arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
