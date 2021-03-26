using System;

class Veiculo{ // Classe Base
    public int rodas;
    public int velMax;
    private bool ligado;
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return "Sim.";
        }else{
            return "Não.";
        }
    }
}

class Carro:Veiculo{ // Classe derivada
    public string nome;
    public string cor;
    public Carro(string _nome, string _cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = _nome;
        this.cor = _cor;
    }
    public void status(){
        Console.WriteLine("{0} {1}, \n{2} rodas, {3}Km/h, \nLigado: {4}", this.nome, this.cor, this.rodas, this.velMax, this.getLigado());
    }
}

class Aula34{
    static void Main(){
        Carro c1 = new Carro("Celta", "Vermelho");
        c1.status();
        c1.ligar();
        c1.status();
    }
}