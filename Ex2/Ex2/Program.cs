using System;

class Program
{
    static void main()
    {
       const double taxaDolar = 5.17;
       const double taxaEuro = 6.14;
       const double taxaPesoArgentino = 0.05;

       Console.Write("Digite o valor em reais (R$): ");
       double valorReal = Convert.toDouble(Console.ReadLine());

       double valorDolar = valorReal / taxaDolar;
       double valorEuro = valorReal / taxaEuro;
       double valorPesoArgentino = valorReal / taxaPesoArgentino;

       Console.WriteLine($ "Valor em dolares: {valorDolar:F2}");
       Console.WriteLine($"Valor em euros: {valorEuro:F2}");
       Console.WriteLine($"Valor em pesos argentinos: {valorPesoArgentino:F2}");


    }
}
    

