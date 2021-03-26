using System;
class Aula51{
    static void Main(string[] args){
        
        if(args.Length > 0){
            int soma = 0;

            Console.WriteLine("Quantidade de argumentos {0}", args.Length);

            for(int i = 0;i < args.Length;i++){
                soma += int.Parse(args[i]);
            }
            Console.WriteLine("Soma: {0}", soma);
            
        }else{
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}