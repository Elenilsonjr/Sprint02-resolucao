using System;
using System.Globalization;
using System.Collections.Generic;
class URI {
    static void Main(string[] args) {

        string[] peca1 = Console.ReadLine().Split(' ');
        int codigo1 = Int32.Parse(peca1[0]);
        int quantidade1 = Int32.Parse(peca1[1]);
        double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
        
        string[] peca2 = Console.ReadLine().Split(' ');
        int codigo2 = Int32.Parse(peca2[0]);
        int quantidade2 = Int32.Parse(peca2[1]);
        double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

        double total1 = valor1 * quantidade1;
        double total2 = valor2 * quantidade2;


        double totalCompra = total1 + total2;

        Console.WriteLine("VALOR A PAGAR: R$ " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));





    }

}