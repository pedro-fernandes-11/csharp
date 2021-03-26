using System;

class Aula16{
    static void Main(){
        Inicio:

        Console.Clear();
        Console.WriteLine("Console limpo, iniciando programa...");
        int tempo = 0;
        char transporte;
        char resposta;

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

        Console.WriteLine("Deseja rodar o programa novamente? [s/n]");
        resposta = char.Parse(Console.ReadLine());
        if(resposta == 's' | resposta == 'S'){
            goto Inicio;
        }else if(resposta == 'n' | resposta == 'N'){
            Console.Clear();
            Console.WriteLine("Você escolheu sair");
        }
    }
}