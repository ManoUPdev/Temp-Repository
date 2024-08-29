using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite um valor inteiro positivo: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        
        if (valor < 0)
        {
            Console.WriteLine("Por favor, insira um valor positivo.");
            return;
        }

        
        int a = 0, b = 1;

        
        Console.Write(a);

        
        while (b <= valor)
        {
            Console.Write(", " + b);
            int proximo = a + b;
            a = b;
            b = proximo;
        }

        Console.WriteLine(); 
    }
}
