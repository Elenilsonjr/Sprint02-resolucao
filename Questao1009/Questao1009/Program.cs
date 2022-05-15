using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        Console.WriteLine();
        string nome = Console.ReadLine();

        Console.WriteLine();
        double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        double totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double porcentagem = totalVenda * 0.15;
        double soma = salarioFixo + porcentagem;

        Console.WriteLine("TOTAL = R$ " + soma.ToString("F2"));
    }

}