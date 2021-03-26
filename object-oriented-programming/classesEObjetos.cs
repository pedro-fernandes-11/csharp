using System;

public class Jogador{
    public int energia = 100;
    public bool vivo = true;
}
public class Aula28{
    static void Main(){
        Jogador jogador1 = new Jogador();
        Jogador jogador2 = new Jogador();
        Jogador jogador3 = new Jogador();

        jogador1.energia = 50;
        jogador2.energia = 75;
        
        Console.WriteLine("Energia do jogador 1: {0}", jogador1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", jogador2.energia);   
        Console.WriteLine("Energia do jogador 3: {0}", jogador3.energia);   
    }
}