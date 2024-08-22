using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if(idade <= 13)
        {
            Console.WriteLine("Crianca");
        }

        else if (idade > 13 && idade <= 18)
        {
            Console.WriteLine("Adolescente");
        }

        else if (idade > 18 && idade <= 60)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Idoso");
            
        }
    }
}