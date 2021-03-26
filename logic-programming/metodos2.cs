using System;
class Aula24{
    static void Main(){
        for(int i = 0;i<3;i++){
            secundario();
        }

        int valor1, valor2;
        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("A soma de {0} com {1} é {2}",valor1, valor2, somar(valor1, valor2));
    }
    static void secundario(){
        Console.WriteLine("Método acionado");
        Console.WriteLine("Linha de comando");
        Console.WriteLine(".....");
    }
    static int somar(int n1, int n2){
        int soma = n1 + n2;
        return soma;
    }
}