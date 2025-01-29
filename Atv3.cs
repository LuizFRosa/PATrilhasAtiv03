using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      	Console.Write("Digite mais um número: ");
      int num2 = int.Parse(Console.ReadLine());
      
      if (num1 = num2)
      {
		Console.WriteLine("Estes 2 números são iguais.");
      	}
      else 
      {
      	Console.WriteLine("Estes números não são iguais :(");
      }
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
