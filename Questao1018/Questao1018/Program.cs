using System;

class URI {

    static void Main(string[] args) {
        
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(numero);

        Console.WriteLine(numero / 100 + " nota(s) de R$ 100,00");
        numero = numero % 100;
        Console.WriteLine(numero / 50 + " nota(s) de R$ 50,00");
        numero = numero % 50;
        Console.WriteLine(numero / 20 + " nota(s) de R$ 20,00");
        numero = numero % 20;
        Console.WriteLine(numero / 10 + " nota(s) de R$ 10,00");
        numero = numero % 10;
        Console.WriteLine(numero / 5 + " nota(s) de R$ 5,00");
        numero = numero % 5;
        Console.WriteLine(numero / 2 + " nota(s) de R$ 2,00");
        numero = numero % 2;
        Console.WriteLine(numero / 1 + " nota(s) de R$ 1,00");


    }

}