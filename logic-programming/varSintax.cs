using System;

class Aula03{

    static void Main(){
        int num1, num2, mult;
        char letra = 'c';
        float valor = 1.5f;
        string palavra = "Pedro";

        num1 = 10;
        num2 = 2;
        mult = num1 * num2;

        var aux = palavra;

        Console.WriteLine("A multiplicação de "+num1+" e "+num2+" é igual a "+mult);
        Console.WriteLine(letra);
        Console.WriteLine(valor);
        Console.WriteLine("Valor da váriavel aux: "+aux+"...");
    
    }
}