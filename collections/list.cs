using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List<string>carros = new List<string>();
        string[] carros2 = new string[6];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);

        //carros.Clear();

        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);

        carros.Insert(1, "HRV");

        int posAlt = carros.LastIndexOf("HRV");
        Console.WriteLine("Ultimo HRV ta na pos: {0}", posAlt + 1);

        foreach(string c in carros2){
            Console.WriteLine("Carro 2: {0}", c);
        }

        string cAlt = "HRV";
        int pos = 0;
        pos = carros.IndexOf(cAlt);

        Console.WriteLine("Carro {0} esta na posição {1}", cAlt, pos + 1);

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}", c);
            
        }
        Console.WriteLine("==========");

        carros.Remove("Argo");
        carros.RemoveAt(0);
        carros.Reverse();
        int tamanhoCarros = carros.Count;
        // carros.Sort(); ordena alfabeticamente
        // carros.Capacity(); quantidade de elementos q a lista pode armazenar
        foreach(string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }

        Console.WriteLine(tamanhoCarros);
    }
}