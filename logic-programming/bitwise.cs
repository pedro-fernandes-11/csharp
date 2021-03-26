using System;
class Aula09{
    static void Main(){

        int num = 2;
        int num2 = 20;

        num = num << 2; //deslocar duas casas binárias pra esquerda adicionando um '0' nos espaços vazios
        num2 = num2 >> 2; //deslocar pra direita, cortando duas casas

        Console.WriteLine(num);
        Console.WriteLine(num2);
    }
}