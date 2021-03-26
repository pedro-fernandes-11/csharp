using System;
class Aula26{
    // Argumento out permite o retorno de mais de uma variavel quando acionado determinado metodo
    
    static void Main(){
        int dividendo, divisor, resto;
        char resposta;
        do{
            
            Console.Clear();
            Console.Write("Valor do dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Valor do divisor: ");
            divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/{1}, Quociente: {2} e Resto: {3}", dividendo, divisor, dividir(dividendo, divisor, out resto), resto);

            Console.WriteLine("Novamente? [s/n]");
            resposta = char.Parse(Console.ReadLine());

        }while(resposta == 's' ||resposta == 'S');
        Console.WriteLine("Você escolheu sair");
    }
    static int dividir(int dividendo, int divisor, out int rest){
        int quociente = dividendo / divisor;
        rest = dividendo % divisor;
        return quociente;
    }
}