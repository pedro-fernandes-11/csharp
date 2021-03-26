using System;
struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string _marca, string _modelo, string _cor){
        this.marca = _marca;
        this.modelo = _modelo;
        this.cor = _cor;
    }
    public void info(){
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
        Console.WriteLine("============");
    }
}
class Aula44{
    static void Main(){
        
        Carro carro1;

        carro1.marca = "VW";
        carro1.modelo = "Golf";
        carro1.cor = "Azul";

        carro1.info();

        Carro carro2 = new Carro("Honda", "HRV", "Prata"); 
        
        carro2.info();
    }
}