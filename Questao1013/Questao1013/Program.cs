using System;

class URI {

    static void Main(string[] args) {

        string[] maiorNumero = Console.ReadLine().Split(' ');
        int a = Int32.Parse(maiorNumero[0]);
        int b = Int32.Parse(maiorNumero[1]);
        int c = Int32.Parse(maiorNumero[2]);

        double MaiorAB = (a + b + Math.Abs(a - b)) / 2;
        double MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
        
        Console.WriteLine(MaiorABC + " eh o maior");
        

    }

}