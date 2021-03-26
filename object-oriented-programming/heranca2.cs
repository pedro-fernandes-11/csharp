using System;

class Veiculo{ // Classe Base
    private int rodas;
    private int velMax;
    private bool ligado;

    public Veiculo(int _rodas){
        this.rodas = _rodas;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public string getLigado(){
        return (ligado ? "Sim" : "Não");
    }
    public int getRodas(){
        return this.rodas;
    }
    public void setRodas(int _rodas){
        if(rodas < 0){
            this.rodas = 0;
        }else if(rodas > 40){
            this.rodas = 40;
        }else{
            this.rodas = _rodas;
        }
    }
    public int getVelMax(){
        return this.velMax;
    }
    public void setVelMax(int _velMax){
        this.velMax = _velMax;
    }
}

class Carro:Veiculo{ // Classe derivada
    public string nome;
    public string cor;
    public Carro(string _nome, string _cor):base(4){
        desligar();
        setVelMax(120);
        this.nome = _nome;
        this.cor = _cor;
    }
    virtual void status(){
        Console.WriteLine("{0} {1}, \n{2} rodas, {3}Km/h, \nLigado: {4}", this.nome, this.cor, this.getRodas(), this.getVelMax(), this.getLigado());
        Console.WriteLine("============================");
    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Carro de combate", "Verde"){
        municao = 100;
        setRodas(6);
        setVelMax(60);
        ligar();
    }
    public void status(){
        Console.WriteLine("{0} {1}, \n{2} rodas, {3}Km/h, \nLigado: {4}\nMunição: {5}", this.nome, this.cor, this.getRodas(), this.getVelMax(), this.getLigado(), this.municao);
        Console.WriteLine("============================");
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro("Celta", "Vermelho");
        CarroCombate cc1 = new CarroCombate();
        
        c1.ligar();
        c1.status();
        cc1.status();

    }
}