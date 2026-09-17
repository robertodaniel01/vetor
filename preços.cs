using System;
class HelloWorld {
  static void Main() {
    double[] precos = { 150.00, 85.50, 420.00, 90.00 };

Console.WriteLine("Índice 1: R$ " + precos[1]);
Console.WriteLine("Índice 3: R$ " + precos[3]);

double soma = precos[0] + precos[2];

Console.WriteLine("Soma: " + soma.ToString("C"));
  }
}
