using System;

class URI {

    static void Main(string[] args) {
        int idadeDias = int.Parse(Console.ReadLine());

        Console.WriteLine(idadeDias / 365 + " ano (s)");
        idadeDias = idadeDias % 365;

        Console.WriteLine(idadeDias / 30 + " mes (s)");
        idadeDias = idadeDias % 30;

        Console.WriteLine(idadeDias + " dia (s)");



    }

}
