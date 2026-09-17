using System;
class HelloWorld {
  static void Main() {
     double[] temperaturas = new double[3];

Console.Write("Digite a primeira temperatura: ");
temperaturas[0] = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda temperatura: ");
temperaturas[1] = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira temperatura: ");
temperaturas[2] = double.Parse(Console.ReadLine());

Console.WriteLine("Primeira temperatura: " + temperaturas[0]);
Console.WriteLine("Última temperatura: " + temperaturas[2]);

  }
}
