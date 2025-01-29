using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      
      if (num1 % 2 == 0)
      {
		Console.WriteLine("O Número é par!");
      	}

      else 
      {
      	Console.WriteLine("O Número é ímpar!");
      }
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();     
      
		}
	}
