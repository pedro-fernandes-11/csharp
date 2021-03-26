using System;
class Aula27{
    static void Main(){
        int i = -1;
        int[] vetor = new int[100];
        Console.WriteLine("Passando os números pelo CF (ulilzando argumento params):");
        soma(10, 9, 6, 324, 123);

        Console.WriteLine("\n\nInforme os valores do vetor: (\"-1\" para sair da declaração)");
        do{
            i++;
            vetor[i] = int.Parse(Console.ReadLine());
        }while(vetor[i] != -1);

        int[] vetor2 = new int[i];

        for(int j = 0;j<i;j++){
            vetor2[j] = vetor[j];
        }

        soma(vetor2);
    }
    static void soma(params int[] n){
        int soma = 0;

        if(n.Length == 0){
            Console.WriteLine("Não existem valores para serem somados");
        }else if(n.Length == 1){
            Console.WriteLine("Valores insuficientes para a soma: {0}",n[0]);
        }else{
            for(int i = 0;i < n.Length;i++){
                soma += n[i];
            }
            Console.WriteLine("A soma dos valores é {0}", soma);
        }

        Console.WriteLine("===== Vetor: =====");
        for(int i = 0;i<n.Length;i++){
            Console.Write(n[i]+" ");
        }
    }
}