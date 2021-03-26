using System;

class Aula15{
    static void Main(){
        int tempo = 0;
        char transporte;

        Console.WriteLine("Espirito Santo até Goias");
        Console.WriteLine("[a]Avião || [c]Carro || [o]Ônibus");
        transporte = char.Parse(Console.ReadLine());

        switch(transporte){
            case 'A': case 'a':
                tempo = 50;
                break;
            case 'C': case 'c':
                tempo = 480;
                break;
            case 'O': case 'o':
                tempo = 660;
                break;
            default:
                tempo = 0;
                break;
        }
        if(tempo == 0){
            Console.WriteLine("Veículo indisponível");
        }else{
            Console.WriteLine("A viagem vai ser de {0} minutos", tempo);
        }
    }
}