using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      float num1 = float.Parse(Console.ReadLine());
      
      	Console.Write("Digite mais um número: ");
      float num2 = float.Parse(Console.ReadLine());
      
      
      if (num1 == num2)
      {
		Console.WriteLine("O primeiro número é igual ao segundo!");
      	}

      else if (num1 > num2)
      {
      	Console.WriteLine("O primeiro número é maior que o segundo!");
      }
      else
      {
      	Console.WriteLine("O primeiro número é menor que o segundo!");
      }
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();     
      
		}
	}
