using System;

class Program
{
    static void Main()
    {

    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if(numero1 > numero2)
    {
        Console.WriteLine($"O maior numero e: {numero1}");
        Console.WriteLine($"O menor numero e: {numero2}");
    }
    else if (numero2 > numero1)
    {
        Console.WriteLine($"O maior numero e: {numero2}");
        Console.WriteLine($"O menor numero e: {numero1}");
    }
    else
    {
        Console.WriteLine("Os numeros sao iguais.");
    }

    }
}
