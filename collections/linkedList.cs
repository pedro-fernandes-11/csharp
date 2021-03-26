using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){
        LinkedList<string> transporte = new LinkedList<string>();

        transporte.AddFirst("Carro");
        transporte.AddFirst("Navio");
        transporte.AddFirst("Avião");
        transporte.AddFirst("Moto");

        transporte.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no = transporte.FindLast("Navio");

        transporte.AddAfter(no, "Patinete");
        no = transporte.FindLast("Carro"); // .Next pega o elemento seguinte

        transporte.AddAfter(no, "Patins");

        // transporte.Clear()

        if(transporte.Find("Carro") == null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        }

        // transporte.Remove("Navio");
        transporte.RemoveFirst();
        transporte.RemoveLast();

        foreach(string t in transporte){
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}