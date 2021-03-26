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
class Aula45{
    static void Main(){
        
        Carro carro1;

        carro1.marca = "VW";
        carro1.modelo = "Golf";
        carro1.cor = "Azul";

        carro1.info();

        Carro carro2 = new Carro("Honda", "HRV", "Prata"); 
        
        carro2.info();

        Carro[] carros = new Carro[3];

        carros[0].marca = "Marca1";
        carros[0].modelo = "Modelo1";
        carros[0].cor = "Verde";

        carros[1].marca = "Marca2";
        carros[1].modelo = "Modelo2";
        carros[1].cor = "Preto";

        carros[2].marca = "Marca3";
        carros[2].modelo = "Modelo3";
        carros[2].cor = "Branco";

        for(int i = 0;i < carros.Length;i++){
            carros[i].info();
        }
    }
}