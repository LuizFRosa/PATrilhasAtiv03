using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      	Console.Write("Digite um número: ");
      int num2 = int.Parse(Console.ReadLine());
      
      int diferenca = num1 - num2;
      
      	Console.WriteLine("Então a diferença entre " +num1+ " e " +num2+ " é " +diferenca);
      	
      	if (diferenca == 10)
      {
		Console.WriteLine("Então a diferença é igual a 10 !");
      	}
      	else if (diferenca < 10)
      {
      	Console.WriteLine("Então a diferença é menor que 10!");
      }
      else
      {
      	Console.WriteLine("Então a diferença é Maior que 10.");
      }
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();     
      
		}
	}
