using System;

class Program
{
   static void Main()
  {
    Console.Write("Digite um valor inteiro positivo: ");
    int valor = Convert.Toint32(Console.ReadLine());

     if(valor < 0)
     {
        Console.Write("Por favor, insira um valor positivo.");
        return;

     }

      int a = 0, b = 1;


      Console.Write(a);


      while(b <= valor)
      {
         Console.Write(" , " + b);
         int proximo = a + b;
         a = b;
         b = proximo;
      }

      Console.Write();
 }
   
}
