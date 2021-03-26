using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){

        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear();

        veiculos.Remove(20); // passando como param a chave

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        int chave = 20;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("Tem {0} na coleção como chave", chave);
        }else{
            Console.WriteLine("Não tem {0} na coleção como chave", chave);
        }
        
        veiculos[15] = "Bicicleta";

        string valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("Tem {0} na coleção como valor", valor);
        }else{
            Console.WriteLine("Não tem {0} na coleção como valor", valor);
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach(string v in valores){
            Console.WriteLine("Valor {0}", v);
        }

        foreach(KeyValuePair<int, string> v in veiculos){
            Console.WriteLine("{0}: {1}", v.Key, v.Value);
        }

    }
}