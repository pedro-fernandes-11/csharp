using System;
class Carro{
    private int[] velMax = new int[5]{80, 120, 160, 240, 300};
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                this.velMax[i] = 0;
            }else if(value > 300){
                this.velMax[i] = 300;
            }else{
                this.velMax[i] = value;
            }
        }
    }
    public Carro(){}
}
class Aula42{
    static void Main(){

        Carro carro1 = new Carro();

        carro1[4] = 200; // Set acessor
        Console.WriteLine("Velocidade: {0}", carro1[4]); // Get acessor

    }
}