using System;

class Program
{
    static void Main()
    {
        const double taxaDolar = 5.17;
        const double taxaEuro = 6.14;
        const double taxaPesoArgentino = 0.05;

        Console.Write("Digite o valor em reais (R$): ");
        double valorReais = Convert.ToDouble(Console.ReadLine());

        double valorDolar = valorReais/taxaDolar;
        double valorEuro = valorReais/taxaEuro;
        double valorPesoArgentino = valorReais/taxaPesoArgentino;

        Console.WriteLine($"Valor em dolares: {valorDolar:F2}");
        Console.WriteLine($"Valor em euros:{valorEuro:F2}");
        Console.WriteLine($"Valor em pesos argentinos:{valorPesoArgentino}");
    }
}