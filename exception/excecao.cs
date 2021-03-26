using System;
class Aula52{
    static void Main(){

        int n1, n2, res;
        res = n1 = n2 = 0;

        try{
            n1 = 10;
            n2 = 0;
            res = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Exceção: {0}", e.GetType());
        }
    }
}