using System;

public class Jogador{
    public string nome;
    public int energia;
    public bool vivo;
    

    // Método construtor
    public Jogador(string _nome, int _energia, bool _vivo){
        this.nome = _nome;
        this.energia = _energia;
        this.vivo = _vivo;
    }

    // Método destrutor
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido", this.nome);
    }
}
public class Aula29{
    static void Main(){
        string[] nomes = new string[3];
        Console.WriteLine("Nome do primeiro jogador: ");
        nomes[0] = Console.ReadLine();
        Console.WriteLine("Nome do segundo jogador: ");
        nomes[1] = Console.ReadLine();
        Console.WriteLine("Nome do terceiro jogador: ");
        nomes[2] = Console.ReadLine();

        Jogador jogador1 = new Jogador(nomes[0], 100, true);
        Jogador jogador2 = new Jogador(nomes[1], 23, true);
        Jogador jogador3 = new Jogador(nomes[2], 0, false);
        
        Console.WriteLine("Nome do jogador 1: {0}\nEnergia: {1}, {2}", jogador1.nome, jogador1.energia, jogador1.vivo);
        Console.WriteLine("Nome do jogador 2: {0}\nEnergia: {1}, {2}", jogador2.nome, jogador2.energia, jogador2.vivo);   
        Console.WriteLine("Nome do jogador 3: {0}\nEnergia: {1}, {2}", jogador3.nome, jogador3.energia, jogador3.vivo);
    }
}