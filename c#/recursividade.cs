using System;

// recursividade = função chamando ela mesma.

class Calc{
    public double soma(params double[] array){
        double soma = 0;
        for(int i = 0;i < array.Length;i++){
            soma += array[i];
        }
        return soma;
    }
    public int fatorial(int num){
        if(num <= 0){
            return 1;
        }else{
            return num * (fatorial(num - 1));
        }
    }
}
class Aula48{
    static void Main(){
        Calc calc = new Calc();
        //var res = calc.soma(1, 8.6, 7, 5, 3, 4.1, 56.9, 7, 4);

        //Console.WriteLine(res);

        Console.WriteLine(calc.fatorial(10));
    }
}