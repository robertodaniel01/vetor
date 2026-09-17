using System;
class HelloWorld {
  static void Main() {
     int[] estoque = new int[3];

Console.Write("Digite a quantidade do Produto 1: ");
estoque[0] = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade do Produto 2: ");
estoque[1] = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade do Produto 3: ");
estoque[2] = int.Parse(Console.ReadLine());

if (estoque[0] == 0)
{
    Console.WriteLine("Atenção! O primeiro produto está esgotado.");
}
  }
}
