using System;
class Carro{
    private int velMax;
    public int vm{
        get{
            return velMax;
        }
        set{
            if(value < 0){
                this.velMax = 0;
            }else if(value > 300){
                this.velMax = 300;
            }else{
                this.velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120;
    }
}
class Aula41{
    static void Main(){

        Carro carro1 = new Carro();

        carro1.vm = 200; // Set acessor
        Console.WriteLine("Velocidade: {0}", carro1.vm); // Get acessor

    }
}