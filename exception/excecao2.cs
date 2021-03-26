using System;
class area{
    static public float Quad(float bas, float alt){
        try{
            if(bas <= 0 || alt <= 0){
                throw new Exception("Base ou altura menor ou igual a zero");
            }else{
                return bas * alt;
            }
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Exceção: {0}", e.GetType());
            return 0;
        }
    }
}
class Aula53{
    static void Main(){

        int n1, n2, res;
        res = n1 = n2 = 0;

        int controle = 0;
        try{
            n1 = 10;
            n2 = 2;
            res = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
            controle = 1;
            throw new Exception("Nova exceção");
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Exceção: {0}", e.GetType());
            controle = 0;
        }finally{
            Console.WriteLine(controle == 1 ? "Acima tem um programa rodando" : "Acima tem um erro");
        }

        Console.WriteLine("-------Calculando a area-------");

        Console.Write("Lado 1: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Lado 2: ");
        float v2 = float.Parse(Console.ReadLine());

        if(area.Quad(v1, v2) == 0){
            Console.WriteLine("Ocorreu um erro!");
        }else{
            Console.WriteLine("Area: {0}", area.Quad(v1, v2));
        }
    }
}