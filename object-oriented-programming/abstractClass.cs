using System;

abstract class Veiculo{ // Classe base abstrata
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        this.ligado = false;
        this.velAtual = 0;
    }
    public void setLigado(bool _ligado){
        this.ligado = _ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        this.velMaxima = 120;
    }
    override public void aceleracao(int mult){
        this.velAtual += 10*mult;
    }
}
class Aula39{
    static void Main(){
        Carro carro1 = new Carro();

        carro1.aceleracao(1);
        carro1.aceleracao(1);
        carro1.aceleracao(-1);

        Console.WriteLine(carro1.getVelAtual());
    }
}