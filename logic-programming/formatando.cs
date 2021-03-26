using System;

class Aula06{
    static void Main(){
        int n1, n2, n3;
        n1 = 5;
        n2 = 10;
        n3 = 15;

        Console.Write("\tNúmero 1: {0}\n\tNúmero 2: {1}\n\tNúmero 3: {2}\n",n1,n2,n3);
        Console.WriteLine("\n\n");

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........: {0,15}",produto);
        Console.WriteLine("Valor Compra...: {0, 15:c}",valorCompra);
        Console.WriteLine("Lucro..........: {0, 15:p}",lucro);
        Console.WriteLine("Valor Venda....: {0, 15:c}",valorVenda);
    }
}