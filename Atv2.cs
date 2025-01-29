using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      	Console.Write("Digite mais um número: ");
      int num2 = int.Parse(Console.ReadLine());
      
      if (num1 < num2)
      {
		Console.WriteLine("Entre estes números o menor é o primeiro");
      	}
      else 
      {
      	Console.WriteLine("Entre estes números o menor é o segundo");
      }
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
