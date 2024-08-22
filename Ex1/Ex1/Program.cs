using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura do retangulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura do retangulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        double area = altura * largura;

        Console.WriteLine($"A area do retangulo e: {area}");
    }
}
