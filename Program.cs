namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("-----------------");
      Console.WriteLine("Selecione uma opção:");

      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float primeiroValor = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float segundoValor = float.Parse(Console.ReadLine());

      float soma = primeiroValor + segundoValor;

      Console.WriteLine("");
      Console.WriteLine($"O resultado da soma é {soma}");

      // Console.WriteLine("O resultado da soma é " + soma);
      // Console.WriteLine($"O resultado da soma é {primeiroValor + segundoValor}"); 
      // Console.WriteLine("O resultado da soma é " + (primeiroValor + segundoValor));

      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float primeiroValor = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float segundoValor = float.Parse(Console.ReadLine());

      float subtracao = primeiroValor - segundoValor;

      Console.WriteLine("");
      Console.WriteLine($"O resultado da subtração é {subtracao}");

      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float primeiroValor = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float segundoValor = float.Parse(Console.ReadLine());

      float multiplicacao = primeiroValor * segundoValor;

      Console.WriteLine("");
      Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");

      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float primeiroValor = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float segundoValor = float.Parse(Console.ReadLine());

      float divisao = primeiroValor / segundoValor;

      Console.WriteLine("");
      Console.WriteLine($"O resultado da divisão é {divisao}");

      Console.ReadKey();
      Menu();
    }
  }
}
