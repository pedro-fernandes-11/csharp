using System;
class Aula20{
    static void Main(){
        char resposta;
        int controlador = 0;
        
        while(controlador == 0){
            Console.WriteLine("Dento do while");
            Console.WriteLine("Quer sair? [s/n]");
            resposta = char.Parse(Console.ReadLine());
            if(resposta == 's'){
                controlador = 1;
            }
        }
    }
}