using System;

class Aula21{
    static void Main(){
        
        string senha = "123";
        string senhaTest;
        int contador = 0;

        do{
            contador++;
            Console.Clear();
            Console.WriteLine(contador+" tentativa Senha:");
            senhaTest = Console.ReadLine();
        }while(senhaTest != senha && contador < 3);

        if(contador == 3){
            Console.WriteLine("Senha incorreta, tentativas: {0}", contador);
        }else{
            Console.WriteLine("Senha correta, tentativas: {0}", contador);
        }
        
    }
}