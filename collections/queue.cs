using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); // Adiciona no final
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = Console.ReadLine();

        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo {0} encontrado", v);
        }else{
            Console.WriteLine("Veiculo {0} não encontrado", v);
        }

        // veiculos.Clear();

        Console.WriteLine("Primeiro veiculo {0} removido", veiculos.Dequeue());
        Console.WriteLine("Primeiro veiculo {0}", veiculos.Peek());
        Console.WriteLine("Tamanho fila: "+veiculos.Count);

        /*foreach(string veic in veiculos){
            Console.WriteLine("Veiculo {0}", veic);
        }*/
        
        Console.WriteLine("Tamanho fila: "+ veiculos.Count);
        Console.WriteLine(veiculos[2]);

        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }
    }
}