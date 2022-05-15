using System;

class URI {

    static void Main(string[] args) {

        int segundoTotal = int.Parse(Console.ReadLine());
        int quantidadeHoras = segundoTotal / 3600;
        segundoTotal = segundoTotal % 3600;

        int quantidadeMin = segundoTotal / 60;
        segundoTotal = segundoTotal % 60;

        int quantidadeSeg = segundoTotal;

        Console.WriteLine(quantidadeHoras + (":") + quantidadeMin + (":") + quantidadeSeg);


    }

}
